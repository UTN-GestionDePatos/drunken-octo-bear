
CREATE PROCEDURE PublicarCupon(@codigoGrupo varchar(30))
AS
BEGIN
update GruposCupon set estado = 'Publicado' where id_grupo = @codigoGrupo
END