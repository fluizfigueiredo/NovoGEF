USE [fabiano]
GO
/****** Object:  StoredProcedure [dbo].[sp_atualizar_geftb012]    Script Date: 17/10/2023 14:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_atualizar_geftb012]

	@id_livraria int = 0, 
	@titulo varchar(100) = NULL, 
	@assunto  varchar(100) = NULL,
	@autor int = 0, 
	@autoresp int = 0,
	@editora int = 0, 
	@estoque int = 0, 
	@vl_unitario decimal(5,2) = 0,
	@vl_livraria decimal(5,2) = 0,
	@vl_feira decimal(5,2) = 0, 
	@dt_gravacao date = NULL,
    @geftb001_usuario_id_usuario integer = 0

AS

BEGIN

	UPDATE [dbo].[geftb012_livraria] 
	SET titulo = UPPER(@titulo)
	, assunto = UPPER(@assunto)
	, geftb010_livautor_id_autor = @autor
	, geftb009_livautesp_id_autesp = @autoresp
	, geftb011_liveditora_id_editora = @editora
	, estoque = @estoque
	, vl_unitario = @vl_unitario
	, vl_livraria = @vl_livraria
	, vl_feira = @vl_feira
	, dt_gravacao = @dt_gravacao 
	, geftb001_usuario_id_usuario = @geftb001_usuario_id_usuario
	WHERE id_livraria = @id_livraria;
	
END;

GO