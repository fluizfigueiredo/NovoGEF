SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[sp_inserir_assagenda_geftb005]

    @dt_agenda DATE = NULL,
	@id_associado INT = 0,
    @id_atividade INT = 0,
	@dt_gravacao DATE = NULL,
    @geftb001_usuario_id_usuario INT = 0

AS

BEGIN
		
	INSERT INTO [dbo].[geftb005_agenda] (dt_agenda, geftb002_associado_id_associado, geftb003_atividade_id_atividade, presenca,
        hr_entrada, vestuario, justificativa, dt_gravacao, geftb001_usuario_id_usuario)
        VALUES (
            @dt_agenda,
            @id_associado,
            @id_atividade,
            NULL,
            NULL,
            NULL,
            NULL,
            @dt_gravacao,
            @geftb001_usuario_id_usuario);
END;
