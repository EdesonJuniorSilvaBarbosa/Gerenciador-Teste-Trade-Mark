USE [db_gerenciador_financeiro]
GO

/****** Object:  StoredProcedure [dbo].[sp_GerarDemonstrativoGrafico]    Script Date: 10/06/2024 17:13:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[sp_GerarDemonstrativoGrafico]
	@cod_usuario INT,
	@ano INT,
	@mes INT
AS
BEGIN
	SELECT
		cod_usuario,
		descricao,
		tipo,
		SUM(valor) as valor
	FROM
		tb_contas
	WHERE
			cod_usuario = @cod_usuario
		AND YEAR(data_cont) = @ano
		AND MONTH(data_cont) = @mes
		AND data_cont <= getdate()
	GROUP BY
		cod_usuario,
		descricao,
		tipo
END
GO


