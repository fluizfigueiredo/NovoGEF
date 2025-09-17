USE [fabiano]
GO
/****** Object:  StoredProcedure [dbo].[sp_buscar_assatv_sem_agenda_geftb004]    Script Date: 25/10/2023 08:26:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[sp_buscar_assatv_sem_agenda_geftb004]
    @diasemana VARCHAR(15) = NULL

	AS
  
BEGIN

SELECT AA.geftb002_associado_id_associado, AA.geftb003_atividade_id_atividade, AA.dt_ini, ATV.periodo
	FROM [dbo].[geftb004_associado_atividade] AS AA
	INNER JOIN geftb002_associado AS ASS ON AA.geftb002_associado_id_associado = ASS.id_associado
	INNER JOIN geftb003_atividade AS ATV ON AA.geftb003_atividade_id_atividade = ATV.id_atividade
	WHERE  ATV.diasemana = UPPER(@diasemana) AND 
	AA.dt_fim IS NULL AND
	ASS.dt_fim IS NULL AND
	ATV.dt_fim IS NULL;

	RETURN;
END;
