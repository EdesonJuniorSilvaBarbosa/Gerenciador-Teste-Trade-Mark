CREATE OR ALTER   PROCEDURE [dbo].[sp_ContasPendentes]
    @cod_usuario INT,
    @dataInicial DATETIME,
    @dataFinal DATETIME,
    @nome_conta NVARCHAR(100) = NULL
AS
BEGIN
    -- Retorna os nomes das contas dentro do intervalo de datas e preenche o combobox
    SELECT DISTINCT descricao 
    FROM tb_contas
    WHERE cod_usuario = @cod_usuario
      AND data_cont >= @dataInicial
      AND data_cont <= @dataFinal;

    -- Calcular valores pendentes
    SELECT 
        SUM(CASE WHEN tipo = 'Entrada' AND data_cont > GETDATE() THEN valor ELSE 0 END) AS pendente_entradas,
        SUM(CASE WHEN tipo = 'Saida' AND data_cont > GETDATE() THEN valor ELSE 0 END) AS pendente_saidas,
        SUM(CASE WHEN tipo = 'Entrada' AND data_cont <= GETDATE() THEN valor ELSE 0 END) AS recebidos,
        SUM(CASE WHEN tipo = 'Saida' AND data_cont <= GETDATE() THEN valor ELSE 0 END) AS pagos,
        SUM(CASE WHEN tipo = 'Entrada' THEN valor ELSE 0 END) AS previsto_entradas,
        SUM(CASE WHEN tipo = 'Saida' THEN valor ELSE 0 END) AS previsto_saidas
    FROM tb_contas
    WHERE cod_usuario = @cod_usuario 
      AND data_cont >= @dataInicial 
      AND data_cont <= @dataFinal
	  AND (@nome_conta IS NULL OR @nome_conta = 'Todas as Contas' OR descricao = @nome_conta);

    -- Retorna as contas e carrega o DataGridView
    SELECT 
        cod_conta, 
        cod_usuario, 
        tipo, 
        data_cont, 
        valor, 
        descricao,
        CASE
            WHEN data_cont < GETDATE() AND tipo = 'Entrada' THEN 'Recebido'
            WHEN data_cont >= GETDATE() AND tipo = 'Entrada' THEN 'Receberá em: ' + CAST(DATEDIFF(DAY, GETDATE(), data_cont) AS VARCHAR(10)) + ' dias'
            WHEN data_cont < GETDATE() AND tipo = 'Saida' THEN 'Pago'
            WHEN data_cont >= GETDATE() AND tipo = 'Saida' THEN 'Vencerá em: ' + CAST(DATEDIFF(DAY, GETDATE(), data_cont) AS VARCHAR(10)) + ' dias'
            ELSE 'Outro Status'
        END AS status_cont
    FROM tb_contas
    WHERE cod_usuario = @cod_usuario 
      AND data_cont >= @dataInicial 
      AND data_cont <= @dataFinal
	  AND (@nome_conta IS NULL OR @nome_conta = 'Todas as Contas' OR descricao = @nome_conta);
END
GO