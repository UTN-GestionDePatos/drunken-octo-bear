CREATE PROCEDURE AltaRol(@nombre varchar(30))
AS
BEGIN


insert into Roles (@nombre,1)
/*
Funcionalidad para poder crear, modificar y eliminar el acceso de un usuario a una
opci�n del sistema.
Crear un rol implica cargar los siguientes datos:
� Nombre
� Listado de Funcionalidades (selecci�n acotada)
Todos los datos mencionados anteriormente son obligatorios.
Un rol posee un conjunto de funcionalidades y las mismas no pueden estar
repetidas dentro de un rol en particular.
Debe tenerse en cuenta, que actualmente existen 3 roles, Proveedor,
Administrativo, Cliente.
En la modificaci�n de un rol solo se pueden alterar ambos campos: el nombre y el
listado de funcionalidades. Se deben poder quitar de a una las funcionalidades como as�
tambi�n agregar nuevas funcionalidades a rol que se est� modificando.
La eliminaci�n del rol implica una baja l�gica del mismo. El rol debe poder
inhabilitarse. No permitido la asignaci�n de un rol inhabilitado a un usuario, por ende,
se le debe quitar el rol inhabilitado a todos aquellos usuarios que lo posean.
Se debe poder volver a habilitar un rol inhabilitado desde la secci�n de
modificaci�n. Esto no implica recuperar las asignaciones que exist�an en un pasado.
Para elegir el rol que se desea modificar o eliminar se debe mostrar un listado con
todos los roles existentes en el sistema.
*/
END

