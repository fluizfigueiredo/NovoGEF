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
CREATE OR ALTER PROCEDURE [dbo].[sp_buscar_dtsagenda_geftb005]

	@id_atividade INT = 0

AS

BEGIN
	SELECT DISTINCT AG.dt_agenda, ATV.id_atividade
	FROM [dbo].[geftb005_agenda] AS AG
	INNER JOIN geftb002_associado AS ASS ON
	ASS.id_associado = AG.geftb002_associado_id_associado
	INNER JOIN geftb003_atividade AS ATV ON
	ATV.id_atividade = AG.geftb003_atividade_id_atividade
	WHERE AG.geftb003_atividade_id_atividade = @id_atividade;
END
