/*
	=============================================
					Configuración
	=============================================
*/
USE [GD2C2012]
GO

EXEC sp_configure 'show advanced options', 1
GO
RECONFIGURE
EXEC sp_configure 'clr enabled', 1
GO
EXEC sp_configure 'xp_cmdshell', 1
GO
RECONFIGURE
GO

CREATE ASSEMBLY [Crypt]
AUTHORIZATION [dbo]
FROM 0x4D5A90000300000004000000FFFF0000B800000000000000400000000000000000000000000000000000000000000000000000000000000000000000800000000E1FBA0E00B409CD21B8014CCD21546869732070726F6772616D2063616E6E6F742062652072756E20696E20444F53206D6F64652E0D0D0A2400000000000000504500004C0103004DEA86500000000000000000E00002210B0108000006000000060000000000004E240000002000000040000000004000002000000002000004000000000000000400000000000000008000000002000000000000030040850000100000100000000010000010000000000000100000000000000000000000002400004B000000004000009802000000000000000000000000000000000000006000000C00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000200000080000000000000000000000082000004800000000000000000000002E7465787400000054040000002000000006000000020000000000000000000000000000200000602E7273726300000098020000004000000004000000080000000000000000000000000000400000402E72656C6F6300000C0000000060000000020000000C0000000000000000000000000000400000420000000000000000000000000000000030240000000000004800000002000500842000007C0300000100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000133002001E0000000100001100730400000A0A060F00280500000A6F0600000A730700000A0B2B00072A1E02280800000A2A000042534A4201000100000000000C00000076322E302E35303732370000000005006C0000003C010000237E0000A80100005C01000023537472696E6773000000000403000008000000235553000C0300001000000023475549440000001C0300006000000023426C6F620000000000000002000001471502000900000000FA0133001600000100000008000000020000000200000001000000080000000300000001000000010000000200000000000A0001000000000006002A0023000A0052003D000A005B003D000600970077000600B70077000A00F000D50006002201050106004001050100000000010000000000010001000100100014000000050001000100502000000000960065000A0001007A200000000086186C001100020000000100720021006C00150029006C00110031006C00110039006C001100190030011F0041004E01240011006C002B0009006C00110020001B001A002E000B0038002E001300410031000480000000000000000000000000000000001400000002000000000000000000000001001A000000000002000000000000000000000001003100000000000000003C4D6F64756C653E0043727970742E646C6C004372797074006D73636F726C69620053797374656D004F626A6563740053797374656D2E446174610053797374656D2E446174612E53716C54797065730053716C42797465730053716C537472696E6700536861323536002E63746F7200746578740053797374656D2E52756E74696D652E436F6D70696C6572536572766963657300436F6D70696C6174696F6E52656C61786174696F6E734174747269627574650052756E74696D65436F6D7061746962696C697479417474726962757465004D6963726F736F66742E53716C5365727665722E5365727665720053716C46756E6374696F6E4174747269627574650053797374656D2E53656375726974792E43727970746F677261706879005348413235364D616E6167656400476574556E69636F646542797465730048617368416C676F726974686D00436F6D7075746548617368000000000320000000000091BDAFF685156942AFC88746F9CBE80A0008B77A5C561934E0890600011209110D03200001042001010804010000000420001D050620011D051D05052001011D05060702122112090801000800000000001E01000100540216577261704E6F6E457863657074696F6E5468726F7773012824000000000000000000003E240000002000000000000000000000000000000000000000000000302400000000000000005F436F72446C6C4D61696E006D73636F7265652E646C6C0000000000FF25002040000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001001000000018000080000000000000000000000000000001000100000030000080000000000000000000000000000001000000000048000000584000003C02000000000000000000003C0234000000560053005F00560045005200530049004F004E005F0049004E0046004F0000000000BD04EFFE00000100000000000000000000000000000000003F000000000000000400000002000000000000000000000000000000440000000100560061007200460069006C00650049006E0066006F00000000002400040000005400720061006E0073006C006100740069006F006E00000000000000B0049C010000010053007400720069006E006700460069006C00650049006E0066006F0000007801000001003000300030003000300034006200300000002C0002000100460069006C0065004400650073006300720069007000740069006F006E000000000020000000300008000100460069006C006500560065007200730069006F006E000000000030002E0030002E0030002E003000000034000A00010049006E007400650072006E0061006C004E0061006D0065000000430072007900700074002E0064006C006C0000002800020001004C006500670061006C0043006F0070007900720069006700680074000000200000003C000A0001004F0072006900670069006E0061006C00460069006C0065006E0061006D0065000000430072007900700074002E0064006C006C000000340008000100500072006F006400750063007400560065007200730069006F006E00000030002E0030002E0030002E003000000038000800010041007300730065006D0062006C0079002000560065007200730069006F006E00000030002E0030002E0030002E003000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002000000C000000503400000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
WITH PERMISSION_SET = SAFE
GO

