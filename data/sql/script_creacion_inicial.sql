/*
	Tablas
*/

CREATE TABLE Administradores ( 
	username varchar(30) primary key,
	nombre varchar(30),
	apellido varchar(30),
	mail varchar(30),
	telefono bigint unique
)

CREATE TABLE Direcciones ( 
	id_dir int identity(1,1) primary key,
	calle varchar(50),
	altura int,
	piso int,
	departamento char,
	codigo_postal int
)


CREATE TABLE Localidades(
	id_localidad int identity(1,1) primary key,
	localidad varchar(30)
)


CREATE TABLE Localidad_por_usuario(
	id_localidad int not null references Localidades(id_localidad),
	username varchar(30)
)

CREATE TABLE Clientes ( 
	username varchar(30) primary key,
	nombre varchar(30),
	apellido varchar(30),
	mail varchar(30),
	telefono bigint unique,
	id_dir int references Direcciones(id_dir),
	fecha_nacimiento datetime,
	ciudad int references Localidades(id_localidad),
	dni bigint,
	saldo float
)

CREATE TABLE Proveedores ( 
	username varchar(30) primary key,
	cuit nvarchar(20) unique,
	razon_social varchar(30),
	mail varchar(30),
	telefono bigint unique,
	id_dir int references Direcciones(id_dir),
	ciudad int references Localidades(id_localidad),
	rubro varchar(30),
	nombre_contacto varchar(30)
)

CREATE TABLE Tipos_pago ( 
	id_pago int identity(1,1) primary key,
	descripcion varchar(30)
)

CREATE TABLE Tarjetas ( 
	id_tarjeta bigint identity(1,1) primary key,
	numero bigint,
	codigo_validacion bigint,
	username varchar(30) references Clientes(username)
)

CREATE TABLE Cargas ( 
	id_carga bigint identity(1,1) primary key,
	username varchar(30) references Clientes(username),
	monto bigint,
	tipo int references Tipos_Pago (id_pago),
	tarjeta bigint references Tarjetas(id_tarjeta),
	fecha datetime
)

