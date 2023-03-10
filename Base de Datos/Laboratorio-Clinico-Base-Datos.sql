USE [master]
GO
/****** Object:  Database [Laboratorio_clinico]    Script Date: 12/3/2023 21:58:57 ******/
CREATE DATABASE [Laboratorio_clinico]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Laboratorio_clinico', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Laboratorio_clinico.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Laboratorio_clinico_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Laboratorio_clinico_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Laboratorio_clinico] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Laboratorio_clinico].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Laboratorio_clinico] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Laboratorio_clinico] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Laboratorio_clinico] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Laboratorio_clinico] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Laboratorio_clinico] SET ARITHABORT OFF 
GO
ALTER DATABASE [Laboratorio_clinico] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Laboratorio_clinico] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Laboratorio_clinico] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Laboratorio_clinico] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Laboratorio_clinico] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Laboratorio_clinico] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Laboratorio_clinico] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Laboratorio_clinico] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Laboratorio_clinico] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Laboratorio_clinico] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Laboratorio_clinico] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Laboratorio_clinico] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Laboratorio_clinico] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Laboratorio_clinico] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Laboratorio_clinico] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Laboratorio_clinico] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Laboratorio_clinico] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Laboratorio_clinico] SET RECOVERY FULL 
GO
ALTER DATABASE [Laboratorio_clinico] SET  MULTI_USER 
GO
ALTER DATABASE [Laboratorio_clinico] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Laboratorio_clinico] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Laboratorio_clinico] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Laboratorio_clinico] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Laboratorio_clinico] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Laboratorio_clinico] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Laboratorio_clinico', N'ON'
GO
ALTER DATABASE [Laboratorio_clinico] SET QUERY_STORE = ON
GO
ALTER DATABASE [Laboratorio_clinico] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Laboratorio_clinico]
GO
/****** Object:  Table [dbo].[Analisis]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Analisis](
	[Id_Analisis] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Analisis] [varchar](255) NULL,
	[Estatus_Analisis] [bit] NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Analisis] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[Id_Bitacora] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_Registro] [datetime] NULL,
	[Tipo_Evento] [nvarchar](200) NULL,
	[Descripcion_Evento] [nvarchar](255) NULL,
	[Id_Usuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Bitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Facturacion]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Facturacion](
	[Id_Detalle_Fac] [int] IDENTITY(1,1) NOT NULL,
	[Id_Facturacion] [int] NULL,
	[Id_Examen] [int] NULL,
	[Cantidad] [int] NULL,
	[Precio] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Detalle_Fac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Id_Empleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Empleado] [nvarchar](50) NOT NULL,
	[Apellido_Empleado] [nvarchar](50) NOT NULL,
	[Dni_Empleado] [nvarchar](50) NOT NULL,
	[Fecha_Nacimiento] [date] NOT NULL,
	[Direccion_Empleado] [nvarchar](250) NULL,
	[Telefono_Empleado] [nvarchar](8) NULL,
	[Estatus_Us] [bit] NULL,
	[Genero] [nvarchar](50) NOT NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidades]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidades](
	[Id_Especialidad] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Esp] [varchar](255) NULL,
	[Fecha_Esp] [date] NULL,
	[Estatus_Esp] [bit] NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Especialidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Examenes]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examenes](
	[Id_Examen] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Exm] [varchar](255) NULL,
	[Fecha_Exm] [date] NULL,
	[Estatus_Exm] [bit] NULL,
	[Id_analisis] [int] NULL,
	[Costo_Examen] [decimal](10, 2) NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Examen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Examenes_Medicos]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examenes_Medicos](
	[Id_Examen_Med] [int] IDENTITY(1,1) NOT NULL,
	[Indicaciones_Examen] [varchar](255) NULL,
	[Nomindica_Examen] [varchar](255) NULL,
	[Fecha_Examen] [date] NULL,
	[Estatus_Examen] [varchar](50) NULL,
	[Id_Usuario] [int] NULL,
	[Id_Paciente] [int] NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Examen_Med] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Examenes_Medicos_Detalles]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examenes_Medicos_Detalles](
	[Id_Examen_Med_Detalle] [int] IDENTITY(1,1) NOT NULL,
	[Id_Examen_Med] [int] NULL,
	[Id_Examen] [int] NULL,
	[Id_Analisis] [int] NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Examen_Med_Detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturacion]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturacion](
	[Id_Facturacion] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_Facturacion] [datetime] NOT NULL,
	[Id_Paciente] [int] NULL,
	[Id_Usuario] [int] NULL,
	[Sub_Total] [decimal](10, 2) NULL,
	[ISV] [decimal](10, 2) NULL,
	[descuento] [decimal](10, 2) NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Facturacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventario]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventario](
	[Id_Inventario] [int] IDENTITY(1,1) NOT NULL,
	[Id_Producto] [int] NULL,
	[Precio_Compra] [float] NULL,
	[Fecha_Compra] [date] NULL,
	[Numero_Seria] [nvarchar](50) NULL,
	[Ubicacion_Almacenamiento] [nvarchar](250) NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Inventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicos]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicos](
	[Id_Medico] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](255) NULL,
	[Apellidos] [varchar](255) NULL,
	[Dni] [varchar](30) NULL,
	[Fecha_Nacimiento] [date] NULL,
	[Direccion] [varchar](255) NULL,
	[Telefono] [varchar](255) NULL,
	[Estatus_us] [bit] NULL,
	[Genero] [nvarchar](50) NOT NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
 CONSTRAINT [PK__Medicos__7BA5D810FD844BEE] PRIMARY KEY CLUSTERED 
(
	[Id_Medico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicos_Especialidades]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicos_Especialidades](
	[Id_Medico] [int] NOT NULL,
	[Id_Especialidad] [int] NOT NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Medico] ASC,
	[Id_Especialidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[Id_Paciente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Paciente] [nvarchar](50) NOT NULL,
	[Apellido_Paciente] [nvarchar](50) NOT NULL,
	[Dni_Paciente] [nvarchar](50) NOT NULL,
	[Fecha_Nacimiento] [date] NOT NULL,
	[Direccion_Paciente] [nvarchar](250) NULL,
	[Telefono_Paciente] [nvarchar](8) NULL,
	[Genero] [nvarchar](50) NOT NULL,
	[Estatus_Us] [bit] NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Paciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[Id_Permiso] [int] IDENTITY(1,1) NOT NULL,
	[Permiso] [nvarchar](50) NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Producto] [nvarchar](50) NOT NULL,
	[Nombre_Proveedor] [nvarchar](50) NULL,
	[Cantidad_Stock] [int] NULL,
	[Cantidad_Minima] [int] NULL,
	[Precio_Producto] [float] NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Nombre_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Resultados_Examenes]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resultados_Examenes](
	[Id_Resultado] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_Resultado] [date] NULL,
	[Estatus_Resultado] [bit] NULL,
	[Id_Paciente] [int] NULL,
	[Id_usuario] [int] NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Resultado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Resultados_Examenes_Detalles]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resultados_Examenes_Detalles](
	[Id_Resultado_detalle] [int] IDENTITY(1,1) NOT NULL,
	[Id_Resultado] [int] NULL,
	[Archivo_Examen_Med] [varchar](255) NULL,
	[Id_Examen_Med_Detalle] [int] NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Resultado_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id_Rol] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Rol] [varchar](255) NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles_Permisos]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles_Permisos](
	[Id_Permiso] [int] NOT NULL,
	[Id_Rol] [int] NOT NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Permiso] ASC,
	[Id_Rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Us] [varchar](255) NULL,
	[Dni_Us] [nvarchar](30) NULL,
	[Contrasenia_Us] [varbinary](8000) NULL,
	[Estatus_Us] [bit] NULL,
	[Correo_Us] [varchar](255) NULL,
	[Intentos_Us] [int] NULL,
	[Pin_Recuperacion] [nvarchar](6) NULL,
	[Fecha_Gen_Pin] [datetime] NULL,
	[Id_Rol] [int] NULL,
	[Fecha_Bloqueo] [datetime] NULL,
	[Motivo_Bloqueo] [nvarchar](50) NULL,
	[Fecha_Desbloqueo] [datetime] NULL,
	[Descripcion_Bloqueo] [nvarchar](250) NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Analisis] ADD  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Analisis] ADD  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Empleados] ADD  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Empleados] ADD  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Especialidades] ADD  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Especialidades] ADD  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Examenes] ADD  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Examenes] ADD  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Examenes_Medicos] ADD  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Examenes_Medicos] ADD  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Examenes_Medicos_Detalles] ADD  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Examenes_Medicos_Detalles] ADD  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Facturacion] ADD  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Facturacion] ADD  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Inventario] ADD  DEFAULT ((0)) FOR [Precio_Compra]
GO
ALTER TABLE [dbo].[Inventario] ADD  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Inventario] ADD  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Medicos] ADD  CONSTRAINT [DF__Medicos__Fecha_R__5CD6CB2B]  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Medicos] ADD  CONSTRAINT [DF__Medicos__Fecha_A__5DCAEF64]  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Medicos_Especialidades] ADD  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Medicos_Especialidades] ADD  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Pacientes] ADD  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Pacientes] ADD  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Permisos] ADD  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Permisos] ADD  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Productos] ADD  DEFAULT ((0)) FOR [Cantidad_Stock]
GO
ALTER TABLE [dbo].[Productos] ADD  DEFAULT ((0)) FOR [Cantidad_Minima]
GO
ALTER TABLE [dbo].[Productos] ADD  DEFAULT ((0)) FOR [Precio_Producto]
GO
ALTER TABLE [dbo].[Productos] ADD  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Productos] ADD  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Resultados_Examenes] ADD  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Resultados_Examenes] ADD  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Resultados_Examenes_Detalles] ADD  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Resultados_Examenes_Detalles] ADD  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Roles] ADD  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Roles] ADD  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Roles_Permisos] ADD  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Roles_Permisos] ADD  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Usuarios] ADD  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Usuarios] ADD  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Detalle_Facturacion]  WITH CHECK ADD FOREIGN KEY([Id_Examen])
REFERENCES [dbo].[Examenes] ([Id_Examen])
GO
ALTER TABLE [dbo].[Detalle_Facturacion]  WITH CHECK ADD FOREIGN KEY([Id_Facturacion])
REFERENCES [dbo].[Facturacion] ([Id_Facturacion])
GO
ALTER TABLE [dbo].[Examenes]  WITH CHECK ADD FOREIGN KEY([Id_analisis])
REFERENCES [dbo].[Analisis] ([Id_Analisis])
GO
ALTER TABLE [dbo].[Examenes_Medicos]  WITH CHECK ADD FOREIGN KEY([Id_Paciente])
REFERENCES [dbo].[Pacientes] ([Id_Paciente])
GO
ALTER TABLE [dbo].[Examenes_Medicos]  WITH CHECK ADD FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Examenes_Medicos_Detalles]  WITH CHECK ADD FOREIGN KEY([Id_Analisis])
REFERENCES [dbo].[Analisis] ([Id_Analisis])
GO
ALTER TABLE [dbo].[Examenes_Medicos_Detalles]  WITH CHECK ADD FOREIGN KEY([Id_Examen])
REFERENCES [dbo].[Examenes] ([Id_Examen])
GO
ALTER TABLE [dbo].[Examenes_Medicos_Detalles]  WITH CHECK ADD FOREIGN KEY([Id_Examen_Med])
REFERENCES [dbo].[Examenes_Medicos] ([Id_Examen_Med])
GO
ALTER TABLE [dbo].[Facturacion]  WITH CHECK ADD FOREIGN KEY([Id_Paciente])
REFERENCES [dbo].[Pacientes] ([Id_Paciente])
GO
ALTER TABLE [dbo].[Facturacion]  WITH CHECK ADD FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD FOREIGN KEY([Id_Producto])
REFERENCES [dbo].[Productos] ([Id_Producto])
GO
ALTER TABLE [dbo].[Medicos_Especialidades]  WITH CHECK ADD FOREIGN KEY([Id_Especialidad])
REFERENCES [dbo].[Especialidades] ([Id_Especialidad])
GO
ALTER TABLE [dbo].[Medicos_Especialidades]  WITH CHECK ADD  CONSTRAINT [FK__Medicos_E__Id_Me__628FA481] FOREIGN KEY([Id_Medico])
REFERENCES [dbo].[Medicos] ([Id_Medico])
GO
ALTER TABLE [dbo].[Medicos_Especialidades] CHECK CONSTRAINT [FK__Medicos_E__Id_Me__628FA481]
GO
ALTER TABLE [dbo].[Resultados_Examenes]  WITH CHECK ADD FOREIGN KEY([Id_Paciente])
REFERENCES [dbo].[Pacientes] ([Id_Paciente])
GO
ALTER TABLE [dbo].[Resultados_Examenes]  WITH CHECK ADD FOREIGN KEY([Id_usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Resultados_Examenes_Detalles]  WITH CHECK ADD FOREIGN KEY([Id_Examen_Med_Detalle])
REFERENCES [dbo].[Examenes_Medicos_Detalles] ([Id_Examen_Med_Detalle])
GO
ALTER TABLE [dbo].[Resultados_Examenes_Detalles]  WITH CHECK ADD FOREIGN KEY([Id_Resultado])
REFERENCES [dbo].[Resultados_Examenes] ([Id_Resultado])
GO
ALTER TABLE [dbo].[Roles_Permisos]  WITH CHECK ADD FOREIGN KEY([Id_Permiso])
REFERENCES [dbo].[Permisos] ([Id_Permiso])
GO
ALTER TABLE [dbo].[Roles_Permisos]  WITH CHECK ADD FOREIGN KEY([Id_Rol])
REFERENCES [dbo].[Roles] ([Id_Rol])
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD FOREIGN KEY([Id_Rol])
REFERENCES [dbo].[Roles] ([Id_Rol])
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD CHECK  (([Genero]='Femenino' OR [Genero]='Masculino'))
GO
ALTER TABLE [dbo].[Examenes_Medicos]  WITH CHECK ADD CHECK  (([Estatus_Examen]='Cancelado' OR [Estatus_Examen]='Finalizado' OR [Estatus_Examen]='En Proceso'))
GO
ALTER TABLE [dbo].[Medicos]  WITH CHECK ADD  CONSTRAINT [CK__Medicos__Genero__5BE2A6F2] CHECK  (([Genero]='Femenino' OR [Genero]='Masculino'))
GO
ALTER TABLE [dbo].[Medicos] CHECK CONSTRAINT [CK__Medicos__Genero__5BE2A6F2]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD CHECK  (([Genero]='Femenino' OR [Genero]='Masculino'))
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD CHECK  (([Motivo_Bloqueo]='Bloqueo Permanente' OR [Motivo_Bloqueo]='Bloqueo Temporal'))
GO
/****** Object:  StoredProcedure [dbo].[Login_Lab]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Login_Lab]
(
@user nvarchar(50),
@contrasenia nvarchar(50)

)
as begin

declare @Contraseña_Encriptada varbinary(max) = (select Contrasenia_Us from Usuarios R where R.Nombre_us = @user or R.Dni_Us = @user)
declare @Contra nvarchar(50) = CONVERT(nvarchar(MAX), DECRYPTBYPASSPHRASE('password', @Contraseña_Encriptada)) 
declare @Dni nvarchar(50) = (Select Dni_Us from Usuarios where Nombre_us = @user or Dni_Us = @user)
IF (exists (select Contrasenia_Us from Usuarios R where R.Nombre_us = @user or R.Dni_Us = @user))



IF @contrasenia = @Contra
begin

update Usuarios set Intentos_Us = 0, Fecha_Actualizacion = GETDATE()  where Dni_Us = @Dni

IF(exists (Select * from Medicos where Dni = @Dni))
begin 

Select 
m.Id_Medico as 'id_Empleado',
m.Nombres as 'nombres',
m.Apellidos as 'apellidos',
m.Dni as 'dni_emp',
m.Fecha_Nacimiento as 'fecha_nac',
m.Genero as 'genero',
m.Telefono  'telefono',
m.Direccion 'direccion',
m.Fecha_Registro as 'fecha_reg',
m.Fecha_Actualizacion as 'fecha_act',
u.Nombre_us as 'nombre_us',
u.Dni_Us as 'dni_us',
@Contra as 'contrasenia_us',
u.Estatus_Us as 'estado_us',
u.Fecha_Registro as 'fecha_reg_us',
u.Fecha_Actualizacion as 'fecha_act_us',
u.Correo_Us as 'correo_us',
r.Id_Rol as 'id_rol',
r.Nombre_rol as 'cargo'
from Medicos m
join Usuarios u on u.Dni_Us = m.Dni
join Roles r on r.Id_Rol = u.Id_Rol
where m.Dni = @Dni

end
else begin

Select 
e.Id_Empleado as 'id_Empleado',
e.Nombre_Empleado as 'nombres',
e.Apellido_Empleado as 'apellidos',
e.Dni_Empleado as 'dni_emp',
e.Fecha_Nacimiento as 'fecha_nac',
e.Genero as 'genero',
e.Telefono_Empleado  'telefono',
e.Direccion_Empleado 'direccion',
e.Fecha_Registro as 'fecha_reg',
e.Fecha_Actualizacion as 'fecha_act',
u.Nombre_us as 'nombre_us',
u.Dni_Us as 'dni_us',
@Contra as 'contrasenia_us',
u.Estatus_Us as 'estado_us',
u.Fecha_Registro as 'fecha_reg_us',
u.Fecha_Actualizacion as 'fecha_act_us',
u.Correo_Us as 'correo_us',
r.Id_Rol as 'id_rol',
r.Nombre_rol as 'cargo'
from Empleados e
join Usuarios u on u.Dni_Us = e.Dni_Empleado
join Roles r on r.Id_Rol = u.Id_Rol
where e.Dni_Empleado = @Dni
end



end
else
begin

update Usuarios set Intentos_Us = Intentos_Us + 1, Fecha_Actualizacion = GETDATE()  where Dni_Us = @Dni


end









end
GO
/****** Object:  StoredProcedure [dbo].[Registrar_Usuario]    Script Date: 12/3/2023 21:58:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Registrar_Usuario]
(
  @Nombre_us VARCHAR(255),
  @Dni_Us nvarchar(30),
  @Contrasenia_Us nvarchar(50),
  @Correo_Us VARCHAR(255),
  @Id_Rol INT,
@mensaje nvarchar(150) output
)
as
begin

declare @encriptacion VARBINARY(MAX) = (SELECT ENCRYPTBYPASSPHRASE('password', @Contrasenia_Us))

if(exists (select * from [dbo].[Medicos] where Dni = @Dni_Us) or exists (Select * from [dbo].[Empleados] where Dni_Empleado = @Dni_Us))


IF(not exists(Select * from [dbo].[Usuarios] where Dni_Us = @Dni_Us))
begin
insert into Usuarios(Nombre_Us,Dni_Us,[Contrasenia_Us],[Estatus_Us],[Correo_Us],[Id_Rol]) values
(@Nombre_us,@Dni_Us,@encriptacion,1,@Correo_Us,@Id_Rol)
set @mensaje = 'Usuario Registrado Con Exito'
end
ELSE

set @mensaje = 'Usuario Existente en nuestros registros'

else


set @mensaje = 'Numero de Identidad no se encuentra registrado en la base de datos'

end




GO
USE [master]
GO
ALTER DATABASE [Laboratorio_clinico] SET  READ_WRITE 
GO