CREATE FUNCTION SHA256(@text nchar(50))
RETURNS VARBINARY(256) AS 
EXTERNAL NAME Crypt.Crypt.Sha256
GO

/*
	=============================================
					    Tablas
	=============================================
*/
CREATE SCHEMA GESTION_DE_PATOS AUTHORIZATION gd
	CREATE TABLE GESTION_DE_PATOS.Administradores ( 
		username varchar(30) primary key references GESTION_DE_PATOS.Usuarios(username),
		nombre varchar(30),
		apellido varchar(30),
		mail varchar(30),
		telefono bigint unique
	)

	CREATE TABLE GESTION_DE_PATOS.Localidades(
		id_localidad int identity(1,1) primary key,
		localidad varchar(30)
	)


	CREATE TABLE GESTION_DE_PATOS.Localidad_por_usuario(
		id_localidad int primary key references GESTION_DE_PATOS.Localidades(id_localidad),
		username varchar(30)
	)


	CREATE TABLE GESTION_DE_PATOS.Clientes ( 
		username varchar(30) primary key references GESTION_DE_PATOS.Usuarios(username),
		nombre varchar(30),
		apellido varchar(30),
		mail varchar(30),
		telefono bigint unique,
		direccion varchar(100),
		fecha_nacimiento datetime,
		ciudad int references GESTION_DE_PATOS.Localidades(id_localidad),
		dni bigint,
		saldo float
	)

	CREATE TABLE GESTION_DE_PATOS.Rubros ( 
		id_rubro bigint primary key identity(1,1),
		descripcion varchar(30)
	)

	CREATE TABLE GESTION_DE_PATOS.Proveedores ( 
		username varchar(30) primary key  references GESTION_DE_PATOS.Usuarios(username),
		cuit nvarchar(20) unique,
		razon_social varchar(30),
		mail varchar(30),
		telefono bigint unique,
		direccion varchar(100),
		ciudad int references GESTION_DE_PATOS.Localidades(id_localidad),
		id_rubro bigint references GESTION_DE_PATOS.Proveedores (id_rubro),
		nombre_contacto varchar(30)
	)

	CREATE TABLE GESTION_DE_PATOS.Tipos_pago ( 
		id_pago int identity(1,1) primary key,
		descripcion varchar(30)
	)

	CREATE TABLE GESTION_DE_PATOS.GESTION_DE_PATOS.Tarjetas ( 
		numero bigint primary key,
		username varchar(30) references GESTION_DE_PATOS.Clientes(username)
	)

	CREATE TABLE GESTION_DE_PATOS.Cargas ( 
		id_carga bigint identity(1,1) primary key,
		username varchar(30) references GESTION_DE_PATOS.Clientes(username),
		monto bigint,
		tipo int references GESTION_DE_PATOS.Tipos_pago (id_pago),
		tarjeta bigint references GESTION_DE_PATOS.GESTION_DE_PATOS.Tarjetas(numero),
		fecha datetime
	)

	CREATE TABLE GESTION_DE_PATOS.Promociones ( 
		id_promocion varchar(30) primary key,
		proveedor varchar(30) references GESTION_DE_PATOS.Proveedores(username),
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


	CREATE TABLE GESTION_DE_PATOS.Localidad_por_promocion(
		id_localidad int primary key references GESTION_DE_PATOS.Localidades(id_localidad),
		id_promocion varchar(30) references GESTION_DE_PATOS.Promociones(id_promocion)
	)

	CREATE TABLE GESTION_DE_PATOS.Cupones ( 
		id_cupon bigint identity(1,1) primary key,
		cliente varchar(30) references GESTION_DE_PATOS.Clientes(username),
		id_promocion varchar(30) references GESTION_DE_PATOS.Promociones(id_promocion),
		fecha_compra datetime,	
	)

	CREATE TABLE GESTION_DE_PATOS.Devoluciones ( 
		id_cupon bigint primary key references GESTION_DE_PATOS.Cupones(id_cupon),
		fecha_devolucion datetime,
		motivo varchar(250)
	)

	CREATE TABLE GESTION_DE_PATOS.Canjes (
		id_cupon bigint primary key references GESTION_DE_PATOS.Cupones(id_cupon),
		fecha_canje datetime
	)

	CREATE TABLE GESTION_DE_PATOS.EstadosGESTION_DE_PATOS.Usuarios ( 
		id_estado int identity(1,1) primary key,
		nombre_estado varchar(20)
	)

	CREATE TABLE GESTION_DE_PATOS.Facturas ( 
		id_factura bigint primary key,
		proveedor varchar(30) references GESTION_DE_PATOS.Proveedores(username),
		monto float,
		fecha_desde datetime,
		fecha_hasta datetime
	)

	CREATE TABLE GESTION_DE_PATOS.Funcionalidades ( 
		id_funcionalidad int identity(1,1) primary key,
		descripcion varchar(50)
	)

	CREATE TABLE GESTION_DE_PATOS.Roles ( 
		nombre varchar(30) primary key,
		estado int references GESTION_DE_PATOS.EstadosGESTION_DE_PATOS.Usuarios(id_estado)
	)

	CREATE TABLE GESTION_DE_PATOS.Funcion_por_rol ( 
		id_funcionalidad int NOT NULL references GESTION_DE_PATOS.Funcionalidades(id_funcionalidad),
		nombre_rol varchar(30) NOT NULL references GESTION_DE_PATOS.Roles(nombre)
	)

	CREATE TABLE GESTION_DE_PATOS.Giftcards ( 
		id_giftcard bigint identity(1,1) primary key,
		cliente_origen varchar(30) references GESTION_DE_PATOS.Clientes(username),
		cliente_destino varchar(30) references GESTION_DE_PATOS.Clientes(username),
		fecha datetime,
		monto bigint
	)

	CREATE TABLE GESTION_DE_PATOS.Usuarios ( 
		username varchar(30) primary key,
		passwd varchar(4000),
		rol varchar(30),
		estado int references GESTION_DE_PATOS.EstadosGESTION_DE_PATOS.Usuarios(id_estado),
		intentos_fallidos int
	)
GO
/*
	=============================================
			  Funciones y Procedimientos
	=============================================
*/

CREATE FUNCTION idCiudad(@ciudad varchar(30))
RETURNS int
AS
BEGIN
	DECLARE @id int
	SELECT @id = id_localidad
	FROM GESTION_DE_PATOS.Localidades
	WHERE localidad = @ciudad
	RETURN @id
END
GO

CREATE FUNCTION idRubro(@rubro varchar(30))
RETURNS int
AS
BEGIN
	DECLARE @id int
	SELECT @id = id_rubro
	FROM GESTION_DE_PATOS.Rubros
	WHERE descripcion = @rubro
	RETURN @id
END

GO

CREATE FUNCTION idEstadoUsuario(@estado varchar(30))
RETURNS int
AS
BEGIN
	DECLARE @id int
	SELECT @id = id_estado
	FROM GESTION_DE_PATOS.EstadosGESTION_DE_PATOS.Usuarios
	WHERE nombre_estado = @estado
	RETURN @id
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
	if not exists (select * from GESTION_DE_PATOS.Cupones where cliente = @username and id_cupon = @idcupon)
		begin
			 set @ret = 1
			 return
		end
	if not exists (select * from GESTION_DE_PATOS.Cupones where id_cupon = @idcupon and estado = 'Comprado')
		begin
			set @ret = 2
			return
		end	
	
	-- TODO Si llega aca, hay que mostrar datos del cupon, una manera es hacer un select directamente en c#
		
	If (select g.fecha_vencimiento_canje from GESTION_DE_PATOS.Promociones g join GESTION_DE_PATOS.Cupones c on c.id_promocion= g.id_promocion where c.id_cupon=@idcupon)<= @fecha_actual RETURN
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
		insert into GESTION_DE_PATOS.Devoluciones values(@idcupon,@fecha_actual,@motivo)
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
	
	if exists (select * from GESTION_DE_PATOS.Usuarios where username = @user)
	begin
		if(select estado from GESTION_DE_PATOS.Usuarios where username = @user) = 2
		begin
			set @ret = 4
			return
		end
     IF(Select 1 from GESTION_DE_PATOS.Usuarios Where username= @user AND passwd=dbo.SHA256( @pass) )is NULL
          BEGIN
               Update GESTION_DE_PATOS.Usuarios set intentos_fallidos =intentos_fallidos+1 Where username = @user
               if(select intentos_fallidos from GESTION_DE_PATOS.Usuarios where username = @user) = 3
               begin
					Update GESTION_DE_PATOS.Usuarios set intentos_fallidos = 0, estado = 2 Where username = @user
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

	if not exists( select * from GESTION_DE_PATOS.Clientes where username = @clienteDestino)
	begin
		set @ret = 3
		return
	end
	IF(@clienteOrigen<>@clienteDestino)
		BEGIN
			IF (select estado from GESTION_DE_PATOS.Usuarios where username=@clienteDestino) = dbo.idEstado('Habilitado')
			BEGIN
				insert into GESTION_DE_PATOS.Giftcards values (@clienteOrigen, @clienteDestino, @fecha, @monto)
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
	if not exists(select * from GESTION_DE_PATOS.Clientes where username = @username)
	begin
		set @ret = 3
		return
	end
	IF (@monto>15)
	BEGIN --ver si me tengo que fijar que exista la tarjeta o agregarla
		declare @tipo int
		select @tipo = id_pago from GESTION_DE_PATOS.Tipos_pago where descripcion = @tipoPago
		
		if @tipo in (2,3)
		begin
			--validacion tarjeta
			if not exists (select * from GESTION_DE_PATOS.GESTION_DE_PATOS.Tarjetas where username = @username)
				begin
					insert into GESTION_DE_PATOS.GESTION_DE_PATOS.Tarjetas (numero,username) values (@numeroTarjeta, @username)
				end
			else
				begin
					if (select numero from GESTION_DE_PATOS.GESTION_DE_PATOS.Tarjetas where username = @username) != @numeroTarjeta
					begin
						set @ret = 2
						return
					end
				end
			insert into GESTION_DE_PATOS.Cargas values(@username,@monto,@tipo,@numeroTarjeta,@fecha)
		end
		else --efectivo
		begin
			insert into GESTION_DE_PATOS.Cargas values(@username,@monto,@tipo,null,@fecha)
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

if exists (select * from GESTION_DE_PATOS.Promociones where id_promocion = @codigoGrupo)
	begin
		set @ret = 1
		return
	end

if @fechaVencimientoOferta < @fechaSistema
	begin
		set @ret = 2
		return
	end

insert into GESTION_DE_PATOS.Promociones values(	@codigoGrupo, @proveedor, @precio_ficticio, null, @stock, @limite_usuario, @precio_real,
								@fechaVencimientoCanje, 'A publicar', @fechaVencimientoOferta, @descripcion)

set @ret = 0
return
END

GO

CREATE PROCEDURE AsignarLocalidadAlGrupo(@localidad varchar(30), @grupo varchar(30), @ret int output)
AS
BEGIN
	INSERT INTO GESTION_DE_PATOS.Localidad_por_promocion VALUES (dbo.idCiudad(@localidad),@grupo)
	set @ret = 0
	
END

GO

CREATE PROCEDURE AltaRol (@nombre varchar(50),@ret int output)
AS
BEGIN
	if exists(select * from GESTION_DE_PATOS.Roles where nombre = @nombre)
	begin
		set @ret = 1
		return
	end
	
	set @ret = 0
	insert into GESTION_DE_PATOS.Roles values (@nombre,1)
END

GO

CREATE PROCEDURE AsignarFuncionalidadAlRol (@id int, @rol varchar(50), @ret int output)
AS
BEGIN
	insert into GESTION_DE_PATOS.Funcion_por_rol values(@id,@rol)
	set @ret = 0
END
GO

CREATE PROCEDURE GESTION_DE_PATOS.EliminarFuncionalidadesDeRol(@nombre_rol varchar(30))
AS
BEGIN
	DELETE FROM GESTION_DE_PATOS.Funcion_por_rol WHERE nombre_rol = @nombre_rol
END
GO

CREATE PROCEDURE EliminarRol(@nombre_rol varchar(30))
AS
BEGIN
	EXEC GESTION_DE_PATOS.EliminarFuncionalidadesDeRol @nombre_rol
	DELETE FROM GESTION_DE_PATOS.Roles WHERE nombre = @nombre_rol
END
GO

CREATE FUNCTION GESTION_DE_PATOS.FuncionalidadesDelRol(@nombre_rol varchar(30)) RETURNS TABLE
AS
RETURN 
(
	SELECT f.id_funcionalidad, f.descripcion, (SELECT 1 FROM GESTION_DE_PATOS.Funcion_por_rol fpr WHERE fpr.id_funcionalidad = f.id_funcionalidad AND fpr.nombre_rol = @nombre_rol) AS permitido FROM GESTION_DE_PATOS.Funcionalidades f
)
GO


/*
	=============================================
					   Triggers
	=============================================
*/

CREATE TRIGGER actualizarSaldoGESTION_DE_PATOS.Cargas
ON GESTION_DE_PATOS.Cargas
AFTER INSERT
AS
	begin
		
		declare @temp table (id varchar(30), monto float)
		insert into @temp select inserted.username,sum(inserted.monto) from inserted group by inserted.username
		
		update GESTION_DE_PATOS.Clientes 
		set saldo = saldo + t.monto
		from GESTION_DE_PATOS.Clientes c join @temp t on c.username = t.id
		
	end
GO

CREATE TRIGGER actualizarSaldoGESTION_DE_PATOS.Cupones
ON GESTION_DE_PATOS.Cupones
AFTER INSERT
AS
	BEGIN
		declare @temp table (cliente varchar(30), monto float)
		insert into @temp
		select inserted.cliente, sum(gc.precio_real)
		from GESTION_DE_PATOS.Promociones gc JOIN inserted ON gc.id_promocion = inserted.id_promocion
		group by inserted.cliente
		
		UPDATE GESTION_DE_PATOS.Clientes SET saldo = saldo - t.monto
		FROM GESTION_DE_PATOS.Clientes c join @temp t on c.username = t.cliente 
	
	END

GO

CREATE TRIGGER actualizarSaldoGESTION_DE_PATOS.CuponesPorDevolucion
ON GESTION_DE_PATOS.Cupones
AFTER UPDATE
AS
	BEGIN

		UPDATE GESTION_DE_PATOS.Clientes SET saldo = saldo + gc.precio_real
		FROM GESTION_DE_PATOS.Promociones gc JOIN inserted ON gc.id_promocion = inserted.id_promocion
		WHERE username = inserted.cliente AND inserted.estado = 'Devuelto'
			
	END

GO


CREATE TRIGGER actualizarEstadoGESTION_DE_PATOS.Devoluciones
ON GESTION_DE_PATOS.Devoluciones
AFTER INSERT
AS
	BEGIN
		declare @cupon int
		select @cupon = id_cupon from inserted
		update GESTION_DE_PATOS.Cupones set estado = 'Devuelto' where id_cupon = @cupon
	END

GO

CREATE TRIGGER actualizarSaldoGESTION_DE_PATOS.Devoluciones
ON GESTION_DE_PATOS.Devoluciones
AFTER INSERT
AS
	BEGIN
		declare @temp table (cliente varchar(30), monto float)
		insert into @temp
		select c.cliente, sum(gc.precio_real)
		from GESTION_DE_PATOS.Promociones gc join GESTION_DE_PATOS.Cupones c on gc.id_promocion = c.id_promocion
							join inserted on inserted.id_cupon = c.id_cupon
		group by c.cliente
		
		UPDATE GESTION_DE_PATOS.Clientes SET saldo = saldo + t.monto
		FROM GESTION_DE_PATOS.Clientes cli join @temp t on cli.username = t.cliente 
	
	END
GO

CREATE TRIGGER actualizarSaldoGESTION_DE_PATOS.Giftcards
ON GESTION_DE_PATOS.Giftcards
AFTER INSERT
AS
	BEGIN		
		declare @temp table (id varchar(30), monto float)
		insert into @temp select inserted.cliente_origen,sum(inserted.monto) from inserted group by inserted.cliente_origen
		
		update GESTION_DE_PATOS.Clientes set saldo = saldo - t.monto
		from GESTION_DE_PATOS.Clientes c join @temp t on c.username = t.id
	
		delete from @temp
		
		insert into @temp select inserted.cliente_destino,sum(inserted.monto) from inserted group by inserted.cliente_destino
		
		update GESTION_DE_PATOS.Clientes set saldo = saldo + t.monto
		from GESTION_DE_PATOS.Clientes c join @temp t on c.username = t.id		
	END
GO

CREATE TRIGGER actualizarStockGESTION_DE_PATOS.Cupones
ON GESTION_DE_PATOS.Cupones
AFTER INSERT
AS
BEGIN
	UPDATE GESTION_DE_PATOS.Promociones
	SET stock = stock - (select count(*) from inserted where inserted.id_promocion = gc.id_promocion)
	FROM inserted i join GESTION_DE_PATOS.Promociones gc on i.id_promocion = gc.id_promocion
	
END

GO


CREATE TRIGGER actualizarStockGESTION_DE_PATOS.Devoluciones
ON GESTION_DE_PATOS.Devoluciones
AFTER INSERT
AS
BEGIN
	declare @grupo varchar(30)
	declare unCursor cursor for (	select gc.id_promocion from inserted i join GESTION_DE_PATOS.Cupones c on i.id_cupon = c.id_cupon
									join GESTION_DE_PATOS.Promociones gc on gc.id_promocion = c.id_promocion )
	open unCursor
	fetch unCursor into @grupo
	while @@FETCH_STATUS = 0
	begin
		UPDATE GESTION_DE_PATOS.Promociones
		SET stock = stock + 1
		WHERE id_promocion = @grupo
		fetch unCursor into @grupo
	end
	
	close unCursor
	deallocate unCursor
END
GO

/*CREATE VIEW LoginView
AS
SELECT username,passwd,rol,estado,intentos_fallidos FROM GESTION_DE_PATOS.Usuarios
GO*/


/*
	=============================================
		    Procedimientos de Migración
	=============================================
*/

CREATE PROCEDURE CargarDatosBase
AS
BEGIN
		/*PARTE DE LA MIGRACION A MANO*/
		--Estados

		insert into GESTION_DE_PATOS.EstadosGESTION_DE_PATOS.Usuarios(nombre_estado) values('Habilitado')
		insert into GESTION_DE_PATOS.EstadosGESTION_DE_PATOS.Usuarios(nombre_estado) values('Deshabilitado')

		--Tipo de pago

		insert into GESTION_DE_PATOS.Tipos_pago (descripcion) values ('Efectivo')
		insert into GESTION_DE_PATOS.Tipos_pago (descripcion) values ('Crédito')
		insert into GESTION_DE_PATOS.Tipos_pago (descripcion) values ('Débito')

		--Administrador (el general y otro más)

		insert into GESTION_DE_PATOS.Administradores values('admin', 'Eurulio','Korsovich','e.korsovich@gmail.com',45554444)
		insert into GESTION_DE_PATOS.Administradores values ('admin123','Saturnino','Velmonte','saturnino.velmonte@gmail.com',45678676)
		insert into GESTION_DE_PATOS.Usuarios values('admin',dbo.SHA256('w23e'),'Administrador General',1,0)

		--Funcionalidades

		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('ABM Rol')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('Registro Usuario')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('ABM GESTION_DE_PATOS.Clientes')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('ABM GESTION_DE_PATOS.Proveedores')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('Carga de credito')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('Comprar Giftcard')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('Comprar Cupon')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('Pedir Devolucion')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('Historial de Compra de GESTION_DE_PATOS.Cupones')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('Armar Cupon')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('Registro de consumo de cupon')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('Publicar Cupon')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('Facturacion a Proveedor')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('Listado estadistico')

		--Roles

		insert into GESTION_DE_PATOS.Roles values ('Administrador General', dbo.idEstadoUsuario('Habilitado'))
		insert into GESTION_DE_PATOS.Roles values ('Administrador',dbo.idEstadoUsuario('Habilitado'))
		insert into GESTION_DE_PATOS.Roles values ('Cliente',dbo.idEstadoUsuario('Habilitado'))
		insert into GESTION_DE_PATOS.Roles values ('Proveedor',dbo.idEstadoUsuario('Habilitado'))

		--Funcion por rol
		insert into GESTION_DE_PATOS.Funcion_por_rol values (1,'Administrador General')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (2,'Administrador General')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (3,'Administrador General')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (4,'Administrador General')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (5,'Administrador General')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (6,'Administrador General')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (7,'Administrador General')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (8,'Administrador General')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (9,'Administrador General')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (10,'Administrador General')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (11,'Administrador General')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (12,'Administrador General')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (13,'Administrador General')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (14,'Administrador General')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (1,'Administrador')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (2,'Administrador')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (2,'Cliente')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (2,'Proveedor')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (3,'Administrador')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (4,'Administrador')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (5,'Administrador')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (6,'Cliente')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (7,'Cliente')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (8,'Cliente')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (9,'Cliente')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (10,'Proveedor')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (11,'Proveedor')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (12,'Administrador')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (13,'Administrador')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (14,'Administrador')

END
GO

CREATE PROCEDURE MigrarDatos
AS
BEGIN
	
	--Localidades
	INSERT INTO GESTION_DE_PATOS.Localidades (localidad)
		SELECT DISTINCT Cli_Ciudad 
		FROM gd_esquema.Maestra
		WHERE Cli_Ciudad is not null
	
	--LOCALIDAD POR USUARIO
	INSERT INTO GESTION_DE_PATOS.Localidad_por_usuario 
		SELECT DISTINCT  dbo.idCiudad(Cli_Ciudad),Cli_Dni
		FROM gd_esquema.Maestra
		WHERE Cli_Dni is not null
	
	--Clientes
	INSERT INTO GESTION_DE_PATOS.Clientes 
		select distinct convert(varchar(30),Cli_Dni), Cli_Nombre, Cli_Apellido, Cli_Mail, Cli_Telefono, null, Cli_Fecha_Nac, dbo.idCiudad(Cli_Ciudad), Cli_Dni,0 
		from gd_esquema.Maestra where Cli_Dni is not null
	
	--Rubros
	insert into Rubros (descripcion) select distinct provee_rubro from gd_esquema.Maestra where Provee_CUIT is not null

	--Proveedores
	INSERT INTO GESTION_DE_PATOS.Proveedores
		select distinct convert(varchar(30),Provee_CUIT), Provee_CUIT, Provee_RS, null , Provee_Telefono, null, dbo.idCiudad(Provee_Ciudad), Provee_Rubro, null
		from gd_esquema.Maestra where Provee_CUIT is not null

	--Usuarios
	INSERT INTO GESTION_DE_PATOS.Usuarios
		SELECT username,dbo.SHA256(username),'Cliente',dbo.idEstadoUsuario('Habilitado'),0
		FROM GESTION_DE_PATOS.Clientes
	INSERT INTO GESTION_DE_PATOS.Usuarios
		SELECT username, dbo.SHA256(username),'Proveedor',dbo.idEstadoUsuario('Habilitado'),0
		FROM GESTION_DE_PATOS.Proveedores		
	INSERT INTO GESTION_DE_PATOS.Usuarios
		SELECT username, dbo.SHA256(username),'Administrador',dbo.idEstadoUsuario('Habilitado'),0
		FROM GESTION_DE_PATOS.Administradores
		WHERE username != 'admin'
	
	
	--Cargas
		INSERT	INTO GESTION_DE_PATOS.Cargas (username, monto, tipo, tarjeta, fecha) 
				SELECT Cli_Dni, Carga_Credito, (select id_pago from GESTION_DE_PATOS.Tipos_pago where descripcion = Tipo_Pago_Desc),null, Carga_Fecha FROM gd_esquema.Maestra WHERE Carga_Credito is not null


	--Giftcards

		INSERT INTO GESTION_DE_PATOS.Giftcards (cliente_origen, cliente_destino, fecha, monto)
		SELECT Cli_Dni, Cli_Dest_Dni, GiftCard_Fecha, GiftCard_Monto FROM gd_esquema.Maestra WHERE Cli_Dest_Dni is not null


	--GRUPOS
		
		INSERT	INTO GESTION_DE_PATOS.Promociones (id_promocion, proveedor,precio_ficticio,fecha_publicacion,stock,limite_por_usuario, precio_real, fecha_vencimiento_canje, estado, fecha_vencimiento_oferta, descripcion)
				SELECT distinct Groupon_Codigo, Provee_CUIT, Groupon_Precio_Ficticio, Groupon_Fecha, Groupon_Cantidad, null, Groupon_Precio, Groupon_Fecha_Venc, 'Publicado', null, Groupon_Descripcion
				FROM gd_esquema.Maestra 
				WHERE Groupon_Codigo is not null
	
	--LOCALIDAD POR GRUPO
	INSERT	INTO GESTION_DE_PATOS.Localidad_por_promocion
			SELECT distinct dbo.idCiudad(Provee_Ciudad), Groupon_Codigo
			FROM gd_esquema.Maestra
			WHERE Groupon_Codigo is not null
			
			
	--Cupones
		INSERT INTO GESTION_DE_PATOS.Cupones (cliente, id_promocion,fecha_compra,estado)
		
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
		INSERT INTO GESTION_DE_PATOS.Cupones (cliente, id_promocion,fecha_compra,estado, fecha_canje)
		
			SELECT Cli_Dni, Groupon_Codigo,Groupon_Fecha_Compra,'Entregado' , Groupon_Entregado_Fecha
			FROM gd_esquema.Maestra
			WHERE Groupon_Codigo is not null AND Groupon_Devolucion_Fecha is null AND Factura_Nro is null AND Groupon_Entregado_Fecha is not null

	
	--Devoluciones 
		INSERT INTO GESTION_DE_PATOS.Cupones (cliente, id_promocion,fecha_compra,estado)
			SELECT Cli_Dni, Groupon_Codigo,Groupon_Fecha_Compra,'Devuelto'
			FROM gd_esquema.Maestra
			WHERE Groupon_Codigo is not null AND Groupon_Devolucion_Fecha is not null AND Factura_Nro is null AND Groupon_Entregado_Fecha is null
		
		INSERT INTO GESTION_DE_PATOS.Devoluciones (id_cupon,fecha_devolucion)
			SELECT DISTINCT c.id_cupon, Groupon_Devolucion_Fecha
			FROM gd_esquema.Maestra m	JOIN GESTION_DE_PATOS.Cupones c ON m.Cli_Dni = c.cliente AND Groupon_Codigo = c.id_promocion
							AND m.Groupon_Fecha_Compra = c.fecha_compra AND m.Groupon_Devolucion_Fecha is not null


	--GESTION_DE_PATOS.Facturas
		INSERT INTO GESTION_DE_PATOS.Facturas (id_factura,proveedor, monto, fecha_desde,fecha_hasta)
			SELECT Factura_Nro,Provee_CUIT, SUM(Groupon_Precio_Ficticio) monto, Factura_Fecha, Factura_Fecha
			FROM gd_esquema.Maestra
			WHERE Factura_Nro is not null
			GROUP BY Factura_Nro, Provee_CUIT, Factura_Fecha

END
GO

CREATE PROCEDURE AsignarSaldoInicial
AS
	BEGIN
		UPDATE GESTION_DE_PATOS.Clientes
		set saldo = saldo + 10
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
		update GESTION_DE_PATOS.Clientes set id_dir = SCOPE_IDENTITY() where username = @cliente
		fetch direcciones into @dir, @cliente
	end
	close direcciones
	deallocate direcciones
END
GO


/*
	=============================================
			    Ejecución de Migración
	=============================================
*/

begin tran
exec CargarDatosBase
exec MigrarDatos
exec AsignarSaldoInicial
exec AsignarDireccion
commit tran

/*
	=============================================
			Borrado de Func. de Migración
	=============================================
*/

DROP PROCEDURE AsignarSaldoInicial
DROP PROCEDURE CargarDatosBase
DROP PROCEDURE MigrarDatos
DROP PROCEDURE AsignarDireccion