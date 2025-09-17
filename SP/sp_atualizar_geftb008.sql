USE [fabiano]
GO
/****** Object:  StoredProcedure [dbo].[sp_atualizar_geftb008]    Script Date: 17/10/2023 14:09:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_atualizar_geftb008](
    @id_estoquemed integer = 0,
    @nomecom varchar(30) = NULL,
    @nomequi varchar(30) = NULL,
    @lote integer = 0,
    @prateleira integer = 0,
    @estoque integer = 0,
    @grfarmaco integer = 0,
    @dt_validade date = NULL,
	@dt_gravacao date = NULL,
    @geftb001_usuario_id_usuario integer = 0)

AS

BEGIN

	UPDATE [dbo].[geftb008_estoquemed] 
	SET nomecomerc = UPPER(@nomecom), 
	    nomequimico = UPPER(@nomequi), 
		geftb007_grfarmaco_id_grfarmaco = @grfarmaco, 
		lote = @lote, 
		estoque = @estoque, 
		prateleira = @prateleira, 
		dt_validade = @dt_validade, 
		dt_gravacao = @dt_gravacao, 
		geftb001_usuario_id_usuario = @geftb001_usuario_id_usuario
	WHERE id_estoquemed = @id_estoquemed;
	
END;

GO