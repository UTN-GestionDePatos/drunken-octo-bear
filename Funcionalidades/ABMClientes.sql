--CREAR CLIENTE– agregar en la abm que agregue username y password-
CREATE PROCEDURE CrearCliente(@user,@pass,@nombre,@mail,@tel,@fecha,@dni,@calle,@altura,@piso,@dpto,@localidad,@cp) 
AS
BEGIN
	If (select 1 from Clientes where (nombre !=@nombre) AND (telefono=@tel ) AND(dni=@dni OR mail=@mail) )is NULL
		BEGIN
			insert into Logins values(@user,dbo.SHA256(@pass),'Cliente', dbo.idEstado('Habilitado') ,0)
			insert into Direcciones(calle,altura,piso,departamento,codigo_postal ) values(@calle,@altura,@piso,@dpto,@cp)
			insert into Clientes values (@user,@nombre,@apellido,@mail,@tel,SCOPE_IDENTITY(),@fecha,SCOPE_IDENTITY(),@dni,10)
		END
END

--MODIFICAR CLIENTE
CREATE PROCEDURE ModificarCliente(@user,@nombre,@apellido,@mail,@tel,@fecha,@dni,@calle,@altura,@piso,@dpto,@localidad,@cp)
AS
BEGIN
	Update Clientes set nombre=@nombre, apellido=@apellido,mail=@mail,telefono=@tel,fecha_nacimiento=@fecha,dni=@dni, localidad= dbo.idLocalidad(@localidad) where username=@user  
	Update Direcciones set d.calle=@calle, d.altura=@altura, d.piso=@piso, d.departamento=@dpto, d.codigo_postal=@cp 
						from Direcciones d join Clientes c on d.id_direccion = c.id_direccion AND c.username = @user
	Update Localidades set localidad=@localidad --??
	IF (@estado='Habilitado') 
	BEGIN
	Update Logins set estado= dbo.idEstado('Habilitado') where username =@username
	END
END

--ELIMINAR CLIENTE
CREATE PROCEDURE EliminarCliente( @user)
BEGIN
	Update Logins set estado= dbo.idEstado('Deshabilitado') where username =@user
END
