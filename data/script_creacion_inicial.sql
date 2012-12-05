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
AUTHORIZATION [gd]
FROM 0x4D5A90000300000004000000FFFF0000B800000000000000400000000000000000000000000000000000000000000000000000000000000000000000800000000E1FBA0E00B409CD21B8014CCD21546869732070726F6772616D2063616E6E6F742062652072756E20696E20444F53206D6F64652E0D0D0A2400000000000000504500004C0103004DEA86500000000000000000E00002210B0108000006000000060000000000004E240000002000000040000000004000002000000002000004000000000000000400000000000000008000000002000000000000030040850000100000100000000010000010000000000000100000000000000000000000002400004B000000004000009802000000000000000000000000000000000000006000000C00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000200000080000000000000000000000082000004800000000000000000000002E7465787400000054040000002000000006000000020000000000000000000000000000200000602E7273726300000098020000004000000004000000080000000000000000000000000000400000402E72656C6F6300000C0000000060000000020000000C0000000000000000000000000000400000420000000000000000000000000000000030240000000000004800000002000500842000007C0300000100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000133002001E0000000100001100730400000A0A060F00280500000A6F0600000A730700000A0B2B00072A1E02280800000A2A000042534A4201000100000000000C00000076322E302E35303732370000000005006C0000003C010000237E0000A80100005C01000023537472696E6773000000000403000008000000235553000C0300001000000023475549440000001C0300006000000023426C6F620000000000000002000001471502000900000000FA0133001600000100000008000000020000000200000001000000080000000300000001000000010000000200000000000A0001000000000006002A0023000A0052003D000A005B003D000600970077000600B70077000A00F000D50006002201050106004001050100000000010000000000010001000100100014000000050001000100502000000000960065000A0001007A200000000086186C001100020000000100720021006C00150029006C00110031006C00110039006C001100190030011F0041004E01240011006C002B0009006C00110020001B001A002E000B0038002E001300410031000480000000000000000000000000000000001400000002000000000000000000000001001A000000000002000000000000000000000001003100000000000000003C4D6F64756C653E0043727970742E646C6C004372797074006D73636F726C69620053797374656D004F626A6563740053797374656D2E446174610053797374656D2E446174612E53716C54797065730053716C42797465730053716C537472696E6700536861323536002E63746F7200746578740053797374656D2E52756E74696D652E436F6D70696C6572536572766963657300436F6D70696C6174696F6E52656C61786174696F6E734174747269627574650052756E74696D65436F6D7061746962696C697479417474726962757465004D6963726F736F66742E53716C5365727665722E5365727665720053716C46756E6374696F6E4174747269627574650053797374656D2E53656375726974792E43727970746F677261706879005348413235364D616E6167656400476574556E69636F646542797465730048617368416C676F726974686D00436F6D7075746548617368000000000320000000000091BDAFF685156942AFC88746F9CBE80A0008B77A5C561934E0890600011209110D03200001042001010804010000000420001D050620011D051D05052001011D05060702122112090801000800000000001E01000100540216577261704E6F6E457863657074696F6E5468726F7773012824000000000000000000003E240000002000000000000000000000000000000000000000000000302400000000000000005F436F72446C6C4D61696E006D73636F7265652E646C6C0000000000FF25002040000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001001000000018000080000000000000000000000000000001000100000030000080000000000000000000000000000001000000000048000000584000003C02000000000000000000003C0234000000560053005F00560045005200530049004F004E005F0049004E0046004F0000000000BD04EFFE00000100000000000000000000000000000000003F000000000000000400000002000000000000000000000000000000440000000100560061007200460069006C00650049006E0066006F00000000002400040000005400720061006E0073006C006100740069006F006E00000000000000B0049C010000010053007400720069006E006700460069006C00650049006E0066006F0000007801000001003000300030003000300034006200300000002C0002000100460069006C0065004400650073006300720069007000740069006F006E000000000020000000300008000100460069006C006500560065007200730069006F006E000000000030002E0030002E0030002E003000000034000A00010049006E007400650072006E0061006C004E0061006D0065000000430072007900700074002E0064006C006C0000002800020001004C006500670061006C0043006F0070007900720069006700680074000000200000003C000A0001004F0072006900670069006E0061006C00460069006C0065006E0061006D0065000000430072007900700074002E0064006C006C000000340008000100500072006F006400750063007400560065007200730069006F006E00000030002E0030002E0030002E003000000038000800010041007300730065006D0062006C0079002000560065007200730069006F006E00000030002E0030002E0030002E003000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002000000C000000503400000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
WITH PERMISSION_SET = SAFE
GO


