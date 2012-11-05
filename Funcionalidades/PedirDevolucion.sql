CREATE PROCEDURE PedirDevolucion(@idcupon int ,@username varchar(30),@fecha_actual datetime,@motivo varchar(250),@ret int output)
AS
BEGIN
--ver si esta comparacion de fechas esta bien
/*
	0: ok
	1: user y cupon no matchean
	2: el cupon no esta canjeado 
	3:0
*/
	if not exists (select * from Cupones where cliente = @username and id_cupon = @idcupon)
		begin
			 set @ret = 1
			 return
		end
	if not exists (select * from Cupones where id_cupon = @idcupon and estado = 'Comprado')
		begin
			set @ret = 2
			return
		end	
	
	-- TODO Si llega aca, hay que mostrar datos del cupon, una manera es hacer un select directamente en c#
		
	If (select g.fecha_vencimiento_canje from GruposCupon g join Cupones c on c.id_grupo= g.id_grupo where c.id_cupon=@idcupon)<= @fecha_actual
	begin
		insert into Devoluciones values(@idcupon,@fecha_actual,@motivo)
		set @ret = 0
		return
	end
	else
	begin
		--si llega aca es porque expiro el cupon
		set @ret = 3
		return
	end
END

GO

