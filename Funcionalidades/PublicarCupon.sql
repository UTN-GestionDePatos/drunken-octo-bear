
CREATE PROCEDURE GESTION_DE_PATOS.PublicarCupon(@codigoPromocion varchar(30), @fecha datetime)
AS
BEGIN
update GESTION_DE_PATOS.Promociones set estado = 'Publicado', fecha_publicacion = @fecha where id_promocion = @codigoPromocion
END