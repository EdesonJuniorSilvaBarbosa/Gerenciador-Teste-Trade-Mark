-- verifica se a tabela 'log_eventos_contas' existe, caso sim drop e recria
IF OBJECT_ID('log_eventos_contas') IS NOT NULL
	DROP TABLE log_eventos_contas
GO

IF OBJECT_ID('log_eventos_bancos') IS NOT NULL
	DROP TABLE log_eventos_bancos
GO

-- cria a tabelas
BEGIN
	-- cria a tabela log_eventos_contas
	CREATE TABLE log_eventos_contas (
		cod_evento INT PRIMARY KEY IDENTITY(1,1),
		tabela_afetada VARCHAR(50),
		acao VARCHAR(10),
		nome_conta VARCHAR(100),
		campo_alterado VARCHAR(100),
		valor_anterior VARCHAR(100),
		data_hora DATETIME DEFAULT GETDATE(),
		cod_usuario INT, -- armazena o codigo do usuário
		cod_conta INT
	);

	-- cria a tabela log_eventos_bancos
		CREATE TABLE log_eventos_bancos (
		cod_evento INT PRIMARY KEY IDENTITY(1,1),
		tabela_afetada VARCHAR(50),
		acao VARCHAR(10),
		nome_banco VARCHAR(100),
		campo_alterado VARCHAR(100),
		saldo_anterior VARCHAR(100),
		data_hora DATETIME DEFAULT GETDATE(),
		cod_usuario INT, -- armazena o codigo do usuário
		cod_banco INT
	);
END;

-- Renomeando o nome da coluna valor_anterior para saldo_anterior da tabela banco
EXEC sp_rename 'log_eventos_bancos.valor_anterior', 'saldo_anterior', 'COLUMN';

-- 1º Excuta o Alterar o tipo do dado da coluna data_hora, se houver erros...
ALTER TABLE log_eventos_bancos ALTER COLUMN data_hora SMALLDATETIME;

--2º Executa o Remover ou Desativar a Restrição Padrão e retorna o 1º passo
ALTER TABLE log_eventos_bancos DROP CONSTRAINT DF__log_event__data___7FB5F314;

--3º Executa o Recriar a Restrição Padrão após rodar o 2º e 1º passo
ALTER TABLE log_eventos_bancos ADD CONSTRAINT DF__log_event__data___7FB5F314 DEFAULT GETDATE() FOR data_hora;

-- cria as triggers 
CREATE OR ALTER TRIGGER [dbo].[trg_log_alteracoes_contas]
ON [dbo].[tb_contas]
AFTER UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @acao VARCHAR(10);
    DECLARE @codUsuarioAutenticado INT;
    DECLARE @codConta INT;
    DECLARE @nomeConta VARCHAR(100);

    -- Capturar o código do usuário autenticado passado pelo parâmetro
    SELECT @codUsuarioAutenticado = ISNULL((SELECT cod_usuario FROM inserted), (SELECT cod_usuario FROM deleted));

    -- Captura o código da conta que foi alterada
    SELECT @codConta = ISNULL((SELECT cod_conta FROM inserted), (SELECT cod_conta FROM deleted));

    -- Determinar a ação (UPDATE, DELETE)
    IF EXISTS (SELECT * FROM deleted)
    BEGIN
        IF EXISTS (SELECT * FROM inserted)
            SET @acao = 'UPDATE'; -- Se existem registros em ambas inserted e deleted, é um UPDATE
        ELSE
            SET @acao = 'DELETE'; -- Se existem apenas em deleted, é um DELETE
    END
    ELSE
        RETURN; -- Não há registros em deleted, então não faz sentido continuar (pode ser um INSERT, mas não tratado aqui)

    -- Captura nome conta
    SELECT @nomeConta = ISNULL(i.descricao, d.descricao)
    FROM inserted i
    FULL OUTER JOIN deleted d ON i.cod_conta = d.cod_conta;

    -- Utilizar tabela temporária para armazenar dados de inserted e deleted
    IF OBJECT_ID('tempdb..#TempContas') IS NOT NULL
        DROP TABLE #TempContas;

    SELECT i.cod_conta, i.tipo, i.data_cont, i.descricao, i.valor, d.tipo AS tipo_antigo, d.data_cont AS data_cont_antiga, d.descricao AS descricao_antiga, d.valor AS valor_antigo
    INTO #TempContas
    FROM inserted i
    FULL OUTER JOIN deleted d ON i.cod_conta = d.cod_conta;

    -- Inserir registros na tabela log_eventos_contas para cada campo alterado
    IF @acao = 'UPDATE'
    BEGIN
        INSERT INTO log_eventos_contas (tabela_afetada, acao, nome_conta, campo_alterado, valor_anterior, data_hora, cod_usuario, cod_conta)
        SELECT 'tb_contas', @acao, @nomeConta, 'tipo', CONVERT(VARCHAR(MAX), tipo_antigo), GETDATE(), @codUsuarioAutenticado, cod_conta
        FROM #TempContas
        WHERE tipo <> tipo_antigo;

        INSERT INTO log_eventos_contas (tabela_afetada, acao, nome_conta, campo_alterado, valor_anterior, data_hora, cod_usuario, cod_conta)
        SELECT 'tb_contas', @acao, @nomeConta, 'data_cont', CONVERT(VARCHAR(MAX), data_cont_antiga), GETDATE(), @codUsuarioAutenticado, cod_conta
        FROM #TempContas
        WHERE data_cont <> data_cont_antiga;

        INSERT INTO log_eventos_contas (tabela_afetada, acao, nome_conta, campo_alterado, valor_anterior, data_hora, cod_usuario, cod_conta)
        SELECT 'tb_contas', @acao, @nomeConta, 'descricao', descricao_antiga, GETDATE(), @codUsuarioAutenticado, cod_conta
        FROM #TempContas
        WHERE descricao <> descricao_antiga;

        INSERT INTO log_eventos_contas (tabela_afetada, acao, nome_conta, campo_alterado, valor_anterior, data_hora, cod_usuario, cod_conta)
        SELECT 'tb_contas', @acao, @nomeConta, 'valor', CONVERT(VARCHAR(MAX), valor_antigo), GETDATE(), @codUsuarioAutenticado, cod_conta
        FROM #TempContas
        WHERE valor <> valor_antigo;
    END
    ELSE IF @acao = 'DELETE'
    BEGIN
        -- Inserir registro na tabela log_eventos para o DELETE
        INSERT INTO log_eventos_contas (tabela_afetada, acao, nome_conta, campo_alterado, valor_anterior, data_hora, cod_usuario, cod_conta)
        SELECT 'tb_contas', @acao, @nomeConta, NULL, NULL, GETDATE(), @codUsuarioAutenticado, @codConta;
    END;

    DROP TABLE #TempContas;
