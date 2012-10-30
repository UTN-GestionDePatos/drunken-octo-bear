DROP FUNCTION SHA256
GO
DROP ASSEMBLY Crypt
GO
/*
	Configuración del Motor.
*/
sp_configure 'show advanced options', 0
GO
RECONFIGURE
sp_configure 'clr enabled', 0
GO
sp_configure 'xp_cmdshell', 0
GO
RECONFIGURE
GO