USE fabiano;

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[sp_buscar_assagenda_geftb005]

AS

BEGIN
	SELECT AG.dt_agenda, ASS.id_associado, ATV.id_atividade, AA.dt_ini, ATV.diasemana, ATV.periodo
	FROM geftb005_agenda AS AG
	RIGHT JOIN geftb004_associado_atividade AS AA ON
	AG.geftb002_associado_id_associado = AA.geftb002_associado_id_associado AND
	AG.geftb003_atividade_id_atividade = AA.geftb003_atividade_id_atividade
	INNER JOIN geftb002_associado AS ASS ON
	ASS.id_associado = AA.geftb002_associado_id_associado
	INNER JOIN geftb003_atividade AS ATV ON
	ATV.id_atividade = AA.geftb003_atividade_id_atividade
	WHERE AG.dt_agenda IS NULL AND
	AA.dt_fim IS NULL AND
	ASS.dt_fim IS NULL AND
	ATV.dt_fim IS NULL;
END
