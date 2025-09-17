USE [fabiano]
GO

/****** Object:  StoredProcedure [dbo].[sp_validar_usuario_geftb001]    Script Date: 27/10/2023 14:14:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[sp_validar_usuario_geftb001]

	@matricula varchar(8) = NULL,
    @senha varchar(10) = NULL

AS

BEGIN

    -- Declara uma variável para armazenar o hash da senha
    DECLARE @SenhaHash VARBINARY(32);

    -- Criptografa a senha usando o algoritmo SHA2_256
    SET @SenhaHash = HASHBYTES('SHA2_256', @senha);

	select USU.id_usuario, ASS.nome, USU.nivel
	FROM geftb001_usuario AS USU
	INNER JOIN geftb002_associado AS ASS ON ASS.matricula = USU.matricula AND
			USU.senha = @SenhaHash AND
			USU.dt_fim IS NULL AND
			ASS.dt_fim IS NULL;

--	RETURN;

END;

GO


