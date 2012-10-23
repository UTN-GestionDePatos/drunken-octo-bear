/*TABlAS*/

CREATE TABLE Administradores ( 
	username varchar(30) unique NOT NULL,
	nombre varchar(30),
	apellido varchar(30),
	mail varchar(30),
	telefono bigint unique
)
;

CREATE TABLE Cargas ( 
	id_carga bigint identity(1,1) NOT NULL,
	username varchar(30) unique,
	monto bigint,
	tipo int,
	tarjeta bigint,
	fecha datetime
)
;

CREATE TABLE Clientes ( 
	username varchar(30) unique NOT NULL,
	nombre varchar(30),
	apellido varchar(30),
	mail varchar(30),
	telefono bigint unique,
	id_dir int,
	fecha_nacimiento bigint,
	dni bigint,
	saldo float
)
;

CREATE TABLE Cupones ( 
	id_cupon bigint identity(1,1) NOT NULL,
	cliente varchar(30),
	id_grupo int,
	fecha_compra datetime,
	estado varchar(20),
	fecha_canje datetime
)
;

CREATE TABLE Devoluciones ( 
	id_cupon bigint NOT NULL,
	fecha_devolucion datetime,
	motivo varchar(250)
)
;

CREATE TABLE Direcciones ( 
	id_dir int identity(1,1) NOT NULL,
	calle varchar(30),
	piso int,
	departamento char(10),
	localidad varchar(30),
	codigo_postal int
)
;

CREATE TABLE Estados ( 
	id_estado int identity(1,1) NOT NULL,
	nombre_estado varchar(20)
)
;

CREATE TABLE Facturas ( 
	id_factura bigint unique NOT NULL,
	proveedor varchar(30),
	monto float,
	fecha_desde datetime,
	fecha_hasta datetime
)
;

CREATE TABLE Funcion_por_rol ( 
	id_funcionalidad int NOT NULL,
	nombre_rol varchar(20)
)
;

CREATE TABLE Funcionalidades ( 
	id_funcionalidad int identity(1,1) NOT NULL,
	descripcion varchar(50)
)
;

CREATE TABLE Giftcards ( 
	id_giftcard bigint identity(1,1) NOT NULL,
	cliente_origen varchar(30),
	cliente_destino varchar(30),
	fecha datetime,
	monto bigint
)
;

CREATE TABLE GruposCupon ( 
	id_grupo int unique NOT NULL,
	localidad varchar(30),
	proveedor varchar(30),
	precio_ficticio float,
	fecha_publicacion datetime,
	stock bigint,
	limite_por_usuario int,
	precio_real float,
	fecha_vencimiento_canje datetime,
	estado varchar(20),
	fecha_vencimiento_oferta datetime,
	descripcion varchar(250)
)
;

CREATE TABLE Logins ( 
	username varchar(30) NOT NULL,
	password varchar(30),
	rol varchar(20),
	estado varchar(20),
	intentos_fallidos int
)
;

CREATE TABLE Proveedores ( 
	username varchar(30) unique NOT NULL,
	cuit bigint unique,
	razon_social varchar(30),
	mail varchar(30),
	telefono bigint unique,
	id_dir int,
	ciudad varchar(30),
	rubro varchar(30),
	nombre_contacto varchar(30)
)
;

CREATE TABLE Roles ( 
	nombre varchar(20) unique NOT NULL,
	estado varchar(20)
)
;

CREATE TABLE Tarjetas ( 
	id_tarjeta bigint identity(1,1) NOT NULL,
	numero bigint,
	codigo_validacion bigint
)
;

CREATE TABLE Tipos_pago ( 
	id_pago int identity(1,1) NOT NULL,
	descripcion varchar(30)
)


GO 


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

GO

/*TRIGGERS*/

CREATE TRIGGER actualizarSaldoCargas
ON Cargas
AFTER INSERT
AS
	begin
		declare @unaCarga float
		select @unaCarga = monto from inserted
		update Clientes
		set saldo = saldo + @unaCarga
	
	end

GO

CREATE TRIGGER actualizarSaldoCupones
ON Cupones
AFTER INSERT
AS
	BEGIN
		declare @precio float, @user varchar(30)
		select @user = cliente from inserted
		select @precio = precio_ficticio from GruposCupon gc join inserted on gc.id_grupo = inserted.id_grupo
		update Clientes set saldo = saldo - @precio where username = @user
		
	END

GO

CREATE TRIGGER actualizarSaldoDevoluciones
ON Devoluciones
AFTER INSERT
AS
	BEGIN
		declare @precio float, @user varchar(30)
		
		select @precio = precio_ficticio, @user = c.cliente from GruposCupon gc	
			join Cupones c on gc.id_grupo = c.id_grupo
			join inserted on c.id_cupon = inserted.codigo_cupon
		
		update Clientes set saldo = saldo + @precio where username = @user
		
	END
	
GO

CREATE TRIGGER actualizarEstadoDevoluciones
ON Devoluciones
AFTER INSERT
AS
	BEGIN
		declare @cupon int
		select @cupon = codigo_cupon from inserted
		update Cupones set estado = 'Devuelto' where id_cupon = @cupon
	END

GO

CREATE TRIGGER actualizarSaldoGiftcards
ON Giftcards
AFTER INSERT
AS
	BEGIN
		declare @saldo float, @userOrigen varchar(30), @userDestino varchar(30)
		select @userOrigen = cliente_origen, @saldo = monto, @userDestino = cliente_destino from inserted
		update Clientes set saldo = saldo - @saldo where username = @userOrigen
		update Clientes set saldo = saldo + @saldo where username = @userDestino
		
	END