/*
	=============================================
					    Tablas
	=============================================
*/
CREATE SCHEMA GESTION_DE_PATOS AUTHORIZATION gd

	CREATE TABLE Administradores ( 
		username varchar(30) primary key ,
		nombre varchar(30),
		apellido varchar(30),
	)

	CREATE TABLE Localidades(
		id_localidad int identity(1,1) primary key,
		localidad varchar(30)
	)


	CREATE TABLE Localidad_por_usuario(
		id_localidad int references Localidades(id_localidad),
		username varchar(30) references Usuarios(username)
	)


	CREATE TABLE Clientes ( 
		username varchar(30) primary key ,
		nombre varchar(30),
		apellido varchar(30),
		dni bigint,
		fecha_nacimiento datetime,
		mail varchar(30),
		telefono bigint unique,
		direccion varchar(100),
		codigo_postal int,		
		ciudad int references Localidades(id_localidad),
		saldo float
	)

	CREATE TABLE Rubros ( 
		id_rubro bigint primary key identity(1,1),
		descripcion varchar(30)
	)

	CREATE TABLE Proveedores ( 
		username varchar(30) primary key ,
		cuit nvarchar(20) unique,
		razon_social varchar(30),
		mail varchar(30),
		telefono bigint unique,
		direccion varchar(100),
		codigo_postal int,
		ciudad int references Localidades(id_localidad),
		id_rubro bigint references Rubros (id_rubro),
		nombre_contacto varchar(30)
	)

	CREATE TABLE Tipos_pago ( 
		id_pago int identity(1,1) primary key,
		descripcion varchar(30)
	)

	CREATE TABLE Tarjetas ( 
		numero bigint primary key,
		username varchar(30) references Clientes(username),
		tipo int references Tipos_Pago(id_pago)
	)

	CREATE TABLE Cargas ( 
		id_carga bigint identity(1,1) primary key,
		username varchar(30) references Clientes(username),
		monto bigint,
		tipo int references Tipos_pago (id_pago),
		tarjeta bigint references Tarjetas(numero),
		fecha datetime
	)

	CREATE TABLE Promociones ( 
		id_promocion varchar(30) primary key,
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


	CREATE TABLE Localidad_por_promocion(
		id_localidad int references Localidades(id_localidad),
		id_promocion varchar(30) references Promociones(id_promocion)
	)

	CREATE TABLE Cupones ( 
		id_cupon bigint identity(1,1) primary key,
		cliente varchar(30) references Clientes(username),
		id_promocion varchar(30) references Promociones(id_promocion),
		fecha_compra datetime,	
	)

	CREATE TABLE Devoluciones ( 
		id_cupon bigint primary key references Cupones(id_cupon),
		fecha_devolucion datetime,
		motivo varchar(250)
	)

	CREATE TABLE Canjes (
		id_cupon bigint primary key references Cupones(id_cupon),
		fecha_canje datetime
	)

	CREATE TABLE Estados ( 
		id_estado int identity(1,1) primary key,
		nombre_estado varchar(20)
	)

	CREATE TABLE Facturas ( 
		id_factura bigint primary key,
		proveedor varchar(30) references Proveedores(username),
		monto float,
		fecha_desde datetime,
		fecha_hasta datetime
	)

	CREATE TABLE Funcionalidades ( 
		id_funcionalidad int identity(1,1) primary key,
		descripcion varchar(50)
	)

	CREATE TABLE Roles ( 
		nombre varchar(30) primary key,
		estado int references Estados(id_estado)
	)

	CREATE TABLE Funcion_por_rol ( 
		id_funcionalidad int NOT NULL references Funcionalidades(id_funcionalidad),
		nombre_rol varchar(30) NOT NULL references Roles(nombre)
	)

	CREATE TABLE Giftcards ( 
		id_giftcard bigint identity(1,1) primary key,
		cliente_origen varchar(30) references Clientes(username),
		cliente_destino varchar(30) references Clientes(username),
		fecha datetime,
		monto bigint
	)

	CREATE TABLE Usuarios ( 
		username varchar(30) primary key,
		passwd varchar(50),
		rol varchar(30),
		estado int references Estados(id_estado),
		intentos_fallidos int
	)
GO
/*
	=============================================
			  Funciones y Procedimientos
	=============================================
*/

CREATE FUNCTION GESTION_DE_PATOS.SHA256(@text nchar(50))
RETURNS VARBINARY(256) AS 
EXTERNAL NAME Crypt.Crypt.Sha256
GO


CREATE FUNCTION GESTION_DE_PATOS.idCiudad(@ciudad varchar(30))
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

CREATE FUNCTION GESTION_DE_PATOS.promocion(@id_promocion varchar(30))
RETURNS varchar(250)
AS
BEGIN
	DECLARE @descripcion varchar(250)
	SELECT @descripcion = descripcion
	FROM GESTION_DE_PATOS.Promociones
	WHERE @id_promocion = id_promocion
	RETURN @descripcion
END

GO

CREATE FUNCTION GESTION_DE_PATOS.rubro(@id_rubro bigint)
RETURNS varchar(30)
AS
BEGIN
	DECLARE @descripcion varchar(30)
	SELECT @descripcion = descripcion
	FROM GESTION_DE_PATOS.Rubros
	WHERE @id_rubro = id_rubro
	RETURN @descripcion
END

GO

CREATE FUNCTION GESTION_DE_PATOS.localidad(@id_localidad int)
RETURNS varchar(30)
AS
BEGIN
	DECLARE @localidad varchar(30)
	SELECT @localidad = localidad
	FROM GESTION_DE_PATOS.Localidades
	WHERE @id_localidad = id_localidad
	RETURN @localidad
END

GO

CREATE FUNCTION GESTION_DE_PATOS.idRubro(@rubro varchar(30))
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

CREATE FUNCTION GESTION_DE_PATOS.idEstado(@estado varchar(30))
RETURNS int
AS
BEGIN
	DECLARE @id int
	SELECT @id = id_estado
	FROM GESTION_DE_PATOS.Estados
	WHERE nombre_estado = @estado
	RETURN @id
END
GO

CREATE PROCEDURE GESTION_DE_PATOS.PedirDevolucion(@idcupon int ,@username varchar(30),@fecha_actual datetime,@motivo varchar(250),@ret int output)
AS
BEGIN

/*
	0: ok
	1: user y cupon no matchean
	3: el cupon expiro
	4: el cupon esta devuelto o canjeado
*/	
	if not exists (select * from GESTION_DE_PATOS.Cupones where cliente = @username and id_cupon = @idcupon)
		begin
			 set @ret = 1
			 return
		end
	
	if exists (select * from GESTION_DE_PATOS.Canjes where id_cupon = @idcupon) or exists (select * from GESTION_DE_PATOS.Devoluciones where id_cupon = @idcupon)
		begin
			set @ret = 4
			return
		end
	
	If (select g.fecha_vencimiento_canje from GESTION_DE_PATOS.Promociones g join GESTION_DE_PATOS.Cupones c on c.id_promocion= g.id_promocion where c.id_cupon=@idcupon)< @fecha_actual
	begin
		--si llega aca es porque expiro el cupon
		set @ret = 3
		return
	end
	set @ret = 0

END
GO

CREATE PROCEDURE GESTION_DE_PATOS.ConfirmarDevolucion(@idcupon int,@fecha_actual datetime,@motivo varchar(250), @ret int output)
AS
BEGIN
/*
	0: ok
	1: ya se devolvio el cupon
	
*/
		if exists(select * from GESTION_DE_PATOS.Devoluciones where id_cupon = @idcupon)
		begin
			set @ret = 1
			return
		end		
		
		insert into GESTION_DE_PATOS.Devoluciones values(@idcupon,@fecha_actual,@motivo)
		set @ret = 0
		return
END

GO

CREATE PROCEDURE GESTION_DE_PATOS.Loguearse (@user varchar(30), @pass varchar(30), @ret int output)

/*
	0: ok
	1: error login
	2: inhabilitacion
	3: no existe usuario
	4: usuario inhabilitado
	5: usuario dado de baja
*/
AS
BEGIN
	
	if exists (select * from GESTION_DE_PATOS.Usuarios where username = @user)
	begin
		if(select estado from GESTION_DE_PATOS.Usuarios where username = @user) = GESTION_DE_PATOS.idEstado('Deshabilitado')
		begin
			set @ret = 4
			return
		end
		if (select r.estado from GESTION_DE_PATOS.Usuarios LEFT JOIN GESTION_DE_PATOS.Roles r ON rol = r.nombre where username = @user ) != (select id_estado from GESTION_DE_PATOS.Estados where nombre_estado = 'Habilitado')
		begin
			set @ret = 4
			return
		end
		if(select estado from GESTION_DE_PATOS.Usuarios where username = @user) = GESTION_DE_PATOS.idEstado('Eliminado')
		begin
			set @ret = 5
			return
		end
     IF(Select 1 from GESTION_DE_PATOS.Usuarios Where username= @user AND passwd=GESTION_DE_PATOS.SHA256( @pass) )is NULL
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
              Update GESTION_DE_PATOS.Usuarios set intentos_fallidos = 0 Where username = @user
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

CREATE PROCEDURE GESTION_DE_PATOS.ComprarGiftcard(@fecha datetime,@monto bigint,@clienteOrigen varchar(30),@clienteDestino varchar(30), @ret int output)
AS
BEGIN
/*
	0: ok
	1: cliente origen = cliente destino
	2: cliente destino no habilitado
	3: cliente destino no existe
	4: cliente origen no tiene saldo suficiente
*/	

	if not exists( select * from GESTION_DE_PATOS.Clientes where username = @clienteDestino)
	begin
		set @ret = 3
		return
	end
	IF(@clienteOrigen<>@clienteDestino)
		BEGIN
			IF(select saldo from GESTION_DE_PATOS.Clientes where username = @clienteOrigen) < @monto
			begin
				set @ret = 4
				return
			end
			IF (select estado from GESTION_DE_PATOS.Usuarios where username=@clienteDestino) = GESTION_DE_PATOS.idEstado('Habilitado')
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

CREATE PROCEDURE GESTION_DE_PATOS.CargarCredito(@username varchar(30),@fecha datetime,@tipoPago varchar(30),@monto bigint,@numeroTarjeta bigint, @ret int output)
AS
BEGIN

/*
	0: ok
	1: monto < $15
	2: tarjeta incorrecta
	3: cliente incorrecto
	4: cliente no habilitado para la carga
*/
	if not exists(select * from GESTION_DE_PATOS.Clientes where username = @username)
	begin
		set @ret = 3
		return
	end
	
	if(select GESTION_DE_PATOS.NombreEstado(estado) from GESTION_DE_PATOS.Usuarios where username = @username) <> 'Habilitado' 
	begin
		set @ret = 4
		return
	end
	
	IF (@monto>15)
	BEGIN --ver si me tengo que fijar que exista la tarjeta o agregarla
		declare @tipo int
		select @tipo = id_pago from GESTION_DE_PATOS.Tipos_pago where descripcion = @tipoPago
		
		if @tipo in (2,3)
		begin
			--validacion tarjeta
			if not exists (select * from GESTION_DE_PATOS.Tarjetas where username = @username and tipo = @tipo)
				begin
					insert into GESTION_DE_PATOS.Tarjetas (numero,username,tipo) values (@numeroTarjeta, @username, @tipo)
				end
			else
				begin
					if (select numero from GESTION_DE_PATOS.Tarjetas where username = @username and tipo = @tipo) != @numeroTarjeta
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

CREATE PROCEDURE GESTION_DE_PATOS.ArmarCupon (	@codigoGrupo varchar(30), @descripcion varchar(250), @fechaSistema datetime, 
								@fechaVencimientoCanje datetime, @fechaVencimientoOferta datetime,
								@precio_ficticio float, @precio_real float, @limite_usuario int, @stock bigint,
								@proveedor varchar(30), @ret int output)
AS
BEGIN

/*
	0: ok
	1: grupo ya existe
	2: la fecha de vencimiento de la oferta ya paso...
	3: vencimiento ofert > vencimiento canje
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

if @fechaVencimientoOferta > @fechaVencimientoCanje
	begin
		set @ret = 3
		return
	end

insert into GESTION_DE_PATOS.Promociones values(	@codigoGrupo, @proveedor, @precio_ficticio, null, @stock, @limite_usuario, @precio_real,
								@fechaVencimientoCanje, 'A publicar', @fechaVencimientoOferta, @descripcion)

set @ret = 0
return
END
GO

CREATE PROCEDURE GESTION_DE_PATOS.AsignarLocalidadAlGrupo(@localidad varchar(30), @grupo varchar(30), @ret int output)
AS
BEGIN
	INSERT INTO GESTION_DE_PATOS.Localidad_por_promocion VALUES (GESTION_DE_PATOS.idCiudad(@localidad),@grupo)
	set @ret = 0
	
END

GO

CREATE PROCEDURE GESTION_DE_PATOS.AltaRol (@nombre varchar(50),@ret int output)
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

CREATE PROCEDURE GESTION_DE_PATOS.AsignarFuncionalidadAlRol (@id int, @rol varchar(50), @ret int output)
AS
BEGIN
	insert into GESTION_DE_PATOS.Funcion_por_rol values(@id,@rol)
	set @ret = 0
END
GO

CREATE PROCEDURE GESTION_DE_PATOS.CambiarRolCliente(@user varchar(30),@nombre varchar(30), @apellido varchar(30), @mail varchar(30),
@tel bigint, @fecha datetime, @dni bigint,@direccion varchar(100), @ciudad varchar(50), @cp int, @ret int output) 
/*
	0: ok
	2: hay clientes gemelos
	
*/
AS
BEGIN
		
		if exists(select * from GESTION_DE_PATOS.Clientes where username = @user)
		begin
		declare @ret2 int
		exec GESTION_DE_PATOS.ModificarCliente @user, @nombre, @apellido, @mail, @tel, @fecha, @dni, @direccion, @cp, @ciudad, 'Habilitado', @ret2
		set @ret = 0
		return
		end
		If not exists(select * from GESTION_DE_PATOS.Clientes where dni = @dni or telefono = @tel)
				 and not exists (select * from GESTION_DE_PATOS.Proveedores where telefono = @tel or mail = @mail)
		BEGIN
			insert into GESTION_DE_PATOS.Clientes values (@user,@nombre,@apellido,@dni,@fecha,@mail,@tel,@direccion,@cp,GESTION_DE_PATOS.idCiudad(@ciudad),10)
			set @ret = 0
			return
		END
		ELSE
		BEGIN
			set @ret = 2
			return
		END
	
	END	
		

GO

CREATE PROCEDURE GESTION_DE_PATOS.CambiarRolProveedor(@user varchar(30),@cuit nvarchar(20),@razon_social varchar(30),@mail varchar(30),
@telefono bigint,@direccion varchar(100), @codigo_postal int, @ciudad varchar(30), @rubro varchar(30), @nombre_contacto varchar(30), @ret int output) 
AS
BEGIN
/*
	0: todo bien
	2: datos duplicados
*/
		if exists (select * FROM GESTION_DE_PATOS.Proveedores where username = @user)
		begin
			DECLARE @ret2 int
			exec GESTION_DE_PATOS.ModificarProveedor @user, @cuit, @razon_social, @mail, @telefono, @direccion,@codigo_postal, @ciudad, @rubro, @nombre_contacto, 'Habilitado', @ret2
			set @ret = 0
			return
		end
		
		IF NOT EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Proveedores WHERE razon_social = @razon_social OR telefono = @telefono
								OR mail = @mail OR cuit = @cuit) AND NOT EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Clientes 
								WHERE telefono = @telefono OR mail = @mail)
		BEGIN
			INSERT INTO GESTION_DE_PATOS.Proveedores VALUES(@user,@cuit,@razon_social,@mail,@telefono,@direccion,@codigo_postal,GESTION_DE_PATOS.idCiudad(@ciudad),GESTION_DE_PATOS.idRubro(@rubro),@nombre_contacto)
			set @ret = 0
			return
		END
		ELSE
		BEGIN
			set @ret = 2
			return
		END
			
	END


