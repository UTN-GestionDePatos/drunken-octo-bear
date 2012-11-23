

--CREAR CLIENTE– agregar en la abm que agregue username y password-
CREATE PROCEDURE CrearCliente(@user varchar(30),@pass varchar(30),@nombre varchar(30), @apellido varchar(30), @mail varchar(30),
@tel bigint, @fecha datetime, @dni bigint,@direccion varchar(100),@ret int output) 
/*
	0: ok
	1: el cliente ya existe
	2: hay clientes gemelos
	
*/
AS
BEGIN
	if (select 1 from GESTION_DE_PATOS.Clientes where (nombre = @nombre) AND (apellido = @apellido) AND (dni=@dni))is NULL
	BEGIN
	
		If (select 1 from GESTION_DE_PATOS.Clientes where (nombre !=@nombre) AND (telefono=@tel ) AND(dni=@dni OR mail=@mail) )is NULL
		BEGIN
			insert into GESTION_DE_PATOS.Usuarios values(@user,GESTION_DE_PATOS.SHA256(@pass),'Cliente', GESTION_DE_PATOS.idEstado('Habilitado') ,0)
			insert into GESTION_DE_PATOS.Clientes values (@user,@nombre,@apellido,@mail,@tel,@direccion,@fecha,@dni,10)
		END
		ELSE
		BEGIN
		set @ret=2
		END
	
	END
	
	ELSE
	
	BEGIN
	set @ret = 1
	END
		
END

go

--MODIFICAR CLIENTE
CREATE PROCEDURE ModificarCliente(@user varchar(30),@nombre varchar(30), @apellido varchar(30),@mail varchar(30),
@tel bigint , @fecha datetime, @dni bigint,@direccion varchar(100),@ret int output, @estado varchar(20))
/*
0:salio ok
1:el cliente a modificar no existe
*/
AS
BEGIN
	If exists (select * from GESTION_DE_PATOS.Usuarios where username = @user)
	BEGIN
		Update GESTION_DE_PATOS.Clientes set nombre=@nombre, apellido=@apellido,mail=@mail,telefono=@tel,direccion =@direccion,fecha_nacimiento=@fecha,dni=@dni where username=@user  
		IF (@estado='Habilitado') 
		BEGIN
			Update GESTION_DE_PATOS.Usuarios set estado= GESTION_DE_PATOS.idEstado('Habilitado') where username =@user
		END
		set @ret=0
	END
	ELSE
	BEGIN
		 set @ret=1
	END
END

go

--ELIMINAR CLIENTE
CREATE PROCEDURE EliminarCliente(@user varchar(30))
AS
BEGIN
	If exists (select * from GESTION_DE_PATOS.Usuarios where username = @user)
	BEGIN
		Update GESTION_DE_PATOS.Usuarios set estado= GESTION_DE_PATOS.idEstado('Deshabilitado') where username =@user
	END
END
