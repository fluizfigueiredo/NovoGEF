USE [fabiano]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[sp_buscar_geftb001]

AS

BEGIN
    SELECT id_associado, matricula, nome
    FROM geftb002_associado
    WHERE dt_fim IS NULL;
END;