GO


CREATE PROCEDURE GESTION_DE_PATOS.EliminarFuncionalidadesDeRol(@nombre_rol varchar(30))
AS
BEGIN
	DELETE FROM GESTION_DE_PATOS.Funcion_por_rol WHERE nombre_rol = @nombre_rol
END
GO

CREATE PROCEDURE GESTION_DE_PATOS.EstablecerEstadoDelRol(@nombre_rol varchar(30), @estado int)
AS
BEGIN
	IF( @estado = (select id_estado from GESTION_DE_PATOS.Estados where nombre_estado = 'Eliminado'))
	BEGIN
		EXEC GESTION_DE_PATOS.EliminarFuncionalidadesDeRol @nombre_rol
	END
	
	UPDATE GESTION_DE_PATOS.Roles SET estado = @estado  WHERE nombre = @nombre_rol
END
GO

CREATE FUNCTION GESTION_DE_PATOS.FuncionalidadesDelRol(@nombre_rol varchar(30)) RETURNS TABLE
AS
RETURN 
(
	SELECT f.id_funcionalidad, f.descripcion, (SELECT 1 FROM GESTION_DE_PATOS.Funcion_por_rol fpr WHERE fpr.id_funcionalidad = f.id_funcionalidad AND fpr.nombre_rol = @nombre_rol) AS permitido FROM GESTION_DE_PATOS.Funcionalidades f
)
GO

