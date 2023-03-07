create database Laboratorio_clinico;
Go
use Laboratorio_clinico;
Go

create table Pacientes(
Id_Paciente int primary key identity(1,1),
Nombre_Paciente nvarchar(50) not null,
Apellido_Paciente nvarchar(50) not null,
Dni_Paciente nvarchar(50) not null,
Fecha_Nacimiento date not null,
Direccion_Paciente nvarchar(250) null,
Telefono_Paciente nvarchar(8) null,
Genero nvarchar(50) not null,
Fecha_Registro datetime default getdate(),
Fecha_Actualizacion datetime default getdate()
);

create table Empleados(
	Id_Empleado int primary key identity(1,1),
	Nombre_Empleado nvarchar(50) not null,
	Apellido_Empleado nvarchar(50) not null,
	Dni_Empleado nvarchar(50) not null,
	Fecha_Nacimiento date not null,
	Direccion_Empleado nvarchar(250) null,
	Telefono_Empleado nvarchar(8) null,
	Genero nvarchar(50) not null,
	Fecha_Registro datetime default getdate(),
	Fecha_Actualizacion datetime default getdate()
);


CREATE TABLE Analisis (
  Id_Analisis INT PRIMARY KEY identity(1,1),
  Nombre_Analisis VARCHAR(255),
  Estatus_Analisis BIT,
  Fecha_Registro datetime default getdate(),
  Fecha_Actualizacion datetime default getdate()
);


CREATE TABLE Roles (
  Id_Rol INT PRIMARY KEY identity(1,1),
  Nombre_Rol VARCHAR(255),
  Fecha_Registro datetime default getdate(),
  Fecha_Actualizacion datetime default getdate()
);

create table Permisos(
	Id_Permiso int primary key identity(1,1),
	Permiso nvarchar(50),
	Fecha_Registro datetime default getdate(),
	Fecha_Actualizacion datetime default getdate()
);

create table Roles_Permisos(
	Id_Permiso int ,
	Id_Rol int,
	Fecha_Registro datetime default getdate(),
	Fecha_Actualizacion datetime default getdate()
	primary key(Id_Permiso,Id_Rol),
	FOREIGN KEY (Id_Rol) REFERENCES Roles (Id_Rol),
	FOREIGN KEY (Id_Permiso) REFERENCES Permisos (Id_Permiso)
);

CREATE TABLE Usuarios (
  id_usuario INT PRIMARY KEY identity(1,1),
  Nombre_Us VARCHAR(255),
  Dni_Us nvarchar(30),
  Contrasenia_Us varbinary(8000),
  Estatus_Us BIT,
  Correo_Us VARCHAR(255),
  Intentos_Us int,
  Pin_Recuperacion nvarchar(6),
  Fecha_Gen_Pin datetime,
  Id_Rol INT,
  Fecha_Registro datetime default getdate(),
  Fecha_Actualizacion datetime default getdate()
  FOREIGN KEY (Id_Rol) REFERENCES Roles (Id_Rol)
);


CREATE TABLE Especialidades (
  Id_Especialidad INT PRIMARY KEY identity(1,1),
  Nombre_Esp VARCHAR(255),
  Fecha_Esp DATE,
  Estatus_Esp BIT,
  Fecha_Registro datetime default getdate(),
  Fecha_Actualizacion datetime default getdate()
);


CREATE TABLE Medicos (
  Id_Medico INT PRIMARY KEY identity(1,1),
  Nombres VARCHAR(255),
  Apellidos VARCHAR(255),
  Dni Varchar(30),
  Direccion VARCHAR(255),
  Telefono VARCHAR(255),
  Estatus_us bit,
  Fecha_Registro datetime default getdate(),
  Fecha_Actualizacion datetime default getdate()
);

create table Medicos_Especialidades(
	Id_Medico int,
	Id_Especialidad int,
	Fecha_Registro datetime default getdate(),
    Fecha_Actualizacion datetime default getdate()
	primary key(Id_Medico,Id_Especialidad),
	FOREIGN KEY (Id_Medico) REFERENCES Medicos (Id_Medico),
	FOREIGN KEY (Id_Especialidad) REFERENCES Especialidades (Id_Especialidad)
);

CREATE TABLE Examenes (
  Id_Examen INT PRIMARY KEY identity(1,1),
  Nombre_Exm VARCHAR(255),
  Fecha_Exm DATE,
  Estatus_Exm BIT,
  Id_analisis INT,
  Costo_Examen decimal(10,2),
  Fecha_Registro datetime default getdate(),
  Fecha_Actualizacion datetime default getdate()
  FOREIGN KEY (Id_analisis) REFERENCES Analisis (Id_analisis)
);




CREATE TABLE Examenes_Medicos(
  Id_Examen_Med INT PRIMARY KEY identity(1,1),
  Indicaciones_Examen VARCHAR(255),
  Nomindica_Examen VARCHAR(255),
  Fecha_Examen DATE,
  Estatus_Examen varchar(50) check(Estatus_Examen in('En Proceso','Finalizado','Cancelado')),
  Id_Usuario INT,
  Id_Paciente INT,
  Fecha_Registro datetime default getdate(),
  Fecha_Actualizacion datetime default getdate(),
  FOREIGN KEY (Id_usuario) REFERENCES Usuarios (Id_usuario),
  FOREIGN KEY (Id_Paciente) REFERENCES Pacientes (Id_Paciente)
);

