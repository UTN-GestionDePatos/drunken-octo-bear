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
