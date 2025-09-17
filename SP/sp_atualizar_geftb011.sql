USE [fabiano]
GO
/****** Object:  StoredProcedure [dbo].[sp_atualizar_geftb011]    Script Date: 17/10/2023 14:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_atualizar_geftb011](
    @id_editora int = 0,
    @descricao character varying(30) = NULL,
    @cnpj character varying(14) = NULL,
    @tel1 character varying(9) = NULL,
    @tel2 character varying(9) = NULL,
    @email character varying(100) = NULL,
	@dt_gravacao date = NULL,
    @geftb001_usuario_id_usuario integer = 0)

AS

BEGIN

	UPDATE [dbo].[geftb011_liveditora] 
	SET descricao = UPPER(@descricao)
	, cnpj = @cnpj
	, tel1 = @tel1
	, tel2 = @tel2
	, email = @email
	, dt_gravacao = @dt_gravacao 
	, geftb001_usuario_id_usuario = @geftb001_usuario_id_usuario
	WHERE id_editora = @id_editora;
	
END;

GO