CREATE TABLE Examenes_Medicos_Detalles (
  Id_Examen_Med_Detalle INT PRIMARY KEY identity(1,1),
  Id_Examen_Med INT,
  Id_Examen INT,
  Id_Analisis INT,
  Fecha_Registro datetime default getdate(),
  Fecha_Actualizacion datetime default getdate(),
  FOREIGN KEY (Id_Examen) REFERENCES Examenes (Id_Examen),
  FOREIGN KEY (Id_Analisis) REFERENCES Analisis (Id_Analisis),
  FOREIGN KEY (Id_Examen_Med) REFERENCES Examenes_Medicos (Id_Examen_Med)
);

CREATE TABLE Resultados_Examenes (
  Id_Resultado INT PRIMARY KEY identity(1,1),
  Fecha_Resultado DATE,
  Estatus_Resultado BIT,
  Id_Paciente INT,
  Id_usuario INT,
  Fecha_Registro datetime default getdate(),
  Fecha_Actualizacion datetime default getdate()
  FOREIGN KEY (Id_Paciente) REFERENCES Pacientes (Id_Paciente),
  FOREIGN KEY (Id_usuario) REFERENCES Usuarios (Id_usuario)
);

CREATE TABLE Resultados_Examenes_Detalles (
  Id_Resultado_detalle INT PRIMARY KEY identity(1,1),
  Id_Resultado INT,
  Archivo_Examen_Med VARCHAR(255),
  Id_Examen_Med_Detalle INT,
  Fecha_Registro datetime default getdate(),
  Fecha_Actualizacion datetime default getdate(),
  FOREIGN KEY (Id_Resultado) REFERENCES Resultados_Examenes (Id_resultado),
  FOREIGN KEY (Id_Examen_Med_Detalle) REFERENCES Examenes_Medicos_Detalles (Id_Examen_Med_Detalle)
);

create table Facturacion(
	Id_Facturacion int primary key identity(1,1),
	Fecha_Facturacion datetime not null,
	Id_Paciente int ,
	Id_Usuario int,
	Sub_Total decimal(10,2),
	ISV decimal(10,2),
	descuento decimal(10,2),
	Fecha_Registro datetime default getdate(),
	Fecha_Actualizacion datetime default getdate(),
	FOREIGN KEY (Id_usuario) REFERENCES Usuarios (Id_usuario),
	FOREIGN KEY (Id_Paciente) REFERENCES Pacientes (Id_Paciente)
);

create table Detalle_Facturacion(
	Id_Detalle_Fac int primary key identity(1,1),
	Id_Facturacion int,
	Id_Examen int,
	Cantidad int,
	Precio decimal,
	FOREIGN KEY (Id_Facturacion) REFERENCES Facturacion(Id_Facturacion),
	FOREIGN KEY (Id_Examen) REFERENCES Examenes (Id_Examen)
);


create table Productos(
	Id_Producto int primary key identity(1,1),
	Nombre_Producto nvarchar(50) not null unique,
	Nombre_Proveedor nvarchar(50),
	Cantidad_Stock int default 0,
	Cantidad_Minima int default 0,
	Precio_Producto float default 0,
	Fecha_Registro datetime default getdate(),
	Fecha_Actualizacion datetime default getdate()
);

create table Inventario(
	Id_Inventario int primary key identity(1,1),
	Id_Producto int,
	Precio_Compra float default 0,
	Fecha_Compra date,
	Numero_Seria nvarchar(50),
	Ubicacion_Almacenamiento nvarchar(250),
	Fecha_Registro datetime default getdate(),
	Fecha_Actualizacion datetime default getdate(),
	FOREIGN KEY (Id_Producto) REFERENCES Productos (Id_Producto)
);

create table Bitacora(
	Id_Bitacora int primary key identity,
	Fecha_Registro datetime ,
	Tipo_Evento nvarchar(200),
	Descripcion_Evento nvarchar(255),
	Id_Usuario int,
	FOREIGN KEY (Id_Usuario) REFERENCES Usuarios (Id_Usuario)
);

Go

insert into Roles(Nombre_rol) values ('Administrador'),('Medico'),('Recepcionista');
go

insert into Permisos(Permiso) values ('Acceso Total');
go

insert into Roles_Permisos(Id_Rol,Id_Permiso) values ((select Id_Rol from Roles where Nombre_rol = 'Administrador'),(select Id_Permiso from Permisos where Permiso = 'Acceso Total'));
go

insert into Empleados(
	Nombre_Empleado ,
	Apellido_Empleado, 
	Dni_Empleado,
	Fecha_Nacimiento, 
	Direccion_Empleado, 
	Telefono_Empleado ,
	Genero 
)values(
	'Luis Adolfo',
	'Flores',
	'0703200003793',
	'2000-06-07',
	'Residencial Vereda Real',
	'96362917',
	'Masculino'
);
go