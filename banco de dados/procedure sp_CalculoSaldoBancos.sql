-- Verifica se a procedure já existe, caso sim deleta e recria
IF OBJECT_ID('sp_CalculoSaldoBancos','P') IS NOT NULL
	DROP PROCEDURE sp_CalculoSaldoBancos
GO

CREATE PROCEDURE sp_CalculoSaldoBancos
    @cod_usuario INT
AS
BEGIN
    -- Variáveis para armazenar os valores intermediários
    DECLARE @total_saldo DECIMAL(18, 2);
    DECLARE @pendente_entradas DECIMAL(18, 2);
    DECLARE @pendente_saidas DECIMAL(18, 2);
    DECLARE @saldo_previsto DECIMAL(18, 2);
    DECLARE @num_contas INT;

    -- Obter o saldo total atual
    SELECT @total_saldo = SUM(saldo)
    FROM tb_bancos
    WHERE cod_usuario = @cod_usuario;

    -- Verificar se o usuário tem contas cadastradas
    SELECT @num_contas = COUNT(*)
    FROM tb_contas
    WHERE cod_usuario = @cod_usuario;

    -- Se o usuário não tem contas cadastradas
    IF @num_contas > 0
		BEGIN
			-- Obter os valores de entradas e saídas pendentes
			SELECT 
				@pendente_entradas = SUM(CASE WHEN tipo = 'Entrada' AND data_cont > GETDATE() THEN valor ELSE 0 END),
				@pendente_saidas = SUM(CASE WHEN tipo = 'Saida' AND data_cont > GETDATE() THEN valor ELSE 0 END)
			FROM tb_contas
			WHERE cod_usuario = @cod_usuario
			AND MONTH(data_cont) = MONTH(GETDATE());
		END
	ELSE
        BEGIN
            -- Calcular o saldo previsto no final do mês
            SET @saldo_previsto = @total_saldo + @pendente_entradas - @pendente_saidas;

            -- Retornar os dados da tabela de bancos e o saldo previsto
            SELECT 
                tb_bancos.*,
                @total_saldo AS total_saldo,
                @saldo_previsto AS saldo_previsto
            FROM tb_bancos
            WHERE cod_usuario = @cod_usuario;
        END
END
GO

