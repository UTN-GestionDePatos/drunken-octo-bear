--si se registro me devuelve 1, si hubo error porque ya esta regitsrado 0
CREATE FUNCTION Registro(@user,@rol,@nombre,@apellido,@mail,@tel,@fecha,@dni)--fijarse el tema de la direcciony la localidad
RETURNS int
AS
BEGIN
	IF (Select 1 from Logins where username= @user)is NULL
		BEGIN
			If (@rol = 'Cliente')
				BEGIN
					If (Select 1 from Logins where username= @user)is NULL
					BEGIN
						insert into Logins values(@user,dbo.SHA256(@pass),'Cliente', dbo.idEstado('Habilitado') ,0)
						insert into Direcciones(calle,altura,piso,departamento,codigo_postal ) values(@calle,@altura,@piso,@dpto,@cp)
						insert into Clientes values (@user,@nombre,@apellido,@mail,@tel,SCOPE_IDENTITY(),@fecha,SCOPE_IDENTITY(),@dni,10)
						RETURN 1
					END
				END
			If (@rol = 'Proveedor')
			BEGIN
					insert into Logins values(@user,dbo.SHA256(@pass),@rol, dbo.idEstado('Habilitado') ,0)
					insert into Direcciones(calle,altura,piso,departamento,codigo_postal ) values(@calle,@altura,@piso,@dpto,@cp)
					insert into Proveedores values(@user,@cuit,@razon,@mail,@tel, SCOPE_IDENTITY(),SCOPE_IDENTITY(),@rubro,@nombre)
				RETURN 1
			END
		END
	ELSE
		BEGIN
			RETURN 0 
		END
END
