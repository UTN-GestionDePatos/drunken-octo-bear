CREATE TABLE Administradores ( 
	username varchar(30) NOT NULL,
	nombre varchar(30),
	apellido varchar(30),
	mail varchar(30),
	telefono bigint
)
;

CREATE TABLE Cargas ( 
	id_carga bigint NOT NULL,
	username varchar(30),
	monto bigint,
	tipo int,
	tarjeta bigint,
	fecha datetime
)
;

CREATE TABLE Clientes ( 
	username varchar(30) NOT NULL,
	nombre varchar(30),
	apellido varchar(30),
	mail varchar(30),
	telefono bigint,
	id_dir int,
	fecha_nacimiento bigint,
	dni bigint,
	saldo float
)
;

CREATE TABLE Cupones ( 
	id_cupon bigint NOT NULL,
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
	id_dir int NOT NULL,
	calle varchar(30),
	piso int,
	departamento char(10),
	localidad varchar(30),
	codigo_postal int
)
;

CREATE TABLE Estados ( 
	id_estado int NOT NULL,
	nombre_estado varchar(20)
)
;

CREATE TABLE Facturas ( 
	id_factura bigint NOT NULL,
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
	id_funcionalidad int NOT NULL,
	descripcion varchar(50)
)
;

CREATE TABLE Giftcards ( 
	id_giftcard bigint NOT NULL,
	cliente_origen varchar(30),
	cliente_destino varchar(30),
	fecha datetime
)
;

CREATE TABLE GruposCupon ( 
	id_grupo int NOT NULL,
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
	username varchar(30) NOT NULL,
	cuit bigint,
	razon_social varchar(30),
	mail varchar(30),
	telefono bigint,
	id_dir int,
	ciudad varchar(30),
	rubro varchar(30),
	nombre_contacto varchar(30)
)
;

CREATE TABLE Roles ( 
	nombre varchar(20) NOT NULL,
	estado varchar(20)
)
;

CREATE TABLE Tarjetas ( 
	id_tarjeta bigint NOT NULL,
	numero bigint,
	codigo_validacion bigint
)
;

CREATE TABLE Tipos_pago ( 
	id_pago int NOT NULL,
	descripcion varchar(30)
)
;
