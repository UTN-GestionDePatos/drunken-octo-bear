CREATE PROCEDURE AltaRol(@nombre varchar(30))
AS
BEGIN


insert into Roles (@nombre,1)
/*
Funcionalidad para poder crear, modificar y eliminar el acceso de un usuario a una
opción del sistema.
Crear un rol implica cargar los siguientes datos:
· Nombre
· Listado de Funcionalidades (selección acotada)
Todos los datos mencionados anteriormente son obligatorios.
Un rol posee un conjunto de funcionalidades y las mismas no pueden estar
repetidas dentro de un rol en particular.
Debe tenerse en cuenta, que actualmente existen 3 roles, Proveedor,
Administrativo, Cliente.
En la modificación de un rol solo se pueden alterar ambos campos: el nombre y el
listado de funcionalidades. Se deben poder quitar de a una las funcionalidades como así
también agregar nuevas funcionalidades a rol que se está modificando.
La eliminación del rol implica una baja lógica del mismo. El rol debe poder
inhabilitarse. No permitido la asignación de un rol inhabilitado a un usuario, por ende,
se le debe quitar el rol inhabilitado a todos aquellos usuarios que lo posean.
Se debe poder volver a habilitar un rol inhabilitado desde la sección de
modificación. Esto no implica recuperar las asignaciones que existían en un pasado.
Para elegir el rol que se desea modificar o eliminar se debe mostrar un listado con
todos los roles existentes en el sistema.
*/
END

