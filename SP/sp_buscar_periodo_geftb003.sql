USE [fabiano]
GO

/****** Object:  StoredProcedure [dbo].[sp_buscar_periodo_geftb003]    Script Date: 26/10/2023 08:46:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[sp_buscar_periodo_geftb003]

@id_atividade integer = 0

	AS
  
BEGIN

SELECT [periodo]
  FROM [fabiano].[dbo].[geftb003_atividade] 
  WHERE id_atividade = @id_atividade
	RETURN;
END;


GO