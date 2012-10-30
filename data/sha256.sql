/*
	Configuración del Motor.
*/
sp_configure 'show advanced options', 1
GO
RECONFIGURE
sp_configure 'clr enabled', 1
GO
sp_configure 'xp_cmdshell', 1
GO
RECONFIGURE
GO

/*
	Creación de funciones auxiliares.
*/
DECLARE @path nvarchar(500)

SET @path = N'$(varPath)' + 'Crypt.dll'


CREATE ASSEMBLY Crypt FROM @path
GO

CREATE FUNCTION SHA256(@text nchar(50))
RETURNS VARBINARY(256) AS 
EXTERNAL NAME Crypt.Crypt.Sha256
GO

PRINT dbo.SHA256('holis')