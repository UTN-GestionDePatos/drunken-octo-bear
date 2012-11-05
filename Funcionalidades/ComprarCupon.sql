CREATE PROCEDURE ComprarCupon(@id_grupo varchar(30),@fecha datetime,@cantidad_deseada int,@username varchar(30),@ret int output, @cupon bigint output)
AS
BEGIN
/*
ret:
	0: ok
	1: la cantidad deseada supera el limite por usuario
	2: la cantidad deseada supera el stock disponible
	3: el usuario no tiene saldo suficiente

cupon: 	codigo del cupon a informar
	
*/
	IF (select limite_por_usuario from GruposCupon where id_grupo = @id_grupo) >= @cantidad_deseada
	BEGIN
		IF (select stock from GruposCupon where id_grupo= @id_grupo)>=@cantidad_deseada
		BEGIN
			declare @precio_real float
			select @precio_real = precio_real from GruposCupon where id_grupo=@id_grupo
			IF (select saldo from Clientes where username=@username) >= ( @precio_real * @cantidad_deseada)
				BEGIN			
					insert into Cupones values(@username,@id_grupo,@fecha,'Comprado',NULL)
					set @cupon = SCOPE_IDENTITY()
					set @ret = 0
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
