USE [fabiano]
GO
/****** Object:  StoredProcedure [dbo].[sp_buscar_geftb003]    Script Date: 23/10/2023 14:50:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[sp_buscar_horario_geftb003]

@sigla varchar(10) = NULL

AS

BEGIN

	SELECT hr_ini FROM geftb003_atividade WHERE sigla = @sigla;

	RETURN;
END;

