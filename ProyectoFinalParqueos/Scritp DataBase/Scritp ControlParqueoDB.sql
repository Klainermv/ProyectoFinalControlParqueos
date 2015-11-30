Create database ControlParqueosDB; /-- Klainer Morales

Create table Usuarios(
	UsuarioId int identity(1,1) primary key,
	NombreUsuario varchar(200),
	Contrasena varchar(200),
	area varchar(30),
	Activo int
)

Create table Clientes(
	ClienteId int identity(1,1) primary key,
	Nombres varchar(150),
	Apellidos varchar(150),
	Cedula varchar(13),
	Telefono varchar(12),
	FechaIngreso DateTime,
	UsuarioId int foreign key references Usuarios (UsuarioId)
)

Create table Vehiculos(
	VehiculoId int identity(1,1) primary key,
	Placa varchar(30),
	MarcaId int foreign key references Marcas (MarcaId),
	Modelo int foreign key references Modelos (ModeloId),
	AnioFabricacion int,
	ClienteId int foreign key references Clientes (ClienteId),
)
Create table Marcas(
	MarcaId int identity(1,1) primary key,
	Descripcion varchar(100)
)

Create table Modelos(
	ModeloId int identity(1,1) primary key,
	Descripcion varchar(100)
)


Create table Contratos(
	ContratoId int identity(1,1) primary key,
	FechaVencimiento DateTime,
	Tarifa float,
	ParqueoId int foreign key references Parqueos(ParqueoId),
	ClienteId int foreign key references Clientes (ClienteId),
	VehiculoId int foreign key references Vehiculos (VehiculoId),
	Activo bit
)

Create table Parqueos(
	ParqueoId int identity(1,1) primary key,
	Disponible bit,
)

Create table Cobros(
	CobroId int identity(1,1) primary key,
	Fecha DateTime,
	Monto float,
)

Create table CobrosDetalle(
	CobroDetalleId int identity(1,1) primary key,
CobroId int foreign key references Cobros (CobroId),
ClienteId int foreign key references Clientes (ClienteId),
	Total float
)
