--CREAR PROVEEDOR
CREATE PROCEDURE GESTION_DE_PATOS.AltaProveedor(@user varchar(30),@pass varchar(30),@cuit bigint,@razon_social varchar(30),@mail varchar(30),
@telefono bigint,@direccion varchar(100), @rubro varchar(30), @nombre_contacto varchar(30),@ciudad varchar(30), @ret int output) 
AS
BEGIN

	If not exists(select * from GESTION_DE_PATOS.Proveedores where razon_social = @razon_social or telefono = @telefono
							or mail = @mail or cuit = @cuit) and not exists(select * from GESTION_DE_PATOS.Clientes 
							where telefono = @telefono or mail = @mail)
	BEGIN
		INSERT INTO GESTION_DE_PATOS.Usuarios VALUES(@user,GESTION_DE_PATOS.SHA256(@pass),'Proveedor', GESTION_DE_PATOS.idEstadoUsuario('Habilitado') ,0)
		INSERT INTO GESTION_DE_PATOS.Proveedores VALUES(@user,@cuit,@razon_social,@mail,@telefono, @direccion,GESTION_DE_PATOS.idCiudad(@ciudad),GESTION_DE_PATOS.idRubro(@rubro),@nombre_contacto)
		
		set @ret = 0
	END
	
	set @ret = 1
END

go

--MODFICAR PROVEEDOR
CREATE PROCEDURE GESTION_DE_PATOS.ModificarProveedor(@user varchar(30),@pass varchar(30),@cuit bigint,@razon_social varchar(30),@mail varchar(30),
@telefono bigint,@direccion varchar(100),@rubro VARCHAR(30), @nombre_contacto varchar(30), @ciudad VARCHAR(30), @estado varchar(20), @ret int output) 
AS
BEGIN

	IF EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Proveedores WHERE username = @user)
	BEGIN
		UPDATE GESTION_DE_PATOS.Proveedores SET cuit=@cuit,razon_social=@razon_social,mail=@mail,telefono=@telefono,direccion = @direccion,
		ciudad = GESTION_DE_PATOS.idCiudad(@ciudad), id_rubro = GESTION_DE_PATOS.idRubro(@rubro), nombre_contacto=@nombre_contacto
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
	
	set @ret = 1
	--El proveedor no existe
END
