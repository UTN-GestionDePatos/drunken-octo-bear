CREATE PROCEDURE MigrarDatos
AS
BEGIN

	/*MIGRACIONES MASIVAS*/
	
	--CLIENTES
	INSERT INTO Clientes 
		select distinct Cli_Dni, Cli_Nombre, Cli_Apellido, Cli_Mail, Cli_Telefono, null, Cli_Fecha_Nac, Cli_Dni,0 
		from Maestra where Cli_Dni is not null
	
	--PROVEEDORES
	INSERT INTO Proveedores
		select distinct Provee_CUIT, Provee_RS, null , Provee_Telefono, null, Provee_Ciudad, Provee_Rubro, null
		from Maestra where Provee_CUIT is not null
	
	--LOCALIDADES
	INSERT INTO Localidades (localidad)
		select distinct Cli_ciudad from Maestra where Cli_Dni is not null
	
	
	/*MIGRACION POR CURSOR*/
	
	DECLARE migrarCursor CURSOR FOR (SELECT * FROM Maestra)
	DECLARE @clienteNombre nvarchar(255), @clienteApellido nvarchar(255), @clienteDni numeric(18), 
			@clienteDireccion nvarchar(255), @clienteTelefono numeric(18), @clienteMail nvarchar(255),
			@clienteFechaNac datetime, @clienteCiudad nvarchar(255)
	DECLARE @cargaCredito numeric(18,2), @cargaFecha datetime, @tipoPago nvarchar(100)
	DECLARE @clienteDestNombre nvarchar(255), @clienteDestApellido nvarchar(255), @clienteDestDni numeric(18,0),
			@clienteDestDireccion nvarchar(255), @clienteDestTelefono numeric(18,0), @clienteDestMail nvarchar(255),
			@clienteDestFechaNac datetime, @clienteDestCiudad nvarchar(255)
	DECLARE @giftcardFecha datetime, @giftcardMonto numeric(18,2)
	DECLARE @proveedorRS nvarchar(100), @proveedorDireccion nvarchar(100), @proveedorCiudad nvarchar(255),
			@proveedorTelefono numeric(18,0), @proveedorCUIT nvarchar(20), @proveedorRubro nvarchar(100)
	DECLARE @grouponPrecio numeric(18,2), @grouponPrecioFicticio numeric(18,2), @grouponFecha datetime,
			@grouponFechaVencimiento datetime, @grouponCantidad numeric(18,0), @grouponDescripcion nvarchar(255),
			@grouponFechaCompra datetime, @grouponCodigo nvarchar(50), @grouponDevolucionFecha datetime,
			@grouponEntregadoFecha datetime
	DECLARE @facturaNro numeric(18,0), @facturaFecha datetime
	DECLARE @idCupon int
	
	OPEN migrarCursor
	
	FETCH migrarCursor INTO @clienteNombre, @clienteApellido, @clienteDni, @clienteDireccion, @clienteTelefono, @clienteMail,
							@clienteFechaNac, @clienteCiudad, @cargaCredito, @cargaFecha, @tipoPago, @clienteDestNombre,
							@clienteDestApellido, @clienteDestDni, @clienteDestDireccion, @clienteDestTelefono,
							@clienteDestMail, @clienteDestFechaNac, @clienteDestCiudad, @giftcardFecha, @giftcardMonto,
							@proveedorRS, @proveedorDireccion, @proveedorCiudad, @proveedorTelefono, @proveedorCUIT,
							@proveedorRubro, @grouponPrecio, @grouponPrecioFicticio, @grouponFecha, @grouponFechaVencimiento,
							@grouponCantidad, @grouponDescripcion, @grouponFechaCompra, @grouponCodigo, @grouponDevolucionFecha,
							@grouponEntregadoFechtime, @facturaNro, @facturaFecha
	
	WHILE @@FETCH_STATUS = 0
	
		BEGIN
		
		--ACA VAN LOS IFS PRINCIPALES QUE LLAMAN A LOS PROCEDURES
		IF @cargaCredito is not null 
			begin
			exec dbo.CargarCredito @clienteDni, @cargaCredito, @tipoPago, @cargaFecha
			goto fetcheaPapa
			end
		
		
		IF @clienteDestDni is not null
			begin
			exec dbo.ProcesarGitfcard @clienteDni, @clienteDestDni, @giftcardFecha, @giftcardMonto
			goto fetcheaPapa
			end
		
		
		IF @grouponCodigo is not null
			begin
			exec dbo.InsertarGrupo	@grouponCodigo, @proveedorCiudad, @proveedorCUIT, @grouponPrecioFicticio, @grouponFecha, @grouponCantidad,
									@grouponPrecio, @grouponFechaVencimiento, @grouponDescripcion
			end
		
		IF @grouponFechaCompra is not null AND @grouponEntregadoFecha is null AND @facturaNro is null 
			begin
			exec dbo.InsertarCupon @clienteDni, @grouponCodigo, @grouponFechaCompra, @grouponEntregadoFecha, @idCupon output
			goto fetcheaPapa
			end
			
		
		IF @grouponEntregadoFecha is not null
			begin
			exec dbo.ActualizarEntrega @idCupon, @grouponEntregadoFecha
			goto fetcheaPapa
			end
		
		IF @facturaNro is not null
			begin
			exec dbo.ProcesarFactura @facturaNro, @proveedorCUIT, @facturaFecha, @grouponPrecioFicticio
			goto fetcheaPapa
			end
		
		IF @grouponDevolucionFecha is not null
			begin
			exec dbo.ProcesarDevolucion @idCupon, @grouponDevolucionFecha
			goto fetcheaPapa
			end
			
		
			
		fetcheaPapa:
		FETCH migrarCursor INTO @clienteNombre, @clienteApellido, @clienteDni, @clienteDireccion, @clienteTelefono, @clienteMail,
							@clienteFechaNac, @clienteCiudad, @cargaCredito, @cargaFecha, @tipoPago, @clienteDestNombre,
							@clienteDestApellido, @clienteDestDni, @clienteDestDireccion, @clienteDestTelefono,
							@clienteDestMail, @clienteDestFechaNac, @clienteDestCiudad, @giftcardFecha, @giftcardMonto,
							@proveedorRS, @proveedorDireccion, @proveedorCiudad, @proveedorTelefono, @proveedorCUIT,
							@proveedorRubro, @grouponPrecio, @grouponPrecioFicticio, @grouponFecha, @grouponFechaVencimiento,
							@grouponCantidad, @grouponDescripcion, @grouponFechaCompra, @grouponCodigo, @grouponDevolucionFecha,
							@grouponEntregadoFechtime, @facturaNro, @facturaFecha
		
		END

		

END