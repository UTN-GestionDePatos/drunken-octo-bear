CREATE PROCEDURE CargarCredito(@username varchar(30),@fecha datetime,@tipoPago varchar(30),@monto bigint,@numeroTarjeta bigint, @ret int output)
AS
BEGIN

/*
	0: ok
	1: monto < $15
	2: tarjeta incorrecta
*/
	IF (@monto>15)
	BEGIN --ver si me tengo que fijar que exista la tarjeta o agregarla
		declare @tipo int
		select @tipo = id_pago from Tipos_pago where descripcion = @tipoPago
		
		if @tipo in (2,3)
		begin
			--validacion tarjeta
			if not exists (select * from Tarjetas where username = @username)
				begin
					insert into Tarjetas (numero,username) values (@numeroTarjeta, @username)
				end
			else
				begin
					if (select numero from Tarjetas where username = @username) != @numeroTarjeta
					begin
						set @ret = 2
						return
					end
				end
			insert into Cargas values(@username,@monto,@tipo,@numeroTarjeta,@fecha)
		end
		else --efectivo
		begin
			insert into Cargas values(@username,@monto,@tipo,null,@fecha)
		end
		
		set @ret = 0
		return;
	END
	else
		begin
			set @ret = 1
			return
		end
END


