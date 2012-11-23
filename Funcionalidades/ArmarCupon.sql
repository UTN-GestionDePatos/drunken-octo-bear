
--falta insertar id_promocion
CREATE PROCEDURE ArmarCupon (	@localidad varchar(30),@descripcion varchar(250), @fechaSistema datetime, 
								@fechaVencimientoCanje datetime, @fechaVencimientoOferta datetime,
								@precio_ficticio float, @precio_real float, @limite_usuario int, @stock bigint,
								@proveedor varchar(30), @ret int output)
AS
BEGIN

/*
	0: ok
	1: la fecha de vencimiento de la oferta ya paso...
*/
if @fechaVencimientoOferta < @fechaSistema OR @fechaVencimientoCanje < @fechaSistema 
	begin
		set @ret = 1
		return
	end

insert into GESTION_DE_PATOS.Promociones(localidad,proveedor,precio_ficticio,stock,limite_por_usuario,precio_real,
						fecha_vencimiento_canje,estado,fecha_vencimiento_oferta,descripcion)
						 values(@localidad,@proveedor,@precio_ficticio,@stock,@limite_usuario,@precio_real,@fechaVencimientoCanje,'A publicar',@fechaVencimientoOferta,@descripcion)

set @ret = 0
return
END

GO
