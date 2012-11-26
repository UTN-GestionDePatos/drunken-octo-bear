
--CREAR CLIENTE
CREATE PROCEDURE GESTION_DE_PATOS.AltaCliente(@user varchar(30),@pass varchar(50),@nombre varchar(30), @apellido varchar(30), @mail varchar(30),
@tel bigint, @fecha datetime, @dni bigint,@direccion varchar(100), @ciudad varchar(30), @codigo_postal int, @ret int output) 
/*
	0: ok
	1: el cliente ya existe
	2: hay clientes gemelos
	
*/
AS
BEGIN
	IF (NOT EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Clientes WHERE username = @user AND nombre = @nombre AND apellido = @apellido AND dni=@dni ) )
	BEGIN
	
		IF NOT EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Clientes WHERE dni = @dni or telefono = @tel)
				 AND NOT EXISTS (SELECT 1 FROM GESTION_DE_PATOS.Proveedores WHERE telefono = @tel or mail = @mail)
		BEGIN
			INSERT INTO GESTION_DE_PATOS.Usuarios VALUES(@user,GESTION_DE_PATOS.SHA256(@pass),'Cliente', GESTION_DE_PATOS.idEstadoUsuario('Habilitado') ,0)
			INSERT INTO GESTION_DE_PATOS.Clientes VALUES(@user,@nombre,@apellido,@dni,@fecha,@mail,@tel,@direccion,@codigo_postal,GESTION_DE_PATOS.idCiudad(@ciudad),10)
		
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

--MODIFICAR CLIENTE
CREATE PROCEDURE GESTION_DE_PATOS.ModificarCliente(@user varchar(30),@nombre varchar(30), @apellido varchar(30), @mail varchar(30),
@tel bigint, @fecha datetime, @dni bigint,@direccion varchar(100), @codigo_postal int, @ciudad varchar(30), @estado varchar(20), @ret int output) 

/*
0:salio ok
1:el cliente a modificar no existe
2:existe un cliente gemelo
*/
AS
BEGIN
	IF EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Usuarios WHERE username = @user)
	BEGIN
		IF (NOT EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Clientes WHERE (dni = @dni OR telefono = @tel) AND @user <> username)
				 AND NOT EXISTS (SELECT 1 FROM GESTION_DE_PATOS.Proveedores WHERE (telefono = @tel OR mail = @mail) AND @user <> username) )
		BEGIN		 
			UPDATE GESTION_DE_PATOS.Clientes SET nombre = @nombre, 
												 apellido = @apellido,
												 dni = @dni,
												 fecha_nacimiento = @fecha,
												 mail = @mail,
												 telefono = @tel,
												 direccion = @direccion,
												 codigo_postal = @codigo_postal,											 
												 ciudad = GESTION_DE_PATOS.idCiudad(@ciudad)
											 WHERE username = @user
											 
			IF (@estado='Habilitado' OR @estado = 'Deshabilitado') 
			BEGIN
				UPDATE GESTION_DE_PATOS.Usuarios SET estado = GESTION_DE_PATOS.idEstadoUsuario(@estado) WHERE username = @user
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

GO

--ELIMINAR CLIENTE
CREATE PROCEDURE GESTION_DE_PATOS.EliminarCliente(@user varchar(30), @ret int output)
AS
BEGIN
	IF EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Usuarios WHERE username = @user)
	BEGIN
	
		UPDATE GESTION_DE_PATOS.Usuarios SET estado = GESTION_DE_PATOS.idEstadoUsuario('Eliminado')
										 WHERE username = @user
		
		set @ret = 0
		--Cliente eliminado								 
	END
	ELSE
	BEGIN
		set @ret = 1
	END
	--El cliente no existe
END

GO