--si se registro me devuelve 1, si hubo error porque ya esta regitsrado 0
CREATE FUNCTION Registro(@user varchar(30),@rol varchar(20),@nombre varchar(30),
@apellido varchar(30),@mail varchar(30), @tel bigint unique, @fecha datetime,
@dni bigint, @calle varchar(50),@altura int,@piso int,@dpto char ,@cp int)
RETURNS int
AS
BEGIN
declare @ret int
	IF (Select 1 from Logins where username= @user)is NULL
		BEGIN
			If (@rol = 'Cliente')
				BEGIN
						insert into Logins values(@user,dbo.SHA256(@pass),'Cliente', dbo.idEstado('Habilitado') ,0)
						insert into Direcciones(calle,altura,piso,departamento,codigo_postal ) values(@calle,@altura,@piso,@dpto,@cp)
						insert into Clientes values (@user,@nombre,@apellido,@mail,@tel,SCOPE_IDENTITY(),@fecha,SCOPE_IDENTITY(),@dni,10)
						RETURN @ret=1
				END
			If (@rol = 'Proveedor')
			BEGIN
					insert into Logins values(@user,dbo.SHA256(@pass),@rol, dbo.idEstado('Habilitado') ,0)
					insert into Direcciones(calle,altura,piso,departamento,codigo_postal ) values(@calle,@altura,@piso,@dpto,@cp)
					insert into Proveedores values(@user,@cuit,@razon,@mail,@tel, SCOPE_IDENTITY(),SCOPE_IDENTITY(),@rubro,@nombre)
				RETURN @ret=1
			END
		END
	ELSE
		BEGIN
			RETURN @ret=0 
		END
END
