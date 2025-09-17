USE [fabiano]
GO
/****** Object:  StoredProcedure [dbo].[sp_atualizar_geftb009]    Script Date: 17/10/2023 14:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_atualizar_geftb009](
    @id_autesp integer = 0,
	@nomeautesp character varying(60) = NULL,
	@dt_gravacao date = NULL,
    @geftb001_usuario_id_USUARIO integer = 0)

AS

BEGIN

	UPDATE [dbo].[geftb009_livautesp] SET nomeautesp = UPPER(@nomeautesp), 
							dt_gravacao = @dt_gravacao, 
							geftb001_usuario_id_usuario= @geftb001_usuario_id_usuario
	WHERE id_autesp = @id_autesp;
	
END;

GO