USE [fabiano]
GO

INSERT INTO [dbo].[geftb006_tipo_associado]
           ([idtipo]
           ,[tipo]
           ,[descricao])
     VALUES
           (NEXT VALUE FOR dbo.geftb006_tipo_associado_idtipo_seq
           ,'G'
           ,'GESTANTE')
GO


