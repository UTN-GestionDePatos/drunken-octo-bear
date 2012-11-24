--CREAR PROVEEDOR
CREATE PROCEDURE AltaProveedor(@user varchar(30),@pass varchar(30),@cuit bigint,@razon_social varchar(30),@mail varchar(30),
@telefono bigint,@direccion varchar(100),@id_rubro bigint, @nombre_contacto varchar(30),@piso int, @departamento int,@ciudad int, @ret int output) 
AS
BEGIN

	IF (NOT EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Proveedores WHERE username = @user AND cuit = @cuit AND razon_social = @razon_social ) )
	BEGIN
		INSERT INTO GESTION_DE_PATOS.Usuarios VALUES(@user,GESTION_DE_PATOS.SHA256(@pass),'Proveedor', GESTION_DE_PATOS.idEstadoUsuario('Habilitado') ,0)
		INSERT INTO GESTION_DE_PATOS.Proveedores VALUES(@user,@cuit,@razon_social,@mail,@telefono, @direccion,@ciudad,@id_rubro,@nombre_contacto)
		
		set @ret = 0
	END
	
	set @ret = 1
END

go

--MODFICAR PROVEEDOR
CREATE PROCEDURE ModificarProveedor(@user varchar(30),@pass varchar(30),@cuit bigint,@razon_social varchar(30),@mail varchar(30),
@telefono bigint,@direccion varchar(100),@id_rubro bigint, @nombre_contacto varchar(30),@piso int, @departamento int, @ciudad int, @estado varchar(20), @ret int output) 
AS
BEGIN

	IF EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Proveedores WHERE username = @user)
	BEGIN
		UPDATE GESTION_DE_PATOS.Proveedores SET cuit=@cuit,razon_social=@razon_social,mail=@mail,telefono=@telefono,direccion = @direccion,
		ciudad = @ciudad, id_rubro = @id_rubro, nombre_contacto=@nombre_contacto
							WHERE username = @user
					
		IF (@estado='Habilitado' OR @estado = 'Deshabilitado') 
		BEGIN
			UPDATE GESTION_DE_PATOS.Usuarios SET estado= GESTION_DE_PATOS.idEstadoUsuario(@estado) WHERE username =@user
		END	
				
		set @ret = 0
	END
	
	set @ret = 1
END
go

--ELIMINAR PROVEEDOR

CREATE PROCEDURE EliminarProveedor(@user varchar(30), @ret int output)
AS
BEGIN
	IF EXISTS(SELECT * FROM GESTION_DE_PATOS.Usuarios WHERE username = @user)
	BEGIN
	
		UPDATE GESTION_DE_PATOS.Usuarios SET estado = GESTION_DE_PATOS.idEstadoUsuario('Eliminado')
										 WHERE username = @user
		
		set @ret = 0
		--Proveedor eliminado								 
	END
	
	set @ret = 1
	--El proveedor no existe
END


--CREAR PROVEEDOR
CREATE PROCEDURE CrearProveedor(@user varchar(30),@pass varchar(30),@cuit bigint,@razon_social varchar(30),@mail varchar(30),
@telefono bigint,@direccion varchar(100),@ciudad varchar(30),@nombre_contacto varchar(30)) 
AS
BEGIN
	insert into GESTION_DE_PATOS.Usuarios values(@user,GESTION_DE_PATOS.SHA256(@pass),'Proveedor', GESTION_DE_PATOS.idEstado('Habilitado') ,0)
	insert into GESTION_DE_PATOS.Proveedores values(@user,@cuit,@razon_social,@mail,@telefono, @direccion,@ciudad,SCOPE_IDENTITY(),@nombre_contacto)
END

go

--MODFICAR PROVEEDOR
CREATE PROCEDURE ModificarProveedor(@user varchar(30),@cuit bigint,@razon_social varchar(30),@mail varchar(30),
@telefono bigint,@direccion varchar(100),@ciudad varchar(30),@nombre_contacto varchar(30), @estado varchar(20))
AS
BEGIN
	Update GESTION_DE_PATOS.Proveedores set cuit=@cuit,razon_social=@razon_social,mail=@mail,telefono=@telefono,direccion = @direccion,
	ciudad = @ciudad, nombre_contacto=@nombre_contacto
						where username = @user
	IF (@estado='Habilitado')
	BEGIN
	Update GESTION_DE_PATOS.Usuarios set estado= GESTION_DE_PATOS.idEstado('Habilitado') where username =@user
	END
END
go

--ELIMINAR PROVEEDOR

CREATE PROCEDURE EliminarProveedor(@user varchar(30))
AS
BEGIN
	Update GESTION_DE_PATOS.Usuarios set estado= dbo.idEstado('Deshabilitado') where username =@user
END
