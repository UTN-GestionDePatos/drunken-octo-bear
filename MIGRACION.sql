CREATE PROCEDURE MigracionManopla
AS
BEGIN

/*PARTE DE LA MIGRACION A MANOPLA*/

--Tipo de pago

insert into Tipos_pago (descripcion) values ('Efectivo')
insert into Tipos_pago (descripcion) values ('Tarjeta de Credito')
insert into Tipos_pago (descripcion) values ('Tarjeta de Debito')

--Administrador

insert into Administradores values ('ElAdmin','Saturnino','Velmonte','saturnino.velmonte@gmail.com',45678676)

--Funcionalidades

insert into Funcionalidades (descripcion) values('ABM Rol')
insert into Funcionalidades (descripcion) values('Registro Usuario')
insert into Funcionalidades (descripcion) values('ABM Clientes')
insert into Funcionalidades (descripcion) values('ABM Proveedores')
insert into Funcionalidades (descripcion) values('Carga de credito')
insert into Funcionalidades (descripcion) values('Comprar Giftcard')
insert into Funcionalidades (descripcion) values('Comprar Cupon')
insert into Funcionalidades (descripcion) values('Pedir Devolucion')
insert into Funcionalidades (descripcion) values('Historial de Compra de Cupones')
insert into Funcionalidades (descripcion) values('Armar Cupon')
insert into Funcionalidades (descripcion) values('Registro de consumo de cupon')
insert into Funcionalidades (descripcion) values('Publicar Cupon')
insert into Funcionalidades (descripcion) values('Facturacion a Proveedor')
insert into Funcionalidades (descripcion) values('Listado estadistico')

--Roles

insert into Roles values ('Administrador','Habilitado')
insert into Roles values ('Cliente','Habilitado')
insert into Roles values ('Proveedor','Habilitado')

--Funcion por rol
insert into Funcion_por_rol values (1,'Administrador')
insert into Funcion_por_rol values (2,'Administrador')
insert into Funcion_por_rol values (2,'Cliente')
insert into Funcion_por_rol values (2,'Proveedor')
insert into Funcion_por_rol values (3,'Administrador')
insert into Funcion_por_rol values (4,'Administrador')
insert into Funcion_por_rol values (5,'Administrador')
insert into Funcion_por_rol values (6,'Cliente')
insert into Funcion_por_rol values (7,'Cliente')
insert into Funcion_por_rol values (8,'Cliente')
insert into Funcion_por_rol values (9,'Cliente')
insert into Funcion_por_rol values (10,'Proveedor')
insert into Funcion_por_rol values (11,'Proveedor')
insert into Funcion_por_rol values (12,'Administrador')
insert into Funcion_por_rol values (13,'Administrador')
insert into Funcion_por_rol values (14,'Administrador')


END