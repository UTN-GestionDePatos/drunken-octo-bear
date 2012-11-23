CREATE PROCEDURE GESTION_DE_PATOS.ComprarCupon(@id_promocion varchar(30),@fecha datetime,@username varchar(30),@ret int output)
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
	IF (select limite_por_usuario from GESTION_DE_PATOS.Promociones where id_promocion = @id_promocion) > 
		(select COUNT(*) from GESTION_DE_PATOS.Promociones gc join GESTION_DE_PATOS.Cupones c on c.id_promocion = gc.id_promocion and gc.id_promocion = @id_promocion
			where c.cliente = @username) - (select COUNT(*) from GESTION_DE_PATOS.Promociones p 
											join GESTION_DE_PATOS.Cupones c on c.id_promocion = p.id_promocion
											and p.id_promocion = @id_promocion
											join GESTION_DE_PATOS.Devoluciones d on d.id_cupon = c.id_cupon)
	BEGIN
		IF (select stock from GESTION_DE_PATOS.Promociones where id_promocion= @id_promocion)> 0
		BEGIN
			declare @precio_real float
			select @precio_real = precio_real from GESTION_DE_PATOS.Promociones where id_promocion=@id_promocion
			IF (select saldo from GESTION_DE_PATOS.Clientes where username=@username) >= @precio_real
				BEGIN			
					insert into GESTION_DE_PATOS.Cupones values(@username,@id_promocion,@fecha)
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