CREATE PROCEDURE GESTION_DE_PATOS.PublicarCupon(@codigoPromocion varchar(30), @fecha datetime)
AS
BEGIN
update GESTION_DE_PATOS.Promociones set estado = 'Publicado', fecha_publicacion = @fecha where id_promocion = @codigoPromocion
END

GO

CREATE PROCEDURE GESTION_DE_PATOS.ComprarCupon(@id_promocion varchar(30),@fecha datetime,@username varchar(30),@ret int output)
AS
BEGIN
/*
ret:
	NroCupon: ok
	1: la cantidad deseada supera el limite por usuario
	2: la cantidad deseada supera el stock disponible
	3: el usuario no tiene saldo suficiente

cupon: 	codigo del cupon a informar
*/
	IF (select limite_por_usuario from GESTION_DE_PATOS.Promociones where id_promocion = @id_promocion) > 
		(select COUNT(*) from GESTION_DE_PATOS.Promociones gc join GESTION_DE_PATOS.Cupones c on c.id_promocion = gc.id_promocion and gc.id_promocion = @id_promocion
			where c.cliente = @username) - (select COUNT(*) from GESTION_DE_PATOS.Promociones p 
											join GESTION_DE_PATOS.Cupones c on c.id_promocion = p.id_promocion
											and p.id_promocion = @id_promocion
											join GESTION_DE_PATOS.Devoluciones d on d.id_cupon = c.id_cupon)
	BEGIN
		IF (select stock from GESTION_DE_PATOS.Promociones where id_promocion= @id_promocion)> 0
		BEGIN
			declare @precio_real float
			select @precio_real = precio_real from GESTION_DE_PATOS.Promociones where id_promocion=@id_promocion
			IF (select saldo from GESTION_DE_PATOS.Clientes where username=@username) >= @precio_real
				BEGIN			
					insert into GESTION_DE_PATOS.Cupones values(@username,@id_promocion,@fecha)
					set @ret = SCOPE_IDENTITY()
					return
				END	
			else
				begin
					set @ret = 3
					return
				end		
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

CREATE PROCEDURE GESTION_DE_PATOS.RegistroCliente(@user varchar(30), @pass varchar(30),@nombre varchar(50),
@apellido varchar(50),@mail varchar(50), @tel bigint, @fecha datetime,
@dni bigint, @direccion varchar(100), @ciudad varchar(50), @cp int, @ret int output)
AS
BEGIN

/*
	0: ok
	1: ya existe el usuario
	2: datos duplicados (telefono, dni o mail que son únicos)
	
*/
	IF not exists(Select 1 from GESTION_DE_PATOS.Usuarios where username= @user)
		BEGIN
			If not exists(select * from GESTION_DE_PATOS.Clientes where dni = @dni or telefono = @tel)
				 and not exists (select * from GESTION_DE_PATOS.Proveedores where telefono = @tel or mail = @mail)
				BEGIN
						insert into GESTION_DE_PATOS.Usuarios values(@user,GESTION_DE_PATOS.SHA256(@pass),'Cliente', GESTION_DE_PATOS.idEstado('Habilitado') ,0)
						insert into GESTION_DE_PATOS.Clientes values (@user,@nombre,@apellido,@dni,@fecha,@mail,@tel,@direccion,@cp,GESTION_DE_PATOS.idCiudad(@ciudad),10)
						SET @ret = 0
						return
				END
			else
				begin
					set @ret = 2
					return
				end
		END
	ELSE
		BEGIN
			set @ret = 1 
		END
END

GO

CREATE PROCEDURE GESTION_DE_PATOS.RegistrarLocalidades(@localidad varchar(50), @user varchar(30))
AS
BEGIN
	insert into GESTION_DE_PATOS.Localidad_por_usuario values(GESTION_DE_PATOS.idCiudad(@localidad),@user)
END

GO

CREATE PROCEDURE GESTION_DE_PATOS.RegistrarProveedor(@user varchar(30), @pass varchar(30), @rs varchar(30), 
													 @cuit varchar(30),@mail varchar(30), @telefono bigint, 
													 @direccion varchar(100), @ciudad varchar(30), @rubro varchar(30),
													 @contacto varchar(30), @cp int, @ret int output)
AS
BEGIN
		
/*
	0: ok
	1: ya existe el usuario
	2: datos duplicados (telefono, razoón social, mail o cuit que son únicos)

*/
	IF not exists(Select 1 from GESTION_DE_PATOS.Usuarios where username= @user)
		BEGIN
			If not exists(select * from GESTION_DE_PATOS.Proveedores where razon_social = @rs or telefono = @telefono
							or mail = @mail or cuit = @cuit) and not exists(select * from GESTION_DE_PATOS.Clientes 
							where telefono = @telefono or mail = @mail)
				BEGIN
						insert into GESTION_DE_PATOS.Usuarios values(@user,GESTION_DE_PATOS.SHA256(@pass),'Proveedor', GESTION_DE_PATOS.idEstado('Habilitado') ,0)
						insert into GESTION_DE_PATOS.Proveedores values (@user,@cuit,@rs,@mail,@telefono,@direccion,@cp,GESTION_DE_PATOS.idCiudad(@ciudad)
																		, GESTION_DE_PATOS.idRubro(@rubro), @contacto)
						SET @ret = 0
						return
				END
			else
				begin
					set @ret = 2
					return
				end
		END
	ELSE
		BEGIN
			set @ret = 1 
		END


END

GO

CREATE PROCEDURE GESTION_DE_PATOS.CambiarPassword (@user varchar(30), @passVieja varchar(30), @passNueva varchar(30),
												   @passNueva2 varchar(30), @ret int output)
AS
BEGIN
	/*
		0: ok
		1: passVieja incorrecta
		2: passN y passN2 no coinciden
	*/
	if not exists (select * from GESTION_DE_PATOS.Usuarios where username = @user and passwd = GESTION_DE_PATOS.SHA256(@passVieja))
	begin
		set @ret = 1
		return
	end
	
	if @passNueva != @passNueva2
	begin
		set @ret = 2
		return
	end
	
	update GESTION_DE_PATOS.Usuarios set passwd = GESTION_DE_PATOS.SHA256(@passNueva) where username = @user
	set @ret = 0
	return
END

GO

CREATE PROCEDURE GESTION_DE_PATOS.CambiarPasswordDesdeAdmin (@user varchar(30), @passNueva varchar(50),
												   @passNueva2 varchar(50), @ret int output)
