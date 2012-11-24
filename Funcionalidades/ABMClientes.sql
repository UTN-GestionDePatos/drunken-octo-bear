

--CREAR CLIENTE
CREATE PROCEDURE AltaCliente(@user varchar(30),@pass varchar(30),@nombre varchar(30), @apellido varchar(30), @mail varchar(30),
@tel bigint, @fecha datetime, @dni bigint,@direccion varchar(100), @piso int, @departamento int,@ciudad int, @ret int output) 
/*
	0: ok
	1: el cliente ya existe
	2: hay clientes gemelos
	
*/
AS
BEGIN
	IF (NOT EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Clientes WHERE username = @user AND (nombre = @nombre) AND (apellido = @apellido) AND (dni=@dni) ) )
	BEGIN
	
		IF (NOT EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Clientes WHERE (nombre !=@nombre) AND (telefono=@tel) AND (dni=@dni OR mail=@mail) ))
		BEGIN
			INSERT INTO GESTION_DE_PATOS.Usuarios VALUES(@user,GESTION_DE_PATOS.SHA256(@pass),'Cliente', GESTION_DE_PATOS.idEstadoUsuario('Habilitado') ,0)
			INSERT INTO GESTION_DE_PATOS.Clientes VALUES(@user,@nombre,@apellido,@mail,@tel,@direccion,@fecha,@ciudad,@dni,10)
			--Falta poner piso, departamento, ciudad
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

--MODIFICAR CLIENTE
CREATE PROCEDURE ModificarCliente(@user varchar(30),@nombre varchar(30), @apellido varchar(30), @mail varchar(30),
@tel bigint, @fecha datetime, @dni bigint,@direccion varchar(100), @piso int, @departamento int,@ciudad int, @estado varchar(20), @ret int output) 

/*
0:salio ok
1:el cliente a modificar no existe
*/
AS
BEGIN
	IF EXISTS (SELECT 1 FROM GESTION_DE_PATOS.Usuarios WHERE username = @user)
	BEGIN
		UPDATE GESTION_DE_PATOS.Clientes SET nombre=@nombre, apellido=@apellido,mail=@mail,telefono=@tel, direccion=@direccion,fecha_nacimiento=@fecha,ciudad = @ciudad, dni=@dni 
										 WHERE username=@user  
		IF (@estado='Habilitado' OR @estado = 'Deshabilitado') 
		BEGIN
			UPDATE GESTION_DE_PATOS.Usuarios SET estado= GESTION_DE_PATOS.idEstadoUsuario(@estado) WHERE username =@user
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
CREATE PROCEDURE EliminarCliente(@user varchar(30), @ret int output)
AS
BEGIN
	IF EXISTS(SELECT * FROM GESTION_DE_PATOS.Usuarios WHERE username = @user)
	BEGIN
	
		UPDATE GESTION_DE_PATOS.Usuarios SET estado = GESTION_DE_PATOS.idEstadoUsuario('Eliminado')
										 WHERE username = @user
		
		set @ret = 0
		--Cliente eliminado								 
	END
	
	set @ret = 1
	--El cliente no existe
END