CREATE PROCEDURE GESTION_DE_PATOS.RegistroCliente(@user varchar(30), @pass varchar(30),@nombre varchar(50),
@apellido varchar(50),@mail varchar(50), @tel bigint, @fecha datetime,
@dni bigint, @direccion varchar(100), @ciudad varchar(50), @ret int output)
AS
BEGIN

/*
	0: ok
	1: ya existe el usuario
	2: datos duplicados (telefono, dni o mail que son únicos)
*/
	IF not exists(Select 1 from GESTION_DE_PATOS.Usuarios where username= @user)
		BEGIN
			If not exists(select * from GESTION_DE_PATOS.Clientes where dni = @dni or telefono = @tel
							or dni = @dni) and not exists (select * from GESTION_DE_PATOS.Proveedores
							where telefono = @tel or mail = @mail)
				BEGIN
						insert into GESTION_DE_PATOS.Usuarios values(@user,GESTION_DE_PATOS.SHA256(@pass),'Cliente', GESTION_DE_PATOS.idEstadoUsuario('Habilitado') ,0)
						insert into GESTION_DE_PATOS.Clientes values (@user,@nombre,@apellido,@mail,@tel,@direccion,@fecha,GESTION_DE_PATOS.idCiudad(@ciudad),@dni,10)
						SET @ret = 0
						return
				END
			else
				begin
					set @ret = 2
					return
				end
		END
	ELSE
		BEGIN
			set @ret = 1 
		END
END

GO

CREATE PROCEDURE GESTION_DE_PATOS.RegistrarLocalidades(@localidad varchar(50), @user varchar(30))
AS
BEGIN
	insert into GESTION_DE_PATOS.Localidad_por_usuario values(GESTION_DE_PATOS.idCiudad(@localidad),@user)
END

GO

CREATE PROCEDURE GESTION_DE_PATOS.RegistrarProveedor(@user varchar(30), @pass varchar(30), @rs varchar(30), 
													 @cuit varchar(30),@mail varchar(30), @telefono bigint, 
													 @direccion varchar(100), @ciudad varchar(30), @rubro varchar(30),
													 @contacto varchar(30), @ret int output)
AS
BEGIN
		
/*
	0: ok
	1: ya existe el usuario
	2: datos duplicados (telefono, razoón social, mail o cuit que son únicos)
*/
	IF not exists(Select 1 from GESTION_DE_PATOS.Usuarios where username= @user)
		BEGIN
			If not exists(select * from GESTION_DE_PATOS.Proveedores where razon_social = @rs or telefono = @telefono
							or mail = @mail or cuit = @cuit) and not exists(select * from GESTION_DE_PATOS.Clientes 
							where telefono = @telefono or mail = @mail)
				BEGIN
						insert into GESTION_DE_PATOS.Usuarios values(@user,GESTION_DE_PATOS.SHA256(@pass),'Proveedor', GESTION_DE_PATOS.idEstadoUsuario('Habilitado') ,0)
						insert into GESTION_DE_PATOS.Proveedores values (@user,@cuit,@rs,@mail,@telefono,@direccion,GESTION_DE_PATOS.idCiudad(@ciudad)
																		, GESTION_DE_PATOS.idRubro(@rubro), @contacto)
						SET @ret = 0
						return
				END
			else
				begin
					set @ret = 2
					return
				end
		END
	ELSE
		BEGIN
			set @ret = 1 
		END


END