AS
BEGIN
	/*
		0: ok
		1: passN y passN2 no coinciden
	*/
	
	IF @passNueva != @passNueva2
	BEGIN
		set @ret = 1
		RETURN
	END
	
	UPDATE GESTION_DE_PATOS.Usuarios SET passwd = GESTION_DE_PATOS.SHA256(@passNueva) where username = @user
	set @ret = 0
	RETURN
END

GO

CREATE PROCEDURE GESTION_DE_PATOS.ConsumoCupon(@idcupon int,@username varchar(30),@fecha_actual datetime, @proveedor varchar(30), @ret int output)
AS
BEGIN
/*
	0: ok
	1: user y cupon no matchean
	2: proveedor y cupon no matchean
	3: se vencio el canje
	5: el cupon esta devuelto o ya canjeado
*/
	IF not exists(select * from GESTION_DE_PATOS.Cupones where id_cupon = @idcupon and cliente = @username)
		begin
			set @ret = 1
			return
		end
		
	IF (select g.proveedor from GESTION_DE_PATOS.Promociones g join GESTION_DE_PATOS.Cupones c on g.id_promocion = c.id_promocion and c.id_cupon=@idcupon)!= @proveedor
		begin
			set @ret = 2
			return
		end
	

	IF exists(select * from GESTION_DE_PATOS.Devoluciones where id_cupon = @idcupon) or exists(
		select * from GESTION_DE_PATOS.Canjes where id_cupon = @idcupon)
	BEGIN
		set @ret = 5
		return
	END
	
	IF (select g.fecha_vencimiento_canje from GESTION_DE_PATOS.Promociones g join GESTION_DE_PATOS.Cupones c on g.id_promocion = c.id_promocion and c.id_cupon=@idcupon) >= @fecha_actual
	begin
		insert into GESTION_DE_PATOS.Canjes values (@idcupon,@fecha_actual)
		set @ret = 0
		return
	end
		
	set @ret = 3
	return
	
END

GO
--CREAR ADMINISTRADOR
CREATE PROCEDURE GESTION_DE_PATOS.AltaAdministrador(@user varchar(30),@pass varchar(30),@nombre varchar(30), @apellido varchar(30), @ret int output) 
/*
	0: ok
	1: el user ya existe
*/
AS
BEGIN
	IF (NOT EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Usuarios WHERE username = @user ))
	BEGIN
	
		INSERT INTO GESTION_DE_PATOS.Usuarios VALUES(@user,GESTION_DE_PATOS.SHA256(@pass),'Administrador', GESTION_DE_PATOS.idEstado('Habilitado') ,0)
		insert into GESTION_DE_PATOS.Administradores values (@user,@nombre,@apellido)
		set @ret = 0
		return
	END	
	
	set @ret = 1
	return
	
END

GO


--CREAR CLIENTE
CREATE PROCEDURE GESTION_DE_PATOS.AltaCliente(@user varchar(30),@pass varchar(30),@nombre varchar(30), @apellido varchar(30), @mail varchar(30),
@tel bigint, @fecha datetime, @dni bigint,@direccion varchar(100), @ciudad varchar(50), @cp int, @ret int output) 
/*
	0: ok
	1: el user ya existe
	2: hay clientes gemelos
	
*/
AS
BEGIN
	IF (NOT EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Usuarios WHERE username = @user ))
	BEGIN
	
		If not exists(select * from GESTION_DE_PATOS.Clientes where dni = @dni or telefono = @tel or mail = @mail)
				 and not exists (select * from GESTION_DE_PATOS.Proveedores where telefono = @tel or mail = @mail)
		BEGIN
			INSERT INTO GESTION_DE_PATOS.Usuarios VALUES(@user,GESTION_DE_PATOS.SHA256(@pass),'Cliente', GESTION_DE_PATOS.idEstado('Habilitado') ,0)
			insert into GESTION_DE_PATOS.Clientes values (@user,@nombre,@apellido,@dni,@fecha,@mail,@tel,@direccion,@cp,GESTION_DE_PATOS.idCiudad(@ciudad),10)
			set @ret = 0
			return
		END
		ELSE
		BEGIN
			set @ret = 2
			return
		END
	
	END	
	ELSE	
	BEGIN
		set @ret = 1
		return
	END
		
END

go

--MODIFICAR CLIENTE
CREATE PROCEDURE GESTION_DE_PATOS.ModificarCliente(@user varchar(30),@nombre varchar(30), @apellido varchar(30), @mail varchar(30),
@tel bigint, @fecha datetime, @dni bigint,@direccion varchar(100), @codigo_postal int, @ciudad varchar(30), @estado varchar(20), @ret int output) 

/*
0:salio ok
1:el cliente a modificar no existe
2:existe un cliente gemelo
*/
AS
BEGIN
	IF EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Usuarios WHERE username = @user)
	BEGIN
		IF (NOT EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Clientes WHERE (dni = @dni OR telefono = @tel or mail = @mail) AND @user <> username)
				 AND NOT EXISTS (SELECT 1 FROM GESTION_DE_PATOS.Proveedores WHERE (telefono = @tel OR mail = @mail) AND @user <> username) )
		BEGIN		 
			UPDATE GESTION_DE_PATOS.Clientes SET nombre = @nombre, 
												 apellido = @apellido,
												 dni = @dni,
												 fecha_nacimiento = @fecha,
												 mail = @mail,
												 telefono = @tel,
												 direccion = @direccion,
												 codigo_postal = @codigo_postal,											 
												 ciudad = GESTION_DE_PATOS.idCiudad(@ciudad)
												 
											 WHERE username = @user
											 
			IF (@estado='Habilitado' OR @estado = 'Deshabilitado') 
			BEGIN
				UPDATE GESTION_DE_PATOS.Usuarios SET estado = GESTION_DE_PATOS.idEstado(@estado) WHERE username = @user
			END						 
			
			set @ret = 0								 
		END
		ELSE
		BEGIN
			set @ret = 2
		END
							 
	END
	ELSE
	BEGIN
		 set @ret = 1
	END
END
GO

--ELIMINAR CLIENTE
CREATE PROCEDURE GESTION_DE_PATOS.EliminarUsuario(@user varchar(30), @ret int output)
AS
BEGIN
	IF EXISTS(SELECT * FROM GESTION_DE_PATOS.Usuarios WHERE username = @user)
	BEGIN
		
		if(select estado from GESTION_DE_PATOS.Usuarios where username = @user) = GESTION_DE_PATOS.idEstado('Eliminado')
		begin
			set @ret = 2
			return
			-- el usuario ya esta eliminado
		end
		
		UPDATE GESTION_DE_PATOS.Usuarios SET estado = GESTION_DE_PATOS.idEstado('Eliminado')
										 WHERE username = @user
		
		set @ret = 0
		return
		--Usuario eliminado								 
	END
	
	set @ret = 1
	return
	--El usuario no existe
END

GO

--ELIMINAR LOCALIDADES
CREATE PROCEDURE GESTION_DE_PATOS.EliminarLocalidades (@user varchar(30))
AS
BEGIN
	delete from GESTION_DE_PATOS.Localidad_por_usuario where username = @user
	
END

GO

