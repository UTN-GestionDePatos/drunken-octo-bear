DROP FUNCTION SHA256
GO
DROP ASSEMBLY Crypt
GO
/*
	Configuración del Motor.
*/
EXEC sp_configure 'clr enabled', 0
GO
EXEC sp_configure 'xp_cmdshell', 0
GO
RECONFIGURE
GO
EXEC sp_configure 'show advanced options', 0
GO

RECONFIGURE

DROP TABLE Administradores
DROP TABLE Cargas
DROP TABLE Giftcards
DROP TABLE Devoluciones
DROP TABLE Cupones
DROP TABLE Tarjetas
DROP TABLE Tipos_pago
DROP TABLE Clientes
DROP TABLE Logins
DROP TABLE Facturas
DROP TABLE Funcion_por_rol
DROP TABLE Funcionalidades
DROP TABLE Localidad_por_usuario
DROP TABLE Localidad_por_grupo
DROP TABLE GruposCupon
DROP TABLE Proveedores
DROP TABLE Direcciones
DROP TABLE Localidades
DROP TABLE Roles
DROP TABLE EstadosUsuarios

DROP VIEW LoginView
DROP FUNCTION idCiudad
DROP FUNCTION idEstadoUsuario
DROP PROCEDURE asignarSaldoInicial
DROP PROCEDURE MigracionManopla
DROP PROCEDURE MigrarDatosSinCursor
DROP PROCEDURE AsignarDireccion
DROP PROCEDURE AltaRol
DROP PROCEDURE ArmarCupon
DROP PROCEDURE AsignarFuncionalidadAlRol
DROP PROCEDURE AsignarLocalidadAlGrupo
DROP PROCEDURE CargarCredito
DROP PROCEDURE ComprarGiftcard
DROP PROCEDURE ConfirmarDevolucion
DROP PROCEDURE Loguearse
DROP PROCEDURE PedirDevolucion


