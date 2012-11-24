CREATE PROCEDURE GESTION_DE_PATOS.ConsumoCupon(@idcupon int,@username varchar(30),@fecha_actual datetime, @proveedor varchar(30), @ret int output)
AS
BEGIN
/*
	0: ok
	1: user y cupon no matchean
	2: proveedor y cupon no matchean
	3: se vencio el canje
	5: el cupon esta devuelto o ya canjeado
*/
	IF not exists(select * from GESTION_DE_PATOS.Cupones where id_cupon = @idcupon and cliente = @username)
		begin
			set @ret = 1
			return
		end
		
	IF (select g.proveedor from GESTION_DE_PATOS.Promociones g join GESTION_DE_PATOS.Cupones c on g.id_promocion = c.id_promocion and c.id_cupon=@idcupon)!= @proveedor
		begin
			set @ret = 2
			return
		end
	

	IF exists(select * from GESTION_DE_PATOS.Devoluciones where id_cupon = @idcupon) or exists(
		select * from GESTION_DE_PATOS.Canjes where id_cupon = @idcupon)
	BEGIN
		set @ret = 5
		return
	END
	
	IF (select g.fecha_vencimiento_canje from GESTION_DE_PATOS.Promociones g join GESTION_DE_PATOS.Cupones c on g.id_promocion = c.id_promocion and c.id_cupon=@idcupon) >= @fecha_actual
	begin
		insert into GESTION_DE_PATOS.Canjes values (@idcupon,@fecha_actual)
		set @ret = 0
		return
	end
		
	set @ret = 3
	return
	
END

