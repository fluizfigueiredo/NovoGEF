USE [fabiano]
GO
/****** Object:  StoredProcedure [dbo].[sp_atualizar_geftb010]    Script Date: 17/10/2023 14:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_atualizar_geftb010](
    @id_autor integer = 0,
	@nomeautor character varying(60) = NULL,
	@dt_gravacao date = NULL,
    @geftb001_usuario_id_usuario integer = 0)

AS

BEGIN

	UPDATE [dbo].[geftb010_livautor] SET nomeautor = UPPER(@nomeautor), 
							dt_gravacao = @dt_gravacao, 
							geftb001_usuario_id_usuario = @geftb001_usuario_id_usuario
	WHERE id_autor = @id_autor;
	
END;

GO