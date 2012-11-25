CREATE PROCEDURE GESTION_DE_PATOS.FacturarProveedor (@proveedor varchar(30), @fecha_desde datetime, @fecha_hasta datetime, @monto float,@ret int output)
AS
BEGIN
/*
	idfactura: ok
	1: se overlapean los intervalos --> cupones ya facturados
*/
	if exists (select * from GESTION_DE_PATOS.Facturas where proveedor = @proveedor and (fecha_desde between @fecha_desde and @fecha_hasta or fecha_hasta between @fecha_desde and @fecha_hasta))
		begin
			set @ret = 1
			return
		end
	
	select @ret = MAX(id_factura)+1 from GESTION_DE_PATOS.Facturas
	insert into GESTION_DE_PATOS.Facturas values(@ret, @proveedor, @monto, @fecha_desde, @fecha_hasta)
	
	return
	
	
END	