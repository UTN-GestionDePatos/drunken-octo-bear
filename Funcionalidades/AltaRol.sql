CREATE PROCEDURE AltaRol (@nombre varchar(50),@ret int output)
AS
BEGIN
	if exists(select * from Roles where nombre = @nombre)
	begin
		set @ret = 1
		return
	end
	
	set @ret = 0
	insert into Roles values (@nombre,1)
END

GO

CREATE PROCEDURE AsignarFuncionalidadAlRol (@id int, @rol varchar(50), @ret int output)
AS
BEGIN
	insert into Funcion_por_rol values(@id,@rol)
	set @ret = 0
END