--CREAR PROVEEDOR
CREATE PROCEDURE GESTION_DE_PATOS.AltaProveedor(@user varchar(30),@pass varchar(50),@cuit nvarchar(20),@razon_social varchar(30),@mail varchar(30),
@telefono bigint,@direccion varchar(100), @codigo_postal int, @ciudad varchar(30), @rubro varchar(30), @nombre_contacto varchar(30), @ret int output) 
AS
BEGIN
	IF NOT EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Usuarios WHERE username = @user)
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Proveedores WHERE razon_social = @razon_social OR telefono = @telefono
								OR mail = @mail OR cuit = @cuit) AND NOT EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Clientes 
								WHERE telefono = @telefono OR mail = @mail)
		BEGIN
			INSERT INTO GESTION_DE_PATOS.Usuarios VALUES(@user,GESTION_DE_PATOS.SHA256(@pass),'Proveedor', GESTION_DE_PATOS.idEstado('Habilitado') ,0)
			INSERT INTO GESTION_DE_PATOS.Proveedores VALUES(@user,@cuit,@razon_social,@mail,@telefono,@direccion,@codigo_postal,GESTION_DE_PATOS.idCiudad(@ciudad),GESTION_DE_PATOS.idRubro(@rubro),@nombre_contacto)
			
			set @ret = 0
			return
		END
		ELSE
		BEGIN
			set @ret = 2
			return
		END
			
	END
	ELSE
	BEGIN
		set @ret = 1
		return
	END

END

GO

--MODFICAR PROVEEDOR
CREATE PROCEDURE GESTION_DE_PATOS.ModificarProveedor(@user varchar(30),@cuit nvarchar(20),@razon_social varchar(30),@mail varchar(30),
@telefono bigint,@direccion varchar(100),@codigo_postal int,@ciudad varchar(30),@rubro varchar(30),@nombre_contacto varchar(30), @estado varchar(20), @ret int output) 
AS
BEGIN

	IF EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Proveedores WHERE username = @user)
	BEGIN
		IF NOT EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Proveedores WHERE (razon_social = @razon_social OR telefono = @telefono
							OR cuit = @cuit OR mail = @mail) AND username <> @user) AND NOT EXISTS(SELECT 1 FROM GESTION_DE_PATOS.Clientes 
							where (telefono = @telefono OR mail = @mail) AND username <> @user)
		BEGIN
			UPDATE GESTION_DE_PATOS.Proveedores SET cuit=@cuit,
													razon_social = @razon_social,
													mail = @mail,
													telefono = @telefono,
													direccion = @direccion,
													codigo_postal = @codigo_postal,
													ciudad = GESTION_DE_PATOS.idCiudad(@ciudad),
													id_rubro = GESTION_DE_PATOS.idRubro(@rubro),
													nombre_contacto = @nombre_contacto
												WHERE username = @user
						
			IF (@estado='Habilitado' OR @estado = 'Deshabilitado') 
			BEGIN
				UPDATE GESTION_DE_PATOS.Usuarios SET estado= GESTION_DE_PATOS.idEstado(@estado) WHERE username = @user
			END	
					
			set @ret = 0
		END
		ELSE
		BEGIN
			set @ret = 2
		END
	END
	ELSE
	BEGIN
		set @ret = 1
	END
END

GO


CREATE PROCEDURE GESTION_DE_PATOS.FacturarProveedor (@proveedor varchar(30), @fecha_desde datetime, @fecha_hasta datetime, @monto float,@ret int output)
AS
BEGIN
/*
	idfactura: ok
	1: se overlapean los intervalos --> cupones ya facturados
*/
	if exists (select * from GESTION_DE_PATOS.Facturas where proveedor = @proveedor and 
	(	@fecha_desde between fecha_desde and fecha_hasta or @fecha_hasta between fecha_desde and fecha_hasta
		or fecha_desde between @fecha_desde and @fecha_hasta or fecha_hasta between @fecha_desde and @fecha_hasta))
		begin
			set @ret = 1
			return
		end
	
	select @ret = MAX(id_factura)+1 from GESTION_DE_PATOS.Facturas
	insert into GESTION_DE_PATOS.Facturas values(@ret, @proveedor, @monto, @fecha_desde, @fecha_hasta)
	
	return
	
	
END	
GO

-- Funciones de TOP 5
CREATE FUNCTION GESTION_DE_PATOS.top_giftcards(@fecha_inicio DATETIME, @fecha_fin DATETIME)
RETURNS TABLE
AS RETURN	(SELECT TOP(5) u.username, c.nombre, c.apellido, COUNT(gift.id_giftcard) AS cantidad_giftcards FROM GESTION_DE_PATOS.Usuarios u
			LEFT JOIN GESTION_DE_PATOS.Clientes c ON u.username = c.username
			LEFT JOIN GESTION_DE_PATOS.Giftcards gift ON  gift.cliente_destino = c.username
			WHERE gift.fecha BETWEEN @fecha_inicio AND @fecha_fin
			GROUP BY u.username, c.nombre, c.apellido
			ORDER BY COUNT(gift.id_giftcard) DESC)
GO

CREATE FUNCTION GESTION_DE_PATOS.top_devoluciones(@fecha_inicio DATETIME, @fecha_fin DATETIME)
RETURNS TABLE
AS RETURN
SELECT TOP(5) p.username, p.razon_social, COUNT(d.id_cupon)*100/(
	SELECT COUNT(c.id_cupon)
	FROM GESTION_DE_PATOS.Proveedores prov
	LEFT JOIN GESTION_DE_PATOS.Promociones prom ON prom.proveedor = prov.username
	LEFT JOIN GESTION_DE_PATOS.Cupones c ON c.id_promocion = prom.id_promocion
	WHERE prov.username = p.username AND c.fecha_compra BETWEEN @fecha_inicio AND @fecha_fin
) AS porcentaje_devueltos
FROM GESTION_DE_PATOS.Proveedores p
LEFT JOIN GESTION_DE_PATOS.Promociones prom ON prom.proveedor = p.username
LEFT JOIN GESTION_DE_PATOS.Cupones c ON c.id_promocion = prom.id_promocion
LEFT JOIN GESTION_DE_PATOS.Devoluciones d ON d.id_cupon = c.id_cupon
WHERE c.fecha_compra BETWEEN @fecha_inicio AND @fecha_fin
GROUP BY p.username, p.razon_social
ORDER BY COUNT(d.id_cupon)*100/(
	SELECT COUNT(c.id_cupon)
	FROM GESTION_DE_PATOS.Proveedores prov
	LEFT JOIN GESTION_DE_PATOS.Promociones prom ON prom.proveedor = prov.username
	LEFT JOIN GESTION_DE_PATOS.Cupones c ON c.id_promocion = prom.id_promocion
	WHERE prov.username = p.username AND c.fecha_compra BETWEEN @fecha_inicio AND @fecha_fin

) DESC
GO

CREATE FUNCTION GESTION_DE_PATOS.NombreEstado(@id int)
RETURNS VARCHAR(30)
AS
BEGIN
	RETURN (SELECT nombre_estado FROM GESTION_DE_PATOS.Estados where id_estado = @id)
END

GO

