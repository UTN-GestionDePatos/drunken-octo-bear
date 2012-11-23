DROP FUNCTION GESTION_DE_PATOS.SHA256
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

DROP TABLE GESTION_DE_PATOS.Administradores
DROP TABLE GESTION_DE_PATOS.Cargas
DROP TABLE GESTION_DE_PATOS.Giftcards
DROP TABLE GESTION_DE_PATOS.Devoluciones
DROP TABLE GESTION_DE_PATOS.Canjes
DROP TABLE GESTION_DE_PATOS.Cupones
DROP TABLE GESTION_DE_PATOS.Tarjetas
DROP TABLE GESTION_DE_PATOS.Tipos_pago
DROP TABLE GESTION_DE_PATOS.Clientes
DROP TABLE GESTION_DE_PATOS.Facturas
DROP TABLE GESTION_DE_PATOS.Funcion_por_rol
DROP TABLE GESTION_DE_PATOS.Funcionalidades
DROP TABLE GESTION_DE_PATOS.Localidad_por_usuario
DROP TABLE GESTION_DE_PATOS.Localidad_por_promocion
DROP TABLE GESTION_DE_PATOS.Promociones
DROP TABLE GESTION_DE_PATOS.Proveedores
DROP TABLE GESTION_DE_PATOS.Localidades
DROP TABLE GESTION_DE_PATOS.Roles
DROP TABLE GESTION_DE_PATOS.Usuarios
DROP TABLE GESTION_DE_PATOS.EstadosUsuarios
DROP TABLE GESTION_DE_PATOS.Rubros

--DROP VIEW LoginView
DROP FUNCTION GESTION_DE_PATOS.idCiudad
DROP FUNCTION GESTION_DE_PATOS.idEstadoUsuario
DROP PROCEDURE GESTION_DE_PATOS.AltaRol
DROP PROCEDURE GESTION_DE_PATOS.ArmarCupon
DROP PROCEDURE GESTION_DE_PATOS.AsignarFuncionalidadAlRol
DROP PROCEDURE GESTION_DE_PATOS.AsignarLocalidadAlGrupo
DROP PROCEDURE GESTION_DE_PATOS.CargarCredito
DROP PROCEDURE GESTION_DE_PATOS.ComprarGiftcard
DROP PROCEDURE GESTION_DE_PATOS.ConfirmarDevolucion
DROP PROCEDURE GESTION_DE_PATOS.Loguearse
DROP PROCEDURE GESTION_DE_PATOS.PedirDevolucion
DROP FUNCTION GESTION_DE_PATOS.FuncionalidadesDelRol
DROP PROCEDURE GESTION_DE_PATOS.EliminarRol
DROP PROCEDURE GESTION_DE_PATOS.EliminarFuncionalidadesDeRol
DROP FUNCTION GESTION_DE_PATOS.idRubro
DROP PROCEDURE GESTION_DE_PATOS.ComprarCupon
DROP PROCEDURE GESTION_DE_PATOS.PublicarCupon

DROP SCHEMA GESTION_DE_PATOS