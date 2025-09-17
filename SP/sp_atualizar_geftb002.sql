SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[sp_atualizar_geftb002]

	@id_associado AS INT = 0,
    @nome VARCHAR(60) = NULL,
    @dt_nascimento DATE = NULL,
    @dt_ini DATE = NULL,
    @dt_fim DATE = NULL,
    @cpf VARCHAR(11) = NULL,
    @tel1 VARCHAR(9) = NULL,
    @tel2 VARCHAR(9) = NULL,
    @email VARCHAR(100) = NULL,
    @endereco VARCHAR(60) = NULL,
    @bairro VARCHAR(30) = NULL,
    @cidade VARCHAR(15) = NULL,
    @cep VARCHAR(9) = NULL,
    @parentesco VARCHAR(20) = NULL,
    @obs VARCHAR(100) = NULL,
	@dt_gravacao DATE = NULL,
    @geftb001_usuario_id_usuario INT = 0

AS

BEGIN

	SET NOCOUNT ON;

	UPDATE [dbo].[geftb002_associado] SET
			dt_ini 					= 	@dt_ini,
			dt_fim 					= 	@dt_fim,
			nome 					= 	UPPER(@nome),
			dt_nascimento 			= 	@dt_nascimento,
			endereco 				=	UPPER(@endereco),
			bairro 					= 	UPPER(@bairro),
			cidade 					= 	UPPER(@cidade),
			cep 					= 	@cep,
			tel1 					= 	@tel1,
			tel2 					=	@tel2,
			cpf 					= 	@cpf,
			obs 					= 	UPPER(@obs),
			email 					= 	@email,
			parentesco 				= 	@parentesco,
			dt_gravacao 				= 	@dt_gravacao,
			geftb001_usuario_id_usuario 	=	@geftb001_usuario_id_usuario
	WHERE id_associado = @id_associado;

END;
GO