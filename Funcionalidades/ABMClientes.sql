--CREAR CLIENTE– agregar en la abm que agregue username y password-
CREATE PROCEDURE CrearCliente(@user varchar(30),@pass varchar(4000),@nombre varchar(30), @apellido varchar(30), @mail varchar(30),
@tel bigint unique, @fecha datetime, @dni bigint,@calle varchar(50),@altura int, @piso int ,@dpto char ,
@localidad varchar(30),@cp int,@ret int output) 
/*
	0: ok
	1: el cliente ya existe
	2: hay clientes gemelos
	
*/
AS
BEGIN
	if (select 1 from Clientes where (nombre = @nombre) AND (apellido = @apellido) AND (dni=@dni)is NULL
	BEGIN
	
		If (select 1 from Clientes where (nombre !=@nombre) AND (telefono=@tel ) AND(dni=@dni OR mail=@mail) )is NULL
		BEGIN
			insert into Logins values(@user,dbo.SHA256(@pass),'Cliente', dbo.idEstado('Habilitado') ,0)
			insert into Direcciones(calle,altura,piso,departamento,codigo_postal ) values(@calle,@altura,@piso,@dpto,@cp)
			insert into Clientes values (@user,@nombre,@apellido,@mail,@tel,SCOPE_IDENTITY(),@fecha,SCOPE_IDENTITY(),@dni,10)
		END
		ELSE
		BEGIN
		ret=2
		END
	
	END
	
	ELSE
	
	BEGIN
	ret = 1
	END
		
END


--MODIFICAR CLIENTE
CREATE PROCEDURE ModificarCliente(@user varchar(30),@nombre varchar(30), @apellido varchar(30),@mail varchar(30),
@tel bigint unique, @fecha datetime, @dni bigint,@calle varchar(50),@altura int, @piso int ,@dpto char ,
@localidad varchar(30),@cp int,@ret int output)
/*
0:salio ok
1:el cliente a modificar no existe
*/
AS
BEGIN
	If exists (select * from Logins where username = @user)
	BEGIN
		Update Clientes set nombre=@nombre, apellido=@apellido,mail=@mail,telefono=@tel,fecha_nacimiento=@fecha,dni=@dni, localidad= dbo.idLocalidad(@localidad) where username=@user  
		Update Direcciones set d.calle=@calle, d.altura=@altura, d.piso=@piso, d.departamento=@dpto, d.codigo_postal=@cp 
						from Direcciones d join Clientes c on d.id_direccion = c.id_direccion AND c.username = @user
		Update Localidades set localidad=@localidad --??
		IF (@estado='Habilitado') 
		BEGIN
			Update Logins set estado= dbo.idEstado('Habilitado') where username =@username
		END
		@ret=0
	END
	ELSE
	BEGIN
		@ret=1
	END
END

--ELIMINAR CLIENTE
CREATE PROCEDURE EliminarCliente(@user varchar(30))
BEGIN
	If exists (select * from Logins where username = @user)
	BEGIN
		Update Logins set estado= dbo.idEstado('Deshabilitado') where username =@user
	END
END
