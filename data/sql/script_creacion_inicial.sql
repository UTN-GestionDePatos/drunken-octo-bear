USE [GD2C2012]
GO
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
	numero bigint primary key,
	username varchar(30) references Clientes(username)
)

CREATE TABLE Cargas ( 
	id_carga bigint identity(1,1) primary key,
	username varchar(30) references Clientes(username),
	monto bigint,
	tipo int references Tipos_Pago (id_pago),
	tarjeta bigint references Tarjetas(numero),
	fecha datetime
)

CREATE TABLE GruposCupon ( 
	id_grupo varchar(30) primary key,
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


CREATE TABLE Localidad_por_grupo(
	id_localidad int not null references Localidades(id_localidad),
	id_grupo varchar(30) references GruposCupon(id_grupo)
)

CREATE TABLE Cupones ( 
	id_cupon bigint identity(1,1) primary key,
	cliente varchar(30) references Clientes(username),
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
	nombre_rol varchar(30)
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
	rol varchar(30),
	estado int references EstadosUsuarios(id_estado),
	intentos_fallidos int
)

CREATE TABLE Roles ( 
	nombre varchar(30) primary key,
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

--Administrador (el general y otro más)

insert into Administradores values('admin', 'Eurulio','Korsovich','e.korsovich@gmail.com',45554444)
insert into Administradores values ('admin123','Saturnino','Velmonte','saturnino.velmonte@gmail.com',45678676)
insert into Logins values('admin',dbo.SHA256('w23e'),'Administrador General',1,0)

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

insert into Roles values ('Administrador General', dbo.idEstadoUsuario('Habilitado'))
insert into Roles values ('Administrador',dbo.idEstadoUsuario('Habilitado'))
insert into Roles values ('Cliente',dbo.idEstadoUsuario('Habilitado'))
insert into Roles values ('Proveedor',dbo.idEstadoUsuario('Habilitado'))

--Funcion por rol
insert into Funcion_por_rol values (1,'Administrador General')
insert into Funcion_por_rol values (2,'Administrador General')
insert into Funcion_por_rol values (3,'Administrador General')
insert into Funcion_por_rol values (4,'Administrador General')
insert into Funcion_por_rol values (5,'Administrador General')
insert into Funcion_por_rol values (6,'Administrador General')
insert into Funcion_por_rol values (7,'Administrador General')
insert into Funcion_por_rol values (8,'Administrador General')
insert into Funcion_por_rol values (9,'Administrador General')
insert into Funcion_por_rol values (10,'Administrador General')
insert into Funcion_por_rol values (11,'Administrador General')
insert into Funcion_por_rol values (12,'Administrador General')
insert into Funcion_por_rol values (13,'Administrador General')
insert into Funcion_por_rol values (14,'Administrador General')
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
	SET stock = stock - (select count(*) from inserted where inserted.id_grupo = gc.id_grupo)
	FROM inserted i join GruposCupon gc on i.id_grupo = gc.id_grupo
	
END

GO


CREATE TRIGGER actualizarStockDevoluciones
ON Devoluciones
AFTER INSERT
AS
BEGIN
	declare @grupo varchar(30)
	declare unCursor cursor for (	select gc.id_grupo from inserted i join Cupones c on i.id_cupon = c.id_cupon
									join GruposCupon gc on gc.id_grupo = c.id_grupo )
	open unCursor
	fetch unCursor into @grupo
	while @@FETCH_STATUS = 0
	begin
		UPDATE GruposCupon
		SET stock = stock + 1
		WHERE id_grupo = @grupo
		fetch unCursor into @grupo
	end
	
	close unCursor
	deallocate unCursor
	
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
		SELECT username,dbo.SHA256(username),'Cliente',dbo.idEstadoUsuario('Habilitado'),0
		FROM Clientes
	INSERT INTO Logins
		SELECT username, dbo.SHA256(username),'Proveedor',dbo.idEstadoUsuario('Habilitado'),0
		FROM Proveedores		
	INSERT INTO Logins
		SELECT username, dbo.SHA256(username),'Administrador',dbo.idEstadoUsuario('Habilitado'),0
		FROM Administradores
		WHERE username != 'admin'
	
	
	--CARGAS
		INSERT	INTO Cargas (username, monto, tipo, tarjeta, fecha) 
				SELECT Cli_Dni, Carga_Credito, (select id_pago from Tipos_pago where descripcion = Tipo_Pago_Desc),null, Carga_Fecha FROM gd_esquema.Maestra WHERE Carga_Credito is not null


	--GIFTCARDS

		INSERT INTO Giftcards (cliente_origen, cliente_destino, fecha, monto)
		SELECT Cli_Dni, Cli_Dest_Dni, GiftCard_Fecha, GiftCard_Monto FROM gd_esquema.Maestra WHERE Cli_Dest_Dni is not null


	--GRUPOS
		
		INSERT	INTO GruposCupon (id_grupo, proveedor,precio_ficticio,fecha_publicacion,stock,limite_por_usuario, precio_real, fecha_vencimiento_canje, estado, fecha_vencimiento_oferta, descripcion)
				SELECT distinct Groupon_Codigo, Provee_CUIT, Groupon_Precio_Ficticio, Groupon_Fecha, Groupon_Cantidad, null, Groupon_Precio, Groupon_Fecha_Venc, 'Publicado', null, Groupon_Descripcion
				FROM gd_esquema.Maestra 
				WHERE Groupon_Codigo is not null
	
	--LOCALIDAD POR GRUPO
	INSERT	INTO Localidad_por_grupo
			SELECT distinct dbo.idCiudad(Provee_Ciudad), Groupon_Codigo
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
CREATE PROCEDURE PedirDevolucion(@idcupon int ,@username varchar(30),@fecha_actual datetime,@motivo varchar(250),@ret int output)
AS
BEGIN
--ver si esta comparacion de fechas esta bien
/*
	0: ok
	1: user y cupon no matchean
	2: el cupon o esta devuelto, o esta canjeado 
	3: el cupon expiro
*/
	if not exists (select * from Cupones where cliente = @username and id_cupon = @idcupon)
		begin
			 set @ret = 1
			 return
		end
	if not exists (select * from Cupones where id_cupon = @idcupon and estado = 'Comprado')
		begin
			set @ret = 2
			return
		end	
	
	-- TODO Si llega aca, hay que mostrar datos del cupon, una manera es hacer un select directamente en c#
		
	If (select g.fecha_vencimiento_canje from GruposCupon g join Cupones c on c.id_grupo= g.id_grupo where c.id_cupon=@idcupon)<= @fecha_actual RETURN
	else
	begin
		--si llega aca es porque expiro el cupon
		set @ret = 3
		return
	end
END

GO

CREATE PROCEDURE ConfirmarDevolucion(@idcupon int,@fecha_actual datetime,@motivo varchar(250), @ret int output)
AS
BEGIN
		insert into Devoluciones values(@idcupon,@fecha_actual,@motivo)
		set @ret = 0
		return
END

GO

CREATE PROCEDURE Loguearse (@user varchar(30), @pass varchar(30), @ret int output)

/*
	0: ok
	1: error login
	2: inhabilitacion
	3: no existe usuario
	4: usuario inhabilitado
*/
AS
BEGIN
	
	if exists (select * from Logins where username = @user)
	begin
		if(select estado from Logins where username = @user) = 2
		begin
			set @ret = 4
			return
		end
     IF(Select 1 from Logins Where username= @user AND passwd=dbo.SHA256( @pass) )is NULL
          BEGIN
               Update Logins set intentos_fallidos =intentos_fallidos+1 Where username = @user
               if(select intentos_fallidos from Logins where username = @user) = 3
               begin
					Update Logins set intentos_fallidos = 0, estado = 2 Where username = @user
					set @ret = 2
					return
               end
               set @ret = 1
               return
          END
     ELSE
          BEGIN
              set @ret = 0
              return
          END
	end
	else
		begin
			set @ret = 3
			return
		end
END

GO

CREATE PROCEDURE ComprarGiftcard(@fecha datetime,@monto bigint,@clienteOrigen varchar(30),@clienteDestino varchar(30), @ret int output)
AS
BEGIN
/*
	0: ok
	1: cliente origen = cliente destino
	2: cliente destino no habilitado
	3: cliente destino no existe
*/	

	if not exists( select * from Clientes where username = @clienteDestino)
	begin
		set @ret = 3
		return
	end
	IF(@clienteOrigen<>@clienteDestino)
		BEGIN
			IF (select estado from Logins where username=@clienteDestino) = dbo.idEstado('Habilitado')
			BEGIN
				insert into Giftcards values (@clienteOrigen, @clienteDestino, @fecha, @monto)
				set @ret = 0
				return
			END
			else
			begin
				set @ret = 2
				return
			end
		END
	else
		begin
			set @ret = 1
			return
		end
END

GO

CREATE PROCEDURE CargarCredito(@username varchar(30),@fecha datetime,@tipoPago varchar(30),@monto bigint,@numeroTarjeta bigint, @ret int output)
AS
BEGIN

/*
	0: ok
	1: monto < $15
	2: tarjeta incorrecta
	3: cliente incorrecto
*/
	if not exists(select * from Clientes where username = @username)
	begin
		set @ret = 3
		return
	end
	IF (@monto>15)
	BEGIN --ver si me tengo que fijar que exista la tarjeta o agregarla
		declare @tipo int
		select @tipo = id_pago from Tipos_pago where descripcion = @tipoPago
		
		if @tipo in (2,3)
		begin
			--validacion tarjeta
			if not exists (select * from Tarjetas where username = @username)
				begin
					insert into Tarjetas (numero,username) values (@numeroTarjeta, @username)
				end
			else
				begin
					if (select numero from Tarjetas where username = @username) != @numeroTarjeta
					begin
						set @ret = 2
						return
					end
				end
			insert into Cargas values(@username,@monto,@tipo,@numeroTarjeta,@fecha)
		end
		else --efectivo
		begin
			insert into Cargas values(@username,@monto,@tipo,null,@fecha)
		end
		
		set @ret = 0
		return;
	END
	else
		begin
			set @ret = 1
			return
		end
END


GO

CREATE PROCEDURE ArmarCupon (	@codigoGrupo varchar(30), @descripcion varchar(250), @fechaSistema datetime, 
								@fechaVencimientoCanje datetime, @fechaVencimientoOferta datetime,
								@precio_ficticio float, @precio_real float, @limite_usuario int, @stock bigint,
								@proveedor varchar(30), @ret int output)
AS
BEGIN

/*
	0: ok
	1: grupo ya existe
	2: la fecha de vencimiento de la oferta ya paso...
*/

if exists (select * from GruposCupon where id_grupo = @codigoGrupo)
	begin
		set @ret = 1
		return
	end

if @fechaVencimientoOferta < @fechaSistema
	begin
		set @ret = 2
		return
	end

insert into GruposCupon values(	@codigoGrupo, @proveedor, @precio_ficticio, null, @stock, @limite_usuario, @precio_real,
								@fechaVencimientoCanje, 'A publicar', @fechaVencimientoOferta, @descripcion)

set @ret = 0
return
END

GO

CREATE PROCEDURE AsignarLocalidadAlGrupo(@localidad varchar(30), @grupo varchar(30), @ret int output)
AS
BEGIN
	INSERT INTO Localidad_por_grupo VALUES (dbo.idCiudad(@localidad),@grupo)
	set @ret = 0
	
END

GO

CREATE PROCEDURE AltaRol (@nombre varchar(50),@ret int output)
AS
BEGIN
	if exists(select * from Roles where nombre = @nombre)
	begin
		set @ret = 1
		return
	end
	
	set @ret = 0
	insert into Roles values (@nombre,1)
END

GO

CREATE PROCEDURE AsignarFuncionalidadAlRol (@id int, @rol varchar(50), @ret int output)
AS
BEGIN
	insert into Funcion_por_rol values(@id,@rol)
	set @ret = 0
END
GO

CREATE PROCEDURE EliminarFuncionalidadesDeRol(@nombre_rol varchar(30))
AS
BEGIN
	DELETE FROM Funcion_por_rol WHERE nombre_rol = @nombre_rol
END
GO

CREATE PROCEDURE EliminarRol(@nombre_rol varchar(30))
AS
BEGIN
	EXEC dbo.EliminarFuncionalidadesDeRol @nombre_rol
	DELETE FROM Roles WHERE nombre = @nombre_rol
END
GO

begin tran
exec MigracionManopla
exec MigrarDatosSinCursor
exec asignarSaldoInicial
exec AsignarDireccion
commit tran