CREATE TABLE GruposCupon ( 
	id_grupo varchar(30) primary key,
	localidad int references Localidades(id_localidad),
	proveedor varchar(30) references Proveedores(username),
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

CREATE TABLE Cupones ( 
	id_cupon bigint identity(1,1) primary key,
	cliente varchar(30),
	id_grupo varchar(30) references GruposCupon(id_grupo),
	fecha_compra datetime,
	estado varchar(20),
	fecha_canje datetime
)

CREATE TABLE Devoluciones ( 
	id_cupon bigint primary key references Cupones(id_cupon),
	fecha_devolucion datetime,
	motivo varchar(250)
)

CREATE TABLE EstadosUsuarios ( 
	id_estado int identity(1,1) primary key,
	nombre_estado varchar(20)
)

CREATE TABLE Facturas ( 
	id_factura bigint primary key,
	proveedor varchar(30),
	monto float,
	fecha_desde datetime,
	fecha_hasta datetime
)

CREATE TABLE Funcionalidades ( 
	id_funcionalidad int identity(1,1) primary key,
	descripcion varchar(50)
)

CREATE TABLE Funcion_por_rol ( 
	id_funcionalidad int NOT NULL references Funcionalidades(id_funcionalidad),
	nombre_rol varchar(20)
)

CREATE TABLE Giftcards ( 
	id_giftcard bigint identity(1,1) primary key,
	cliente_origen varchar(30) references Clientes(username),
	cliente_destino varchar(30) references Clientes(username),
	fecha datetime,
	monto bigint
)

CREATE TABLE Logins ( 
	username varchar(30) primary key,
	passwd varchar(4000),
	rol varchar(20),
	estado int references EstadosUsuarios(id_estado),
	intentos_fallidos int
)

CREATE TABLE Roles ( 
	nombre varchar(20) primary key,
	estado int references EstadosUsuarios(id_estado)
)

GO 


CREATE PROCEDURE MigracionManopla
AS
BEGIN

/*PARTE DE LA MIGRACION A MANOPLA*/
--Estados

insert into EstadosUsuarios(nombre_estado) values('Habilitado')
insert into EstadosUsuarios(nombre_estado) values('Deshabilitado')

--Tipo de pago

insert into Tipos_pago (descripcion) values ('Efectivo')
insert into Tipos_pago (descripcion) values ('Crédito')
insert into Tipos_pago (descripcion) values ('Débito')

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

insert into Roles values ('Administrador',dbo.idEstadoUsuario('Habilitado'))
insert into Roles values ('Cliente',dbo.idEstadoUsuario('Habilitado'))
insert into Roles values ('Proveedor',dbo.idEstadoUsuario('Habilitado'))

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
		
		declare @temp table (id varchar(30), monto float)
		insert into @temp select inserted.username,sum(inserted.monto) from inserted group by inserted.username
		
		update Clientes 
		set saldo = saldo + t.monto
		from Clientes c join @temp t on c.username = t.id
		
	end

GO

CREATE TRIGGER actualizarSaldoCupones
ON Cupones
AFTER INSERT
AS
	BEGIN
		declare @temp table (cliente varchar(30), monto float)
		insert into @temp
		select inserted.cliente, sum(gc.precio_real)
		from GruposCupon gc JOIN inserted ON gc.id_grupo = inserted.id_grupo
		group by inserted.cliente
		
		UPDATE Clientes SET saldo = saldo - t.monto
		FROM Clientes c join @temp t on c.username = t.cliente 
	
	END

GO

CREATE TRIGGER actualizarSaldoCuponesPorDevolucion
ON Cupones
AFTER UPDATE
AS
	BEGIN

		UPDATE Clientes SET saldo = saldo + gc.precio_real
		FROM GruposCupon gc JOIN inserted ON gc.id_grupo = inserted.id_grupo
		WHERE username = inserted.cliente AND inserted.estado = 'Devuelto'
			
	END

GO


CREATE TRIGGER actualizarEstadoDevoluciones
ON Devoluciones
AFTER INSERT
AS
	BEGIN
		declare @cupon int
		select @cupon = id_cupon from inserted
		update Cupones set estado = 'Devuelto' where id_cupon = @cupon
	END

GO

CREATE TRIGGER actualizarSaldoDevoluciones
ON Devoluciones
AFTER INSERT
AS
	BEGIN
		declare @temp table (cliente varchar(30), monto float)
		insert into @temp
		select c.cliente, sum(gc.precio_real)
		from GruposCupon gc join Cupones c on gc.id_grupo = c.id_grupo
							join inserted on inserted.id_cupon = c.id_cupon
		group by c.cliente
		
		UPDATE Clientes SET saldo = saldo + t.monto
		FROM Clientes cli join @temp t on cli.username = t.cliente 
	
	END
GO

CREATE TRIGGER actualizarSaldoGiftcards
ON Giftcards
AFTER INSERT
AS
	BEGIN
	
	begin
		
		declare @temp table (id varchar(30), monto float)
		insert into @temp select inserted.cliente_origen,sum(inserted.monto) from inserted group by inserted.cliente_origen
		
		update Clientes set saldo = saldo - t.monto
		from Clientes c join @temp t on c.username = t.id
	
		delete from @temp
		
		insert into @temp select inserted.cliente_destino,sum(inserted.monto) from inserted group by inserted.cliente_destino
		
		update Clientes set saldo = saldo + t.monto
		from Clientes c join @temp t on c.username = t.id
	
			
	end
		
	END
GO

CREATE TRIGGER actualizarStockCupones
ON Cupones
AFTER INSERT
AS
BEGIN
	UPDATE GruposCupon
	SET stock = stock - (select count(*) from inserted)
	FROM inserted i join GruposCupon gc on i.id_grupo = gc.id_grupo
	
END

GO

CREATE TRIGGER actualizarStockDevoluciones
ON Devoluciones
AFTER INSERT
AS
BEGIN
	UPDATE GruposCupon
	SET stock = stock + (select count(*) from inserted)
	FROM inserted i join Cupones c on i.id_cupon = c.id_cupon join GruposCupon gc on c.id_grupo = gc.id_grupo
END

GO

CREATE VIEW LoginView
AS
SELECT username,passwd,rol,estado,intentos_fallidos FROM Logins


GO

--FUNCIONES Y PROCEDIMIKENTOS

CREATE FUNCTION idCiudad(@ciudad varchar(30))
RETURNS int
AS
BEGIN
	DECLARE @id int
	SELECT @id = id_localidad
	FROM Localidades
	WHERE localidad = @ciudad
	RETURN @id
END

GO

CREATE FUNCTION idEstadoUsuario(@estado varchar(30))
RETURNS int
AS
BEGIN
	DECLARE @id int
	SELECT @id = id_estado
	FROM EstadosUsuarios
	WHERE nombre_estado = @estado
	RETURN @id
END

GO

CREATE PROCEDURE AsignarDireccion
AS
BEGIN
	declare @dir varchar(100), @cliente varchar(30)
	declare direcciones cursor for select distinct Cli_Direccion,convert(varchar(30),Cli_dni) from gd_esquema.Maestra
	open direcciones
	fetch direcciones into @dir, @cliente
	while @@FETCH_STATUS = 0
	begin
		insert into Direcciones (calle,altura)
		select reverse(substring(reverse(@dir),charindex(' ',(reverse(@dir)),0),LEN(@dir))),reverse(substring(reverse(@dir),0,charindex(' ',(reverse(@dir)))))
		update Clientes set id_dir = SCOPE_IDENTITY() where username = @cliente
		fetch direcciones into @dir, @cliente
	end
END

GO

CREATE PROCEDURE MigrarDatosSinCursor
AS
BEGIN

	/*MIGRACIONES MASIVAS*/
	
	--LOCALIDADES
	INSERT INTO Localidades (localidad)
		SELECT DISTINCT Cli_Ciudad 
		FROM gd_esquema.Maestra
		WHERE Cli_Ciudad is not null
	
	--LOCALIDAD POR USUARIO
	INSERT INTO Localidad_por_usuario 
		SELECT DISTINCT  dbo.idCiudad(Cli_Ciudad),Cli_Dni
		FROM gd_esquema.Maestra
		WHERE Cli_Dni is not null
	
	--CLIENTES
	INSERT INTO Clientes 
		select distinct convert(varchar(30),Cli_Dni), Cli_Nombre, Cli_Apellido, Cli_Mail, Cli_Telefono, null, Cli_Fecha_Nac, dbo.idCiudad(Cli_Ciudad), Cli_Dni,0 
		from gd_esquema.Maestra where Cli_Dni is not null
	
	--PROVEEDORES
	INSERT INTO Proveedores
		select distinct convert(varchar(30),Provee_CUIT), Provee_CUIT, Provee_RS, null , Provee_Telefono, null, dbo.idCiudad(Provee_Ciudad), Provee_Rubro, null
		from gd_esquema.Maestra where Provee_CUIT is not null

	--LOGINS
	INSERT INTO Logins
		SELECT username, username,'Cliente',dbo.idEstadoUsuario('Habilitado'),0
		FROM Clientes
	INSERT INTO Logins
		SELECT username, dbo.SHA256(username),'Proveedor',dbo.idEstadoUsuario('Habilitado'),0
		FROM Proveedores		
	INSERT INTO Logins
		SELECT username, dbo.SHA256(username),'Administrador',dbo.idEstadoUsuario('Habilitado'),0
		FROM Administradores		
	
	
	--CARGAS
		INSERT	INTO Cargas (username, monto, tipo, tarjeta, fecha) 
				SELECT Cli_Dni, Carga_Credito, (select id_pago from Tipos_pago where descripcion = Tipo_Pago_Desc),null, Carga_Fecha FROM gd_esquema.Maestra WHERE Carga_Credito is not null


	--GIFTCARDS

		INSERT INTO Giftcards (cliente_origen, cliente_destino, fecha, monto)
		SELECT Cli_Dni, Cli_Dest_Dni, GiftCard_Fecha, GiftCard_Monto FROM gd_esquema.Maestra WHERE Cli_Dest_Dni is not null


	--GRUPOS
		
		INSERT	INTO GruposCupon (id_grupo, localidad, proveedor,precio_ficticio,fecha_publicacion,stock,limite_por_usuario, precio_real, fecha_vencimiento_canje, estado, fecha_vencimiento_oferta, descripcion)
				SELECT distinct Groupon_Codigo, dbo.idCiudad(Provee_Ciudad), Provee_CUIT, Groupon_Precio_Ficticio, Groupon_Fecha, Groupon_Cantidad, null, Groupon_Precio, Groupon_Fecha_Venc, 'Publicado', null, Groupon_Descripcion
				FROM gd_esquema.Maestra 
				WHERE Groupon_Codigo is not null
	
	
	--CUPONES
		INSERT INTO Cupones (cliente, id_grupo,fecha_compra,estado)
		
			SELECT Cli_Dni, Groupon_Codigo,Groupon_Fecha_Compra,'Comprado'
			FROM gd_esquema.Maestra
			WHERE Groupon_Codigo is not null AND Groupon_Devolucion_Fecha is null AND Factura_Nro is null AND Groupon_Entregado_Fecha is null
			
			except
			
			SELECT Cli_Dni, Groupon_Codigo,Groupon_Fecha_Compra,'Comprado' 
			FROM gd_esquema.Maestra
			WHERE Groupon_Codigo is not null AND Groupon_Devolucion_Fecha is not null AND Factura_Nro is null AND Groupon_Entregado_Fecha is null

			except
			
			SELECT Cli_Dni, Groupon_Codigo,Groupon_Fecha_Compra,'Comprado' 
			FROM gd_esquema.Maestra
			WHERE Groupon_Codigo is not null AND Groupon_Devolucion_Fecha is null AND Factura_Nro is null AND Groupon_Entregado_Fecha is not null

	
	--ENTREGAS
		INSERT INTO Cupones (cliente, id_grupo,fecha_compra,estado, fecha_canje)
		
			SELECT Cli_Dni, Groupon_Codigo,Groupon_Fecha_Compra,'Entregado' , Groupon_Entregado_Fecha
			FROM gd_esquema.Maestra
			WHERE Groupon_Codigo is not null AND Groupon_Devolucion_Fecha is null AND Factura_Nro is null AND Groupon_Entregado_Fecha is not null

	
	--DEVOLUCIONES 
		INSERT INTO Cupones (cliente, id_grupo,fecha_compra,estado)
			SELECT Cli_Dni, Groupon_Codigo,Groupon_Fecha_Compra,'Devuelto'
			FROM gd_esquema.Maestra
			WHERE Groupon_Codigo is not null AND Groupon_Devolucion_Fecha is not null AND Factura_Nro is null AND Groupon_Entregado_Fecha is null
		
		INSERT INTO Devoluciones (id_cupon,fecha_devolucion)
			SELECT DISTINCT c.id_cupon, Groupon_Devolucion_Fecha
			FROM gd_esquema.Maestra m	JOIN Cupones c ON m.Cli_Dni = c.cliente AND Groupon_Codigo = c.id_grupo
							AND m.Groupon_Fecha_Compra = c.fecha_compra AND m.Groupon_Devolucion_Fecha is not null


	--FACTURAS
		INSERT INTO Facturas (id_factura,proveedor, monto, fecha_desde,fecha_hasta)
			SELECT Factura_Nro,Provee_CUIT, SUM(Groupon_Precio_Ficticio) monto, Factura_Fecha, Factura_Fecha
			FROM gd_esquema.Maestra
			WHERE Factura_Nro is not null
			GROUP BY Factura_Nro, Provee_CUIT, Factura_Fecha

END

GO

CREATE PROCEDURE asignarSaldoInicial
AS
	BEGIN
		UPDATE Clientes
		set saldo = saldo + 10
	END

GO

/*
CREATE PROCEDURE CargarCredito(@clienteDni numeric(18,2), @cargaCredito float, @tipoPago nvarchar(100), @cargaFecha datetime)
AS
	BEGIN
		declare @tipo int
		select @tipo = id_pago from Tipos_pago where descripcion = @tipoPago 
		INSERT	INTO Cargas (username, monto, tipo, tarjeta, fecha) 
				VALUES(@clienteDni, @cargaCredito, @tipo, null, @cargaFecha)
	END

GO

CREATE PROCEDURE ProcesarGitfcard( @clienteDni nvarchar(255), @clienteDestDni nvarchar(255), @giftcardFecha datetime, @giftcardMonto numeric(18,2))
AS
	BEGIN
		INSERT	INTO Giftcards (cliente_origen, cliente_destino,fecha,monto)
				VALUES (@clienteDni, @clienteDestDni, @giftcardFecha, @giftcardMonto)
	END

GO

CREATE PROCEDURE InsertarGrupo(	@grouponCodigo nvarchar(50), @proveedorCiudad nvarchar(255), @proveedorCUIT nvarchar(20), @grouponPrecioFicticio numeric(18,2), 
									@grouponFecha datetime, @grouponCantidad numeric(18,0), @grouponPrecio numeric(18,2),
									@grouponFechaVencimiento datetime, @grouponDescripcion nvarchar(255))
AS
	BEGIN
		IF NOT EXISTS(SELECT * FROM GruposCupon WHERE id_grupo = @grouponCodigo)
		BEGIN
			INSERT	INTO GruposCupon (id_grupo, localidad, proveedor,precio_ficticio,fecha_publicacion,stock,limite_por_usuario, precio_real, fecha_vencimiento_canje, estado, fecha_vencimiento_oferta, descripcion)
					VALUES(@grouponCodigo,@proveedorCiudad, @proveedorCUIT,@grouponPrecioFicticio, @grouponFecha, @grouponCantidad, null, @grouponPrecio, @grouponFechaVencimiento, 'Publicado', null, @grouponDescripcion)
		END
	END
			
GO

CREATE PROCEDURE InsertarCupon( @clienteDni numeric(18,0), @grouponCodigo nvarchar(50), @grouponFechaCompra datetime, @id int output)
AS
	BEGIN
		 
		INSERT	INTO Cupones (cliente,id_grupo,fecha_compra,estado)
				VALUES (@clienteDni, @grouponCodigo, @grouponFechaCompra, 'Comprado')
				
		select @id = max(id_cupon) from Cupones
			
	END			

GO

CREATE PROCEDURE ActualizarEntrega (@idCupon int, @grouponEntregadoFecha datetime)
AS
	BEGIN
		UPDATE Cupones
		SET estado = 'Entregado', fecha_canje = @grouponEntregadoFecha
		WHERE id_cupon = @idCupon
	END	

GO

CREATE PROCEDURE ProcesarFactura(@facturaNro numeric(18,0), @proveedorCUIT nvarchar(20), @facturaFecha datetime, @grouponPrecio numeric(18,2))
AS
	BEGIN
	
		IF NOT EXISTS(SELECT * FROM Facturas WHERE id_factura = @facturaNro)
		BEGIN
			INSERT	INTO Facturas 
					VALUES (@facturaNro, @proveedorCUIT, @grouponPrecio, @facturaFecha, @facturaFecha)
		END
		
		ELSE
		BEGIN
			UPDATE Facturas 
			SET monto = monto + @grouponPrecio
			WHERE id_factura = @facturaNro
		END
	END

GO

CREATE PROCEDURE ProcesarDevolucion (@idCupon int, @grouponDevolucionFecha datetime)
AS
	BEGIN
		INSERT INTO Devoluciones VALUES (@idCupon, @grouponDevolucionFecha, null)
	END

GO

CREATE PROCEDURE AsignarCiudadAlUsuario(@usuario numeric(18,0), @ciudad nvarchar(255))
AS	
	BEGIN
		IF NOT EXISTS (SELECT * FROM Localidades WHERE localidad = @ciudad)
			begin
				INSERT INTO Localidades (localidad) VALUES (@ciudad)
				declare @id int
				select @id = id_localidad from Localidades where localidad = @ciudad
				INSERT INTO Localidad_por_usuario VALUES (@id,@usuario)
			end
	END
*/	

GO

begin tran
exec MigracionManopla
exec MigrarDatosSinCursor
exec asignarSaldoInicial
exec AsignarDireccion
commit tran