/*
	=============================================
					   TRIGGERS 
	=============================================
*/

CREATE TRIGGER GESTION_DE_PATOS.actualizarSaldoCargas
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

CREATE TRIGGER GESTION_DE_PATOS.actualizarSaldoCupones
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

CREATE TRIGGER GESTION_DE_PATOS.actualizarSaldoDevoluciones
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

CREATE TRIGGER GESTION_DE_PATOS.actualizarSaldoGiftcards
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

CREATE TRIGGER GESTION_DE_PATOS.actualizarStockCupones
ON GESTION_DE_PATOS.Cupones
AFTER INSERT
AS
BEGIN
	UPDATE GESTION_DE_PATOS.Promociones
	SET stock = stock - (select count(*) from inserted where inserted.id_promocion = gc.id_promocion)
	FROM inserted i join GESTION_DE_PATOS.Promociones gc on i.id_promocion = gc.id_promocion
	
END

GO


CREATE TRIGGER GESTION_DE_PATOS.actualizarStockDevoluciones
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

/*
	=============================================
					   VISTAS 
	=============================================
*/


CREATE VIEW GESTION_DE_PATOS.viewadministradores AS
SELECT a.username, a.nombre, a.apellido, GESTION_DE_PATOS.NombreEstado(u.estado) AS 'estado'
FROM GESTION_DE_PATOS.Administradores a JOIN GESTION_DE_PATOS.Usuarios u ON a.username = u.username

GO


CREATE VIEW GESTION_DE_PATOS.viewroles AS
SELECT nombre, GESTION_DE_PATOS.NombreEstado(estado) estado
FROM GESTION_DE_PATOS.Roles

GO

CREATE VIEW GESTION_DE_PATOS.viewclientes AS
SELECT c.username, c.nombre, c.apellido, c.dni, CASE WHEN c.mail is not null THEN c.mail ELSE '-' END AS 'mail', GESTION_DE_PATOS.NombreEstado(u.estado) AS 'estado'
FROM GESTION_DE_PATOS.Clientes c JOIN GESTION_DE_PATOS.Usuarios u ON c.username = u.username
WHERE u.rol = 'Cliente'

GO

CREATE VIEW GESTION_DE_PATOS.viewproveedores AS
SELECT p.username, p.razon_social, p.cuit, GESTION_DE_PATOS.rubro(p.id_rubro) AS 'rubro', CASE WHEN p.mail is not null THEN p.mail ELSE '-' END AS 'mail', CASE WHEN p.nombre_contacto is not null THEN p.nombre_contacto ELSE '-' END AS 'nombre_contacto', GESTION_DE_PATOS.NombreEstado(u.estado) AS 'estado' 
FROM GESTION_DE_PATOS.Proveedores p JOIN GESTION_DE_PATOS.Usuarios u ON p.username = u.username
WHERE u.rol = 'Proveedor'

GO

CREATE VIEW GESTION_DE_PATOS.viewcupones AS
SELECT c.id_cupon AS 'id_cupon', c.cliente AS 'cliente', GESTION_DE_PATOS.promocion(id_promocion) AS 'promocion', c.fecha_compra AS 'fecha_compra', 
CASE WHEN (fecha_devolucion is null AND fecha_canje is null) THEN 'Comprado'
	 WHEN (fecha_devolucion is null AND fecha_canje is not null) THEN 'Canjeado'
ELSE 'Devuelto' END AS 'estado'
FROM GESTION_DE_PATOS.Cupones c LEFT JOIN GESTION_DE_PATOS.Devoluciones d ON c.id_cupon = d.id_cupon
	 LEFT JOIN GESTION_DE_PATOS.Canjes cj ON c.id_cupon = cj.id_cupon
	 	 
GO

/*
	=============================================
		    Procedimientos de Migración
	=============================================
*/

CREATE PROCEDURE GESTION_DE_PATOS.CargarDatosBase
AS
BEGIN
		/*PARTE DE LA MIGRACION A MANO*/
		--Estados

		insert into GESTION_DE_PATOS.Estados(nombre_estado) values('Habilitado')
		insert into GESTION_DE_PATOS.Estados(nombre_estado) values('Deshabilitado')
		insert into GESTION_DE_PATOS.Estados(nombre_estado) values('Eliminado')

		--Tipo de pago

		insert into GESTION_DE_PATOS.Tipos_pago (descripcion) values ('Efectivo')
		insert into GESTION_DE_PATOS.Tipos_pago (descripcion) values ('Crédito')
		insert into GESTION_DE_PATOS.Tipos_pago (descripcion) values ('Débito')

		--Administrador 

		insert into GESTION_DE_PATOS.Usuarios values('admin',GESTION_DE_PATOS.SHA256('w23e'),'Administrador General',1,0)
		insert into GESTION_DE_PATOS.Administradores values('admin', 'Eurulio','Korsovich')
		
		
		--Funcionalidades

		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('ABM Rol')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('ABM Clientes')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('ABM Proveedores')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('Carga de credito')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('Comprar Giftcard')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('Comprar Cupon')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('Pedir Devolucion')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('Historial de Compra de Cupones')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('Armar Cupon')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('Registro de consumo de cupon')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('Publicar Cupon')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('Facturacion a Proveedor')
		insert into GESTION_DE_PATOS.Funcionalidades (descripcion) values('Listado estadistico')

		--Roles

		insert into GESTION_DE_PATOS.Roles values ('Administrador General', GESTION_DE_PATOS.idEstado('Habilitado'))
		insert into GESTION_DE_PATOS.Roles values ('Administrador',GESTION_DE_PATOS.idEstado('Habilitado'))
		insert into GESTION_DE_PATOS.Roles values ('Cliente',GESTION_DE_PATOS.idEstado('Habilitado'))
		insert into GESTION_DE_PATOS.Roles values ('Proveedor',GESTION_DE_PATOS.idEstado('Habilitado'))

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
		insert into GESTION_DE_PATOS.Funcion_por_rol values (1,'Administrador')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (2,'Administrador')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (3,'Administrador')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (4,'Administrador')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (4,'Cliente')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (5,'Cliente')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (6,'Cliente')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (7,'Cliente')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (8,'Cliente')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (9,'Proveedor')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (10,'Proveedor')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (11,'Administrador')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (12,'Administrador')
		insert into GESTION_DE_PATOS.Funcion_por_rol values (13,'Administrador')

END
GO

