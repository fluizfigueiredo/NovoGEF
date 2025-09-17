SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[sp_atualizar_geftb003](
    @id_atividade INT = 0,
	@sigla VARCHAR(10) = NULL,
    @descricao VARCHAR(35) = NULL,
    @grupo VARCHAR(20) = NULL,
    @subgrupo VARCHAR(20) = NULL,
    @hr_ini VARCHAR(8) = NULL,
    @hr_fim VARCHAR(8) = NULL,
    @dt_ini DATE = NULL,
    @dt_fim DATE = NULL,
    @diasemana VARCHAR(15) = NULL,
    @periodo VARCHAR(15) = NULL,
	@dt_gravacao DATE = NULL,
    @geftb001_usuario_id_usuario INT = 0)

AS

BEGIN

	UPDATE [dbo].[geftb003_atividade] SET
							sigla = UPPER(@sigla),
							descricao = UPPER(@descricao),
							grupo = UPPER(@grupo),
							subgrupo = UPPER(@subgrupo),
							hr_ini = @hr_ini,
							hr_fim = @hr_fim,
							dt_ini = @dt_ini,
							dt_fim = @dt_fim,
							diasemana = UPPER(@diasemana),
							periodo = UPPER(@periodo),
							dt_gravacao = @dt_gravacao,
							geftb001_usuario_id_usuario = @geftb001_usuario_id_usuario
	WHERE id_atividade = @id_atividade;

END;

GO
