USE [fabiano]
GO

/****** Object:  StoredProcedure [dbo].[sp_buscar_geftb002]    Script Date: 14/10/2023 14:54:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[sp_buscar_geftb002]
    @tipo char(1) = NULL,
	@classificacao integer = 0,
	@situacao integer = 0

	AS
  
BEGIN

	IF @classificacao = 0 AND @situacao = 0
		SELECT id_associado, SUBSTRING(MATRICULA,1,6) + '-' + SUBSTRING(MATRICULA,7,2), dt_ini, dt_fim, nome, dt_nascimento, endereco, bairro, cidade, cep, tel1, tel2, cpf, obs, email, parentesco, dt_gravacao, geftb001_usuario_id_usuario
		FROM [dbo].[geftb002_associado]
		WHERE SUBSTRING(matricula,1,1) = @tipo AND dt_fim IS NULL;
	ELSE IF @classificacao = 0 AND @situacao = 1
		SELECT id_associado, SUBSTRING(MATRICULA,1,6) + '-' + SUBSTRING(MATRICULA,7,2), dt_ini, dt_fim, nome, dt_nascimento, endereco, bairro, cidade, cep, tel1, tel2, cpf, obs, email, parentesco, dt_gravacao, geftb001_usuario_id_usuario
		FROM [dbo].[geftb002_associado]
		WHERE SUBSTRING(matricula,1,1) = @tipo AND dt_fim IS NOT NULL;
	ELSE IF @classificacao = 1 AND @situacao = 0
		SELECT id_associado, SUBSTRING(MATRICULA,1,6) + '-' + SUBSTRING(MATRICULA,7,2), dt_ini, dt_fim, nome, dt_nascimento, endereco, bairro, cidade, cep, tel1, tel2, cpf, obs, email, parentesco, dt_gravacao, geftb001_usuario_id_usuario
		FROM [dbo].[geftb002_associado]
		WHERE SUBSTRING(matricula,7,2) = '01' AND SUBSTRING(matricula,1,1) = @tipo AND dt_fim IS NULL;
	ELSE IF @classificacao = 1 AND @situacao = 1
		SELECT id_associado, SUBSTRING(MATRICULA,1,6) + '-' + SUBSTRING(MATRICULA,7,2), dt_ini, dt_fim, nome, dt_nascimento, endereco, bairro, cidade, cep, tel1, tel2, cpf, obs, email, parentesco, dt_gravacao, geftb001_usuario_id_usuario
		FROM [dbo].[geftb002_associado]
		WHERE SUBSTRING(matricula,7,2) = '01' AND SUBSTRING(matricula,1,1) = @tipo AND dt_fim IS NOT NULL;
	ELSE IF @classificacao = 2 AND @situacao = 0
		SELECT id_associado, SUBSTRING(MATRICULA,1,6) + '-' + SUBSTRING(MATRICULA,7,2), dt_ini, dt_fim, nome, dt_nascimento, endereco, bairro, cidade, cep, tel1, tel2, cpf, obs, email, parentesco, dt_gravacao, geftb001_usuario_id_usuario
		FROM [dbo].[geftb002_associado]
		WHERE SUBSTRING(matricula,7,2) <> '01' AND SUBSTRING(matricula,1,1) = @tipo AND dt_fim IS NULL;
	ELSE IF @classificacao = 2 AND @situacao = 1
		SELECT id_associado, SUBSTRING(MATRICULA,1,6) + '-' + SUBSTRING(MATRICULA,7,2), dt_ini, dt_fim, nome, dt_nascimento, endereco, bairro, cidade, cep, tel1, tel2, cpf, obs, email, parentesco, dt_gravacao, geftb001_usuario_id_usuario
		FROM [dbo].[geftb002_associado]
		WHERE SUBSTRING(matricula,7,2) <> '01' AND SUBSTRING(matricula,1,1) = @tipo AND dt_fim IS NOT NULL;
	RETURN;
END;


GO