END;
GO

CREATE OR ALTER   TRIGGER [dbo].[trg_log_alteracoes_bancos]
ON [dbo].[tb_bancos]
AFTER UPDATE, DELETE
AS
BEGIN
    DECLARE @acao VARCHAR(10);
    DECLARE @codUsuarioAutenticado INT;
	DECLARE @codBanco INT;
	DECLARE @nomeBanco VARCHAR(100);
	DECLARE @campoAlterado VARCHAR(MAX) = ''; -- String para concatenar os campos alterados
	DECLARE @saldoAnterior VARCHAR(MAX) = ''; -- String para concatenar os valores antigos

	-- Capturar o código do usuário autenticado passado pelo parâmetro
	SELECT @codUsuarioAutenticado = ISNULL((SELECT cod_usuario FROM inserted), (SELECT cod_usuario FROM deleted));

	-- Captura o código do banco alterado
	SELECT @codBanco = ISNULL((SELECT cod_banco FROM inserted), (SELECT cod_banco FROM deleted));

    -- Determinar a ação (UPDATE, DELETE)
    IF EXISTS (SELECT * FROM deleted)
		BEGIN
			IF EXISTS (SELECT * FROM inserted)
				SET @acao = 'UPDATE'; -- Se existem registros em ambas inserted e deleted, é um UPDATE
			ELSE
				SET @acao = 'DELETE'; -- Se existem apenas em deleted, é um DELETE
		END
	ELSE
		 RETURN; --não há registros em deleted, então não faz sentido continuar (pode ser um INSERT, mas não tratado aqui)

	 -- Captura nome conta
	SELECT @nomeBanco = ISNULL(i.nome_banco, d.nome_banco)
	FROM inserted i
	FULL OUTER JOIN deleted d ON i.cod_banco = d.cod_banco;
	
	-- Captura o campo alterado
IF @acao = 'UPDATE'
BEGIN
    -- Monta a lista de campos alterados e seus valores antigos
    SELECT @campoAlterado = @campoAlterado + 
                                CASE
                                    WHEN i.saldo <> d.saldo THEN 'saldo, '
                                    ELSE ''
                                END,
           @saldoAnterior = @saldoAnterior + 
                                CASE
                                    WHEN i.saldo <> d.saldo THEN CONVERT(VARCHAR(MAX), d.saldo) + ', '
                                    ELSE ''
                                END
    FROM inserted i
    INNER JOIN deleted d ON i.cod_banco = d.cod_banco;

    -- Remove a vírgula extra no final das strings, se houver
    SET @campoAlterado = CASE WHEN LEN(@campoAlterado) > 0 THEN LEFT(@campoAlterado, LEN(@campoAlterado) - 1) ELSE '' END;
    SET @saldoAnterior = CASE WHEN LEN(@saldoAnterior) > 0 THEN LEFT(@saldoAnterior, LEN(@saldoAnterior) - 1) ELSE '' END;

	END
	ELSE
	BEGIN
		SET @campoAlterado = NULL;
		SET @saldoAnterior = NULL;
	END

    -- Inserir o registro na tabela log_eventos
    INSERT INTO log_eventos_bancos (tabela_afetada, acao, nome_banco, campo_alterado, saldo_anterior, data_hora, cod_usuario, cod_banco)
    VALUES ('tb_bancos', @acao, @nomeBanco, @campoAlterado, @saldoAnterior, GETDATE(), @codUsuarioAutenticado, @codBanco);

END;
GO