CREATE PROCEDURE GESTION_DE_PATOS.MigrarDatos
AS
BEGIN

	
	--Localidades
	INSERT INTO GESTION_DE_PATOS.Localidades (localidad)
		SELECT DISTINCT Cli_Ciudad 
		FROM gd_esquema.Maestra
		WHERE Cli_Ciudad is not null

	--Clientes
	INSERT INTO GESTION_DE_PATOS.Clientes 
		select distinct convert(varchar(30),Cli_Dni), Cli_Nombre, Cli_Apellido, Cli_Dni, Cli_Fecha_Nac, Cli_Mail, Cli_Telefono, Cli_Direccion, null, GESTION_DE_PATOS.idCiudad(Cli_Ciudad), 0 
		from gd_esquema.Maestra where Cli_Dni is not null
	
	--Rubros
	insert into GESTION_DE_PATOS.Rubros (descripcion) select distinct provee_rubro from gd_esquema.Maestra where Provee_CUIT is not null

	--Proveedores
	INSERT INTO GESTION_DE_PATOS.Proveedores
		select distinct convert(varchar(30),Provee_CUIT), Provee_CUIT, Provee_RS, null , Provee_Telefono, Provee_Dom, null, GESTION_DE_PATOS.idCiudad(Provee_Ciudad), GESTION_DE_PATOS.idRubro(Provee_Rubro), null
		from gd_esquema.Maestra where Provee_CUIT is not null

	--Usuarios
	INSERT INTO GESTION_DE_PATOS.Usuarios
		SELECT username,GESTION_DE_PATOS.SHA256(username),'Cliente',GESTION_DE_PATOS.idEstado('Habilitado'),0
		FROM GESTION_DE_PATOS.Clientes
	INSERT INTO GESTION_DE_PATOS.Usuarios
		SELECT username, GESTION_DE_PATOS.SHA256(username),'Proveedor',GESTION_DE_PATOS.idEstado('Habilitado'),0
		FROM GESTION_DE_PATOS.Proveedores		
	INSERT INTO GESTION_DE_PATOS.Usuarios
		SELECT username, GESTION_DE_PATOS.SHA256(username),'Administrador',GESTION_DE_PATOS.idEstado('Habilitado'),0
		FROM GESTION_DE_PATOS.Administradores
		WHERE username != 'admin'

	
	--LOCALIDAD POR USUARIO
	INSERT INTO GESTION_DE_PATOS.Localidad_por_usuario 
		SELECT DISTINCT  GESTION_DE_PATOS.idCiudad(Cli_Ciudad),Cli_Dni
		FROM gd_esquema.Maestra
		WHERE Cli_Dni is not null
	
	--Cargas
		INSERT	INTO GESTION_DE_PATOS.Cargas (username, monto, tipo, tarjeta, fecha) 
				SELECT Cli_Dni, Carga_Credito, (select id_pago from GESTION_DE_PATOS.Tipos_pago where descripcion = Tipo_Pago_Desc),null, Carga_Fecha FROM gd_esquema.Maestra WHERE Carga_Credito is not null


	--Giftcards

		INSERT INTO GESTION_DE_PATOS.Giftcards (cliente_origen, cliente_destino, fecha, monto)
		SELECT Cli_Dni, Cli_Dest_Dni, GiftCard_Fecha, GiftCard_Monto FROM gd_esquema.Maestra WHERE Cli_Dest_Dni is not null


	--PROMOCIONES
		
		INSERT	INTO GESTION_DE_PATOS.Promociones (id_promocion, proveedor,precio_ficticio,fecha_publicacion,stock,limite_por_usuario, precio_real, fecha_vencimiento_canje, estado, fecha_vencimiento_oferta, descripcion)
				SELECT distinct Groupon_Codigo, Provee_CUIT, Groupon_Precio_Ficticio, Groupon_Fecha, Groupon_Cantidad, null, Groupon_Precio, null, 'Publicado', Groupon_Fecha_Venc, Groupon_Descripcion
				FROM gd_esquema.Maestra 
				WHERE Groupon_Codigo is not null
	
	--LOCALIDAD POR PROMOCION
	INSERT	INTO GESTION_DE_PATOS.Localidad_por_promocion
			SELECT distinct GESTION_DE_PATOS.idCiudad(Provee_Ciudad), Groupon_Codigo
			FROM gd_esquema.Maestra
			WHERE Groupon_Codigo is not null
			
			
	--Cupones
		INSERT INTO GESTION_DE_PATOS.Cupones (cliente, id_promocion,fecha_compra)
		
			SELECT Cli_Dni, Groupon_Codigo,Groupon_Fecha_Compra
			FROM gd_esquema.Maestra
			WHERE Groupon_Codigo is not null AND Groupon_Devolucion_Fecha is null AND Factura_Nro is null AND Groupon_Entregado_Fecha is null
			
	
	--CANJES
		INSERT INTO GESTION_DE_PATOS.Canjes (id_cupon,fecha_canje)
			SELECT DISTINCT c.id_cupon, Groupon_Entregado_Fecha
			FROM gd_esquema.Maestra m	JOIN GESTION_DE_PATOS.Cupones c ON m.Cli_Dni = c.cliente AND Groupon_Codigo = c.id_promocion
							AND m.Groupon_Fecha_Compra = c.fecha_compra AND m.Groupon_Entregado_Fecha is not null

	
	--DEVOLUCIONES 
		
		INSERT INTO GESTION_DE_PATOS.Devoluciones (id_cupon,fecha_devolucion)
			SELECT DISTINCT c.id_cupon, Groupon_Devolucion_Fecha
			FROM gd_esquema.Maestra m	JOIN GESTION_DE_PATOS.Cupones c ON m.Cli_Dni = c.cliente AND Groupon_Codigo = c.id_promocion
							AND m.Groupon_Fecha_Compra = c.fecha_compra AND m.Groupon_Devolucion_Fecha is not null


	--Facturas
		INSERT INTO GESTION_DE_PATOS.Facturas (id_factura,proveedor, monto, fecha_desde,fecha_hasta)
			SELECT Factura_Nro,Provee_CUIT, SUM(Groupon_Precio_Ficticio) monto, Factura_Fecha, Factura_Fecha
			FROM gd_esquema.Maestra
			WHERE Factura_Nro is not null
			GROUP BY Factura_Nro, Provee_CUIT, Factura_Fecha

END
GO

CREATE PROCEDURE GESTION_DE_PATOS.AsignarSaldoInicial
AS
	BEGIN
		UPDATE GESTION_DE_PATOS.Clientes
		set saldo = saldo + 10
	END
GO




/*
	=============================================
			    Ejecución de Migración
	=============================================
*/

begin tran
exec GESTION_DE_PATOS.CargarDatosBase
exec GESTION_DE_PATOS.MigrarDatos
exec GESTION_DE_PATOS.AsignarSaldoInicial

go

ALTER TABLE GESTION_DE_PATOS.Clientes
ADD FOREIGN KEY (username)
REFERENCES GESTION_DE_PATOS.Usuarios(username)

go

ALTER TABLE GESTION_DE_PATOS.Proveedores
ADD FOREIGN KEY (username)
REFERENCES GESTION_DE_PATOS.Usuarios(username)

go

ALTER TABLE GESTION_DE_PATOS.Administradores
ADD FOREIGN KEY (username)
REFERENCES GESTION_DE_PATOS.Usuarios(username)


insert into GESTION_DE_PATOS.Clientes values('admin', 'Eurulio','Korsovich',null,null,null,null,null,null,null,0)
insert into GESTION_DE_PATOS.Proveedores values('admin', '00-00000000-00',null,null,null,null,null,null,null,null)

		
commit tran

/*
	=============================================
			Borrado de Func. de Migración
	=============================================
*/

DROP PROCEDURE GESTION_DE_PATOS.AsignarSaldoInicial
DROP PROCEDURE GESTION_DE_PATOS.CargarDatosBase
DROP PROCEDURE GESTION_DE_PATOS.MigrarDatos
