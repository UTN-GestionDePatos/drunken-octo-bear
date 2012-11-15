CREATE PROCEDURE ConsumoCupon(@idcupon int,@username varchar(30),@fecha_actual datetime, @proveedor varchar(30), @ret int output)
AS
BEGIN
/*
	0: ok
	1: user y cupon no matchean
	2: proveedor y cupon no matchean
	3: el cupon no esta disponible para canjear, se canjeo o se devolvio y no se lo solicito nuevamente
*/
	IF not exists(select * from Cupones where id_cupon = @idcupon and cliente = @username)
		begin
			set @ret = 1
			return
		end
		
	IF (select g.proveedor from GruposCupon g join Cupones c on g.id_grupo = c.id_grupo and c.id_cupon=@idcupon)!= @proveedor
		begin
			set @ret = 2
			return
		end
		
	IF (select estado from Cupones where id_cupon = @idcupon) = 'Comprado'
	BEGIN
		IF (select g.fecha_vencimiento_canje from GruposCupon g join Cupones c on g.id_grupo = c.id_grupo and c.id_cupon=@idcupon) >= @fecha_actual
		begin
		update Cupones set fecha_canje= @fecha_actual, estado= 'Entregado' where id_cupon = @idcupon
		set @ret = 0
		return
		end
		
	END
	
		set @ret = 3
		return
	
END

