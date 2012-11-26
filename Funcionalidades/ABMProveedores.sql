--CREAR PROVEEDOR
CREATE PROCEDURE GESTION_DE_PATOS.AltaProveedor(@user varchar(30),@pass varchar(50),@cuit nvarchar(20),@razon_social varchar(30),@mail varchar(30),
@telefono bigint,@direccion varchar(100), @codigo_postal int, @ciudad varchar(30), @rubro varchar(30), @nombre_contacto varchar(30), @ret int output) 
AS
BEGIN
	IF NOT EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Proveedores WHERE username = @user)
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Proveedores WHERE razon_social = @razon_social OR telefono = @telefono
								OR mail = @mail OR cuit = @cuit) AND NOT EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Clientes 
								WHERE telefono = @telefono OR mail = @mail)
		BEGIN
			INSERT INTO GESTION_DE_PATOS.Usuarios VALUES(@user,GESTION_DE_PATOS.SHA256(@pass),'Proveedor', GESTION_DE_PATOS.idEstadoUsuario('Habilitado') ,0)
			INSERT INTO GESTION_DE_PATOS.Proveedores VALUES(@user,@cuit,@razon_social,@mail,@telefono,@direccion,@codigo_postal,GESTION_DE_PATOS.idCiudad(@ciudad),GESTION_DE_PATOS.idRubro(@rubro),@nombre_contacto)
			
			set @ret = 0
		END
		ELSE
		BEGIN
			set @ret = 2
		END
			
	END
	ELSE
	BEGIN
		set @ret = 1
	END

END

GO

--MODFICAR PROVEEDOR
CREATE PROCEDURE GESTION_DE_PATOS.ModificarProveedor(@user varchar(30),@cuit nvarchar(20),@razon_social varchar(30),@mail varchar(30),
@telefono bigint,@direccion varchar(100),@codigo_postal int,@ciudad varchar(30),@rubro varchar(30),@nombre_contacto varchar(30), @estado varchar(20), @ret int output) 
AS
BEGIN

	IF EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Proveedores WHERE username = @user)
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Proveedores WHERE (razon_social = @razon_social OR telefono = @telefono
							OR cuit = @cuit OR mail = @mail) AND username <> @user) AND NOT EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Clientes 
							where (telefono = @telefono OR mail = @mail) AND username <> @user)
		BEGIN
			UPDATE GESTION_DE_PATOS.Proveedores SET cuit=@cuit,
													razon_social = @razon_social,
													mail = @mail,
													telefono = @telefono,
													direccion = @direccion,
													codigo_postal = @codigo_postal,
													ciudad = GESTION_DE_PATOS.idCiudad(@ciudad),
													id_rubro = GESTION_DE_PATOS.idRubro(@rubro),
													nombre_contacto = @nombre_contacto
												WHERE username = @user
						
			IF (@estado='Habilitado' OR @estado = 'Deshabilitado') 
			BEGIN
				UPDATE GESTION_DE_PATOS.Usuarios SET estado= GESTION_DE_PATOS.idEstadoUsuario(@estado) WHERE username = @user
			END	
					
			set @ret = 0
		END
		ELSE
		BEGIN
			set @ret = 2
		END
	END
	ELSE
	BEGIN
		set @ret = 1
	END
END
go

--ELIMINAR PROVEEDOR

CREATE PROCEDURE GESTION_DE_PATOS.EliminarProveedor(@user varchar(30), @ret int output)
AS
BEGIN
	IF EXISTS(SELECT * FROM GESTION_DE_PATOS.Usuarios WHERE username = @user)
	BEGIN
	
		UPDATE GESTION_DE_PATOS.Usuarios SET estado = GESTION_DE_PATOS.idEstadoUsuario('Eliminado')
										 WHERE username = @user
		
		set @ret = 0
		--Proveedor eliminado								 
	END
	ELSE
	BEGIN
		set @ret = 1
	END
	--El proveedor no existe
END
