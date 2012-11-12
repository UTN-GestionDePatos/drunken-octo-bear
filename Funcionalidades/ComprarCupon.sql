CREATE PROCEDURE ComprarCupon(@id_grupo varchar(30),@fecha datetime,@username varchar(30),@ret int output)
AS
BEGIN
/*
ret:
	NroCupon: ok
	1: la cantidad deseada supera el limite por usuario
	2: la cantidad deseada supera el stock disponible
	3: el usuario no tiene saldo suficiente

cupon: 	codigo del cupon a informar
	
*/
	IF (select limite_por_usuario from GruposCupon where id_grupo = @id_grupo) >= 
		(select COUNT(*) from GruposCupon gc join Cupones c on c.id_grupo = gc.id_grupo and gc.id_grupo = @id_grupo
			where c.cliente = @username and c.estado != 'Devuelto')
	BEGIN
		IF (select stock from GruposCupon where id_grupo= @id_grupo)> 0
		BEGIN
			declare @precio_real float
			select @precio_real = precio_real from GruposCupon where id_grupo=@id_grupo
			IF (select saldo from Clientes where username=@username) >= @precio_real
				BEGIN			
					insert into Cupones values(@username,@id_grupo,@fecha,'Comprado',NULL)
					set @ret = SCOPE_IDENTITY()
					return
				END	
			else
				begin
					set @ret = 3
					return
				end		
		END
		else
			begin
				set @ret = 2
				return
			end
	END
	else
	begin
		set @ret = 1
		return
	end
END
