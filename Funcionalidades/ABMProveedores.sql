--CREAR PROVEEDOR
CREATE PROCEDURE CrearProveedor(@user,@pass,@rol,@cuit,@razon,@mail,@tel,@rubro,@nombre,@calle,@altura,@piso,@dpto,@localidad,@cp) 
AS
BEGIN
	insert into Logins values(@user,dbo.SHA256(@pass),@rol, dbo.idEstado('Habilitado') ,0)
	insert into Direcciones(calle,altura,piso,departamento,codigo_postal ) values(@calle,@altura,@piso,@dpto,@cp)
	insert into Proveedores values(@user,@cuit,@razon,@mail,@tel, SCOPE_IDENTITY(),SCOPE_IDENTITY(),@rubro,@nombre)
END

--MODFICAR PROVEEDOR
CREATE PROCEDURE ModificarProveedor(@user,@rol,@cuit,@razon,@mail,@tel,@rubro,@nombre,@calle,@altura,@piso,@dpto,@localidad,@cp)
AS
BEGIN
	Update Proveedores set cuit=@cuit,razon_social=@razon,mail=@mail,telefono=@tel,rubro=@rubro,nombre_contacto=@nombre	
	Update Direcciones set d.calle=@calle, d.altura=@altura, d.piso=@piso, d.departamento=@dpto, d.codigo_postal=@cp 
						from Direcciones d join Proveedores c on d.id_direccion = c.id_direccion AND c.username = @user
	Update Localidades set localidad=@localidad
	IF (@estado='Habilitado')
	BEGIN
	Update Logins set estado= dbo.idEstado('Habilitado') where username =@username
	END
END

--ELIMINAR PROVEEDOR

CREATE PROCEDURE EliminarProveedor(@user)--es la misma funcion que cliente!!
AS
BEGIN
	Update Logins set estado= dbo.idEstado('Deshabilitado') where username =@user
END
