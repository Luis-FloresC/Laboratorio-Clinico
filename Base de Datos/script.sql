USE [Laboratorio_clinico]
GO
/****** Object:  StoredProcedure [dbo].[Verificar_Usuario]    Script Date: 8/4/2023 15:19:50 ******/
DROP PROCEDURE [dbo].[Verificar_Usuario]
GO
/****** Object:  StoredProcedure [dbo].[Registrar_Usuario]    Script Date: 8/4/2023 15:19:50 ******/
DROP PROCEDURE [dbo].[Registrar_Usuario]
GO
/****** Object:  StoredProcedure [dbo].[RecoverPassword]    Script Date: 8/4/2023 15:19:50 ******/
DROP PROCEDURE [dbo].[RecoverPassword]
GO
/****** Object:  StoredProcedure [dbo].[PermisoUsuario]    Script Date: 8/4/2023 15:19:50 ******/
DROP PROCEDURE [dbo].[PermisoUsuario]
GO
/****** Object:  StoredProcedure [dbo].[nuevoInventario]    Script Date: 8/4/2023 15:19:50 ******/
DROP PROCEDURE [dbo].[nuevoInventario]
GO
/****** Object:  StoredProcedure [dbo].[Login_Lab]    Script Date: 8/4/2023 15:19:50 ******/
DROP PROCEDURE [dbo].[Login_Lab]
GO
/****** Object:  StoredProcedure [dbo].[ListaPacientes]    Script Date: 8/4/2023 15:19:50 ******/
DROP PROCEDURE [dbo].[ListaPacientes]
GO
/****** Object:  StoredProcedure [dbo].[Editar_Usuario]    Script Date: 8/4/2023 15:19:50 ******/
DROP PROCEDURE [dbo].[Editar_Usuario]
GO
/****** Object:  StoredProcedure [dbo].[CambiarPassword]    Script Date: 8/4/2023 15:19:50 ******/
DROP PROCEDURE [dbo].[CambiarPassword]
GO
/****** Object:  StoredProcedure [dbo].[BuscarPersonal]    Script Date: 8/4/2023 15:19:50 ******/
DROP PROCEDURE [dbo].[BuscarPersonal]
GO
/****** Object:  StoredProcedure [dbo].[AsignarPermisos]    Script Date: 8/4/2023 15:19:50 ******/
DROP PROCEDURE [dbo].[AsignarPermisos]
GO
/****** Object:  StoredProcedure [dbo].[AsignarEspecialidades]    Script Date: 8/4/2023 15:19:50 ******/
DROP PROCEDURE [dbo].[AsignarEspecialidades]
GO
ALTER TABLE [dbo].[Usuarios] DROP CONSTRAINT [CK__Usuarios__Motivo__52593CB8]
GO
ALTER TABLE [dbo].[Pacientes] DROP CONSTRAINT [CK__Pacientes__Gener__37A5467C]
GO
ALTER TABLE [dbo].[Medicos] DROP CONSTRAINT [CK__Medicos__Genero__5BE2A6F2]
GO
ALTER TABLE [dbo].[Examenes_Medicos] DROP CONSTRAINT [CK__Examenes___Estat__6B24EA82]
GO
ALTER TABLE [dbo].[Empleados] DROP CONSTRAINT [CK__Empleados__Gener__3C69FB99]
GO
ALTER TABLE [dbo].[Usuarios] DROP CONSTRAINT [FK__Usuarios__Fecha___5535A963]
GO
ALTER TABLE [dbo].[Roles_Permisos] DROP CONSTRAINT [FK__Roles_Per__Id_Ro__4E88ABD4]
GO
ALTER TABLE [dbo].[Roles_Permisos] DROP CONSTRAINT [FK__Roles_Per__Id_Pe__4F7CD00D]
GO
ALTER TABLE [dbo].[Resultados_Examenes_Detalles] DROP CONSTRAINT [FK__Resultado__Id_Re__00200768]
GO
ALTER TABLE [dbo].[Resultados_Examenes_Detalles] DROP CONSTRAINT [FK__Resultado__Id_Ex__01142BA1]
GO
ALTER TABLE [dbo].[Resultados_Examenes] DROP CONSTRAINT [FK__Resultado__Id_us__7B5B524B]
GO
ALTER TABLE [dbo].[Resultados_Examenes] DROP CONSTRAINT [FK__Resultado__Fecha__7A672E12]
GO
ALTER TABLE [dbo].[Medicos_Especialidades] DROP CONSTRAINT [FK__Medicos_E__Id_Me__628FA481]
GO
ALTER TABLE [dbo].[Medicos_Especialidades] DROP CONSTRAINT [FK__Medicos_E__Id_Es__6383C8BA]
GO
ALTER TABLE [dbo].[Inventario] DROP CONSTRAINT [FK__Inventari__Id_Pr__17F790F9]
GO
ALTER TABLE [dbo].[Facturacion] DROP CONSTRAINT [FK__Facturaci__Id_Us__05D8E0BE]
GO
ALTER TABLE [dbo].[Facturacion] DROP CONSTRAINT [FK__Facturaci__Id_Pa__06CD04F7]
GO
ALTER TABLE [dbo].[Examenes_Medicos_Detalles] DROP CONSTRAINT [FK__Examenes___Id_Ex__75A278F5]
GO
ALTER TABLE [dbo].[Examenes_Medicos_Detalles] DROP CONSTRAINT [FK__Examenes___Id_Ex__73BA3083]
GO
ALTER TABLE [dbo].[Examenes_Medicos_Detalles] DROP CONSTRAINT [FK__Examenes___Id_An__74AE54BC]
GO
ALTER TABLE [dbo].[Examenes_Medicos] DROP CONSTRAINT [FK__Examenes___Id_Us__6E01572D]
GO
ALTER TABLE [dbo].[Examenes_Medicos] DROP CONSTRAINT [FK__Examenes___Id_Pa__6EF57B66]
GO
ALTER TABLE [dbo].[Examenes] DROP CONSTRAINT [FK__Examenes__Fecha___68487DD7]
GO
ALTER TABLE [dbo].[Detalle_Facturacion] DROP CONSTRAINT [FK__Detalle_F__Id_Fa__09A971A2]
GO
ALTER TABLE [dbo].[Detalle_Facturacion] DROP CONSTRAINT [FK__Detalle_F__Id_Ex__0A9D95DB]
GO
ALTER TABLE [dbo].[Bitacora] DROP CONSTRAINT [FK__Bitacora__Id_Usu__1AD3FDA4]
GO
ALTER TABLE [dbo].[Usuarios] DROP CONSTRAINT [DF__Usuarios__Fecha___5441852A]
GO
ALTER TABLE [dbo].[Usuarios] DROP CONSTRAINT [DF__Usuarios__Fecha___534D60F1]
GO
ALTER TABLE [dbo].[Roles_Permisos] DROP CONSTRAINT [DF__Roles_Per__Fecha__4D94879B]
GO
ALTER TABLE [dbo].[Roles_Permisos] DROP CONSTRAINT [DF__Roles_Per__Fecha__4CA06362]
GO
ALTER TABLE [dbo].[Roles] DROP CONSTRAINT [DF__Roles__Fecha_Act__45F365D3]
GO
ALTER TABLE [dbo].[Roles] DROP CONSTRAINT [DF__Roles__Fecha_Reg__44FF419A]
GO
ALTER TABLE [dbo].[Resultados_Examenes_Detalles] DROP CONSTRAINT [DF__Resultado__Fecha__7F2BE32F]
GO
ALTER TABLE [dbo].[Resultados_Examenes_Detalles] DROP CONSTRAINT [DF__Resultado__Fecha__7E37BEF6]
GO
ALTER TABLE [dbo].[Resultados_Examenes] DROP CONSTRAINT [DF__Resultado__Fecha__797309D9]
GO
ALTER TABLE [dbo].[Resultados_Examenes] DROP CONSTRAINT [DF__Resultado__Fecha__787EE5A0]
GO
ALTER TABLE [dbo].[Productos] DROP CONSTRAINT [DF__Productos__Fecha__123EB7A3]
GO
ALTER TABLE [dbo].[Productos] DROP CONSTRAINT [DF__Productos__Fecha__114A936A]
GO
ALTER TABLE [dbo].[Productos] DROP CONSTRAINT [DF__Productos__Preci__10566F31]
GO
ALTER TABLE [dbo].[Productos] DROP CONSTRAINT [DF__Productos__Canti__0F624AF8]
GO
ALTER TABLE [dbo].[Productos] DROP CONSTRAINT [DF__Productos__Canti__0E6E26BF]
GO
ALTER TABLE [dbo].[Permisos] DROP CONSTRAINT [DF__Permisos__Fecha___49C3F6B7]
GO
ALTER TABLE [dbo].[Permisos] DROP CONSTRAINT [DF__Permisos__Fecha___48CFD27E]
GO
ALTER TABLE [dbo].[Pacientes] DROP CONSTRAINT [DF__Pacientes__Fecha__398D8EEE]
GO
ALTER TABLE [dbo].[Pacientes] DROP CONSTRAINT [DF__Pacientes__Fecha__38996AB5]
GO
ALTER TABLE [dbo].[Medicos_Especialidades] DROP CONSTRAINT [DF__Medicos_E__Fecha__619B8048]
GO
ALTER TABLE [dbo].[Medicos_Especialidades] DROP CONSTRAINT [DF__Medicos_E__Fecha__60A75C0F]
GO
ALTER TABLE [dbo].[Medicos] DROP CONSTRAINT [DF__Medicos__Fecha_A__5DCAEF64]
GO
ALTER TABLE [dbo].[Medicos] DROP CONSTRAINT [DF__Medicos__Fecha_R__5CD6CB2B]
GO
ALTER TABLE [dbo].[Inventario] DROP CONSTRAINT [DF__Inventari__Fecha__17036CC0]
GO
ALTER TABLE [dbo].[Inventario] DROP CONSTRAINT [DF__Inventari__Fecha__160F4887]
GO
ALTER TABLE [dbo].[Facturacion] DROP CONSTRAINT [DF__Facturaci__Fecha__04E4BC85]
GO
ALTER TABLE [dbo].[Facturacion] DROP CONSTRAINT [DF__Facturaci__Fecha__03F0984C]
GO
ALTER TABLE [dbo].[Examenes_Medicos_Detalles] DROP CONSTRAINT [DF__Examenes___Fecha__72C60C4A]
GO
ALTER TABLE [dbo].[Examenes_Medicos_Detalles] DROP CONSTRAINT [DF__Examenes___Fecha__71D1E811]
GO
ALTER TABLE [dbo].[Examenes_Medicos] DROP CONSTRAINT [DF__Examenes___Fecha__6D0D32F4]
GO
ALTER TABLE [dbo].[Examenes_Medicos] DROP CONSTRAINT [DF__Examenes___Fecha__6C190EBB]
GO
ALTER TABLE [dbo].[Examenes] DROP CONSTRAINT [DF__Examenes__Fecha___6754599E]
GO
ALTER TABLE [dbo].[Examenes] DROP CONSTRAINT [DF__Examenes__Fecha___66603565]
GO
ALTER TABLE [dbo].[Especialidades] DROP CONSTRAINT [DF__Especiali__Fecha__59063A47]
GO
ALTER TABLE [dbo].[Especialidades] DROP CONSTRAINT [DF__Especiali__Fecha__5812160E]
GO
ALTER TABLE [dbo].[Empleados] DROP CONSTRAINT [DF__Empleados__Fecha__3E52440B]
GO
ALTER TABLE [dbo].[Empleados] DROP CONSTRAINT [DF__Empleados__Fecha__3D5E1FD2]
GO
ALTER TABLE [dbo].[Analisis] DROP CONSTRAINT [DF__Analisis__Fecha___4222D4EF]
GO
ALTER TABLE [dbo].[Analisis] DROP CONSTRAINT [DF__Analisis__Fecha___412EB0B6]
GO
/****** Object:  Index [UQ__Producto__D99BD26E5214BAB9]    Script Date: 8/4/2023 15:19:50 ******/
ALTER TABLE [dbo].[Productos] DROP CONSTRAINT [UQ__Producto__D99BD26E5214BAB9]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 8/4/2023 15:19:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuarios]') AND type in (N'U'))
DROP TABLE [dbo].[Usuarios]
GO
/****** Object:  Table [dbo].[Roles_Permisos]    Script Date: 8/4/2023 15:19:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Roles_Permisos]') AND type in (N'U'))
DROP TABLE [dbo].[Roles_Permisos]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 8/4/2023 15:19:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Roles]') AND type in (N'U'))
DROP TABLE [dbo].[Roles]
GO
/****** Object:  Table [dbo].[Resultados_Examenes_Detalles]    Script Date: 8/4/2023 15:19:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Resultados_Examenes_Detalles]') AND type in (N'U'))
DROP TABLE [dbo].[Resultados_Examenes_Detalles]
GO
/****** Object:  Table [dbo].[Resultados_Examenes]    Script Date: 8/4/2023 15:19:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Resultados_Examenes]') AND type in (N'U'))
DROP TABLE [dbo].[Resultados_Examenes]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 8/4/2023 15:19:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Productos]') AND type in (N'U'))
DROP TABLE [dbo].[Productos]
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 8/4/2023 15:19:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Permisos]') AND type in (N'U'))
DROP TABLE [dbo].[Permisos]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 8/4/2023 15:19:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Pacientes]') AND type in (N'U'))
DROP TABLE [dbo].[Pacientes]
GO
/****** Object:  Table [dbo].[Medicos_Especialidades]    Script Date: 8/4/2023 15:19:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Medicos_Especialidades]') AND type in (N'U'))
DROP TABLE [dbo].[Medicos_Especialidades]
GO
/****** Object:  Table [dbo].[Medicos]    Script Date: 8/4/2023 15:19:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Medicos]') AND type in (N'U'))
DROP TABLE [dbo].[Medicos]
GO
/****** Object:  Table [dbo].[Inventario]    Script Date: 8/4/2023 15:19:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Inventario]') AND type in (N'U'))
DROP TABLE [dbo].[Inventario]
GO
/****** Object:  Table [dbo].[Facturacion]    Script Date: 8/4/2023 15:19:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Facturacion]') AND type in (N'U'))
DROP TABLE [dbo].[Facturacion]
GO
/****** Object:  Table [dbo].[Examenes_Medicos_Detalles]    Script Date: 8/4/2023 15:19:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Examenes_Medicos_Detalles]') AND type in (N'U'))
DROP TABLE [dbo].[Examenes_Medicos_Detalles]
GO
/****** Object:  Table [dbo].[Examenes_Medicos]    Script Date: 8/4/2023 15:19:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Examenes_Medicos]') AND type in (N'U'))
DROP TABLE [dbo].[Examenes_Medicos]
GO
/****** Object:  Table [dbo].[Examenes]    Script Date: 8/4/2023 15:19:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Examenes]') AND type in (N'U'))
DROP TABLE [dbo].[Examenes]
GO
/****** Object:  Table [dbo].[Especialidades]    Script Date: 8/4/2023 15:19:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Especialidades]') AND type in (N'U'))
DROP TABLE [dbo].[Especialidades]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 8/4/2023 15:19:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Empleados]') AND type in (N'U'))
DROP TABLE [dbo].[Empleados]
GO
/****** Object:  Table [dbo].[Detalle_Facturacion]    Script Date: 8/4/2023 15:19:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Detalle_Facturacion]') AND type in (N'U'))
DROP TABLE [dbo].[Detalle_Facturacion]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 8/4/2023 15:19:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Bitacora]') AND type in (N'U'))
DROP TABLE [dbo].[Bitacora]
GO
/****** Object:  Table [dbo].[Analisis]    Script Date: 8/4/2023 15:19:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Analisis]') AND type in (N'U'))
DROP TABLE [dbo].[Analisis]
GO
USE [master]
GO
/****** Object:  Database [Laboratorio_clinico]    Script Date: 8/4/2023 15:19:50 ******/
DROP DATABASE [Laboratorio_clinico]
GO
/****** Object:  Database [Laboratorio_clinico]    Script Date: 8/4/2023 15:19:50 ******/
CREATE DATABASE [Laboratorio_clinico]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Laboratorio_clinico', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Laboratorio_clinico.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Laboratorio_clinico_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Laboratorio_clinico_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
/****** Object:  Table [dbo].[Analisis]    Script Date: 8/4/2023 15:19:50 ******/
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
/****** Object:  Table [dbo].[Bitacora]    Script Date: 8/4/2023 15:19:51 ******/
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
/****** Object:  Table [dbo].[Detalle_Facturacion]    Script Date: 8/4/2023 15:19:51 ******/
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
/****** Object:  Table [dbo].[Empleados]    Script Date: 8/4/2023 15:19:51 ******/
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
/****** Object:  Table [dbo].[Especialidades]    Script Date: 8/4/2023 15:19:51 ******/
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
/****** Object:  Table [dbo].[Examenes]    Script Date: 8/4/2023 15:19:51 ******/
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
/****** Object:  Table [dbo].[Examenes_Medicos]    Script Date: 8/4/2023 15:19:51 ******/
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
/****** Object:  Table [dbo].[Examenes_Medicos_Detalles]    Script Date: 8/4/2023 15:19:51 ******/
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
/****** Object:  Table [dbo].[Facturacion]    Script Date: 8/4/2023 15:19:51 ******/
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
/****** Object:  Table [dbo].[Inventario]    Script Date: 8/4/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventario](
	[Id_Inventario] [int] IDENTITY(1,1) NOT NULL,
	[Id_Producto] [int] NULL,
	[Numero_Serial] [nvarchar](50) NULL,
	[Ubicacion_Almacenamiento] [nvarchar](250) NULL,
	[Fecha_Compra] [datetime] NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
 CONSTRAINT [PK__Inventar__A9DB439CA1379747] PRIMARY KEY CLUSTERED 
(
	[Id_Inventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicos]    Script Date: 8/4/2023 15:19:51 ******/
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
/****** Object:  Table [dbo].[Medicos_Especialidades]    Script Date: 8/4/2023 15:19:51 ******/
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
/****** Object:  Table [dbo].[Pacientes]    Script Date: 8/4/2023 15:19:51 ******/
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
/****** Object:  Table [dbo].[Permisos]    Script Date: 8/4/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[Id_Permiso] [int] IDENTITY(1,1) NOT NULL,
	[Permiso] [nvarchar](50) NULL,
	[Descripcion] [nvarchar](250) NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
 CONSTRAINT [PK__Permisos__153CFB6DE360E7ED] PRIMARY KEY CLUSTERED 
(
	[Id_Permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 8/4/2023 15:19:51 ******/
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
	[Precio_Producto] [decimal](10, 0) NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
 CONSTRAINT [PK__Producto__2085A9CFBA4D1A61] PRIMARY KEY CLUSTERED 
(
	[Id_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Resultados_Examenes]    Script Date: 8/4/2023 15:19:51 ******/
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
/****** Object:  Table [dbo].[Resultados_Examenes_Detalles]    Script Date: 8/4/2023 15:19:51 ******/
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
/****** Object:  Table [dbo].[Roles]    Script Date: 8/4/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id_Rol] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Rol] [varchar](255) NULL,
	[Estatus_Rol] [bit] NULL,
	[Fecha_Registro] [datetime] NULL,
	[Fecha_Actualizacion] [datetime] NULL,
 CONSTRAINT [PK__Roles__55932E8679F717B9] PRIMARY KEY CLUSTERED 
(
	[Id_Rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles_Permisos]    Script Date: 8/4/2023 15:19:51 ******/
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
/****** Object:  Table [dbo].[Usuarios]    Script Date: 8/4/2023 15:19:51 ******/
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
SET IDENTITY_INSERT [dbo].[Analisis] ON 

INSERT [dbo].[Analisis] ([Id_Analisis], [Nombre_Analisis], [Estatus_Analisis], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (1, N'Bioquímica', 1, CAST(N'2023-03-27T12:13:27.370' AS DateTime), CAST(N'2023-03-28T10:59:20.347' AS DateTime))
INSERT [dbo].[Analisis] ([Id_Analisis], [Nombre_Analisis], [Estatus_Analisis], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2, N'Hormonas', 1, CAST(N'2023-03-28T10:47:16.130' AS DateTime), CAST(N'2023-03-28T10:47:16.130' AS DateTime))
INSERT [dbo].[Analisis] ([Id_Analisis], [Nombre_Analisis], [Estatus_Analisis], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (1002, N'Inmunología', 1, CAST(N'2023-03-28T21:16:48.977' AS DateTime), CAST(N'2023-03-28T21:18:01.547' AS DateTime))
SET IDENTITY_INSERT [dbo].[Analisis] OFF
GO
SET IDENTITY_INSERT [dbo].[Bitacora] ON 

INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (1, CAST(N'2023-03-27T09:51:23.833' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2, CAST(N'2023-03-27T09:52:49.060' AS DateTime), N'Inicio Sesión', N'El Usuario Fatima Ingreso al Sistema.', 1003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (3, CAST(N'2023-03-27T09:53:04.553' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (4, CAST(N'2023-03-27T10:21:15.047' AS DateTime), N'Cambio de Contraseña', N'Se Cambio La Contraseña', 1003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5, CAST(N'2023-03-27T10:21:24.520' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (6, CAST(N'2023-03-27T10:42:06.723' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7, CAST(N'2023-03-27T10:43:03.497' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (8, CAST(N'2023-03-27T10:44:14.497' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (9, CAST(N'2023-03-27T10:46:01.613' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (10, CAST(N'2023-03-27T11:01:56.530' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (11, CAST(N'2023-03-27T11:14:05.803' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (12, CAST(N'2023-03-27T11:15:45.630' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (13, CAST(N'2023-03-27T12:03:28.087' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (14, CAST(N'2023-03-27T12:11:24.733' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (15, CAST(N'2023-03-27T12:13:03.027' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (16, CAST(N'2023-03-27T13:42:17.453' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (17, CAST(N'2023-03-27T14:24:52.650' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (18, CAST(N'2023-03-27T14:25:53.223' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (19, CAST(N'2023-03-27T14:56:48.120' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (20, CAST(N'2023-03-27T14:58:59.457' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (21, CAST(N'2023-03-27T15:00:39.713' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (22, CAST(N'2023-03-27T15:01:53.953' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (23, CAST(N'2023-03-27T15:06:32.347' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (1002, CAST(N'2023-03-27T21:05:12.090' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (1003, CAST(N'2023-03-27T21:35:12.387' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (1004, CAST(N'2023-03-27T21:43:11.290' AS DateTime), N'Inicio Sesión', N'El Usuario Fatima Ingreso al Sistema.', 1003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2002, CAST(N'2023-03-28T08:06:39.310' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2003, CAST(N'2023-03-28T08:31:42.360' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2004, CAST(N'2023-03-28T08:34:06.837' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2005, CAST(N'2023-03-28T08:34:44.147' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2006, CAST(N'2023-03-28T08:35:56.687' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2007, CAST(N'2023-03-28T08:51:31.237' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2008, CAST(N'2023-03-28T08:52:55.390' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2009, CAST(N'2023-03-28T10:22:16.277' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2010, CAST(N'2023-03-28T10:24:24.257' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2011, CAST(N'2023-03-28T10:28:06.013' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2012, CAST(N'2023-03-28T10:35:08.733' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2013, CAST(N'2023-03-28T10:56:01.320' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2014, CAST(N'2023-03-28T10:57:13.637' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2015, CAST(N'2023-03-28T10:58:46.720' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2016, CAST(N'2023-03-28T13:47:39.293' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2017, CAST(N'2023-03-28T13:49:44.697' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2018, CAST(N'2023-03-28T13:50:31.690' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2019, CAST(N'2023-03-28T13:55:55.207' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2020, CAST(N'2023-03-28T14:22:15.580' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2021, CAST(N'2023-03-28T14:24:02.630' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2022, CAST(N'2023-03-28T14:27:46.637' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2023, CAST(N'2023-03-28T14:34:04.400' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2024, CAST(N'2023-03-28T14:34:36.087' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2025, CAST(N'2023-03-28T14:38:51.467' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2026, CAST(N'2023-03-28T14:41:43.570' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2027, CAST(N'2023-03-28T14:42:26.563' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2028, CAST(N'2023-03-28T14:48:58.007' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2029, CAST(N'2023-03-28T14:49:52.380' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2030, CAST(N'2023-03-28T14:51:02.000' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2031, CAST(N'2023-03-28T14:51:42.587' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2032, CAST(N'2023-03-28T14:53:37.240' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2033, CAST(N'2023-03-28T14:55:21.143' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2034, CAST(N'2023-03-28T14:56:19.440' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2035, CAST(N'2023-03-28T14:58:17.500' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2036, CAST(N'2023-03-28T15:00:22.850' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2037, CAST(N'2023-03-28T15:01:18.330' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2038, CAST(N'2023-03-28T15:01:59.963' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2039, CAST(N'2023-03-28T15:03:14.657' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2040, CAST(N'2023-03-28T15:04:34.780' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2041, CAST(N'2023-03-28T15:05:14.203' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2042, CAST(N'2023-03-28T15:05:58.783' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2043, CAST(N'2023-03-28T15:06:49.703' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (2044, CAST(N'2023-03-28T15:35:34.283' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (3002, CAST(N'2023-03-28T21:07:19.287' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (3003, CAST(N'2023-03-28T21:12:24.273' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (3004, CAST(N'2023-03-28T21:15:18.953' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (4002, CAST(N'2023-03-29T09:42:33.420' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (4003, CAST(N'2023-03-29T09:44:58.037' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (4004, CAST(N'2023-03-29T10:01:15.537' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (4005, CAST(N'2023-03-29T10:04:05.643' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (4006, CAST(N'2023-03-29T10:05:32.700' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (4007, CAST(N'2023-03-29T11:51:24.680' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (4008, CAST(N'2023-03-29T11:54:04.223' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (4009, CAST(N'2023-03-29T11:55:36.023' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (4010, CAST(N'2023-03-29T11:56:15.197' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (4011, CAST(N'2023-03-29T11:57:36.237' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (4012, CAST(N'2023-03-29T11:58:13.813' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5002, CAST(N'2023-03-30T09:54:12.990' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5003, CAST(N'2023-03-30T09:54:42.503' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5004, CAST(N'2023-03-30T09:55:25.680' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5005, CAST(N'2023-03-30T09:57:41.117' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5006, CAST(N'2023-03-30T12:50:16.350' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5007, CAST(N'2023-03-30T12:50:56.803' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5008, CAST(N'2023-03-30T12:52:38.793' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5009, CAST(N'2023-03-30T12:53:18.230' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5010, CAST(N'2023-03-30T12:53:32.173' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5011, CAST(N'2023-03-30T14:14:12.810' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5012, CAST(N'2023-03-30T14:19:06.797' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5013, CAST(N'2023-03-30T14:21:04.137' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5014, CAST(N'2023-03-30T15:02:58.370' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5015, CAST(N'2023-03-30T15:04:25.120' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5016, CAST(N'2023-03-30T15:05:19.377' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5017, CAST(N'2023-03-30T15:06:28.160' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
GO
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5018, CAST(N'2023-03-30T15:06:41.383' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5019, CAST(N'2023-03-30T15:08:13.070' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5020, CAST(N'2023-03-30T15:11:02.943' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5021, CAST(N'2023-03-30T15:15:01.053' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5022, CAST(N'2023-03-30T15:15:32.010' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5023, CAST(N'2023-03-30T15:16:52.033' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5024, CAST(N'2023-03-30T15:17:47.107' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5025, CAST(N'2023-03-30T15:21:16.610' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5026, CAST(N'2023-03-30T15:22:30.480' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5027, CAST(N'2023-03-30T15:23:37.410' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5028, CAST(N'2023-03-30T15:24:48.107' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5029, CAST(N'2023-03-30T15:25:42.060' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5030, CAST(N'2023-03-30T15:26:28.150' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5031, CAST(N'2023-03-30T15:26:54.670' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5032, CAST(N'2023-03-30T15:27:24.163' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5033, CAST(N'2023-03-30T15:28:02.073' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5034, CAST(N'2023-03-30T15:29:24.010' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5035, CAST(N'2023-03-30T15:34:57.350' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5036, CAST(N'2023-03-30T15:41:06.510' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5037, CAST(N'2023-03-30T15:42:05.090' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5038, CAST(N'2023-03-30T15:47:05.573' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5039, CAST(N'2023-03-30T15:48:52.043' AS DateTime), N'Inicio Sesión', N'El Usuario Fatima Ingreso al Sistema.', 1003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5040, CAST(N'2023-03-30T15:49:15.167' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5041, CAST(N'2023-03-30T15:50:28.933' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5042, CAST(N'2023-03-30T15:52:06.003' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5043, CAST(N'2023-03-30T15:52:23.850' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (5044, CAST(N'2023-03-30T15:53:01.870' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (6002, CAST(N'2023-03-30T21:03:46.143' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (6003, CAST(N'2023-03-30T21:10:25.683' AS DateTime), N'Inicio Sesión', N'El Usuario Fatima Ingreso al Sistema.', 1003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (6004, CAST(N'2023-03-30T21:11:37.040' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (6005, CAST(N'2023-03-30T21:13:37.140' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (6006, CAST(N'2023-03-30T21:30:33.803' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (6007, CAST(N'2023-03-30T21:31:24.713' AS DateTime), N'Inicio Sesión', N'El Usuario Fatima Ingreso al Sistema.', 1003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (6008, CAST(N'2023-03-30T21:35:29.217' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (6009, CAST(N'2023-03-30T21:36:20.413' AS DateTime), N'Inicio Sesión', N'El Usuario Fatima Ingreso al Sistema.', 1003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (6010, CAST(N'2023-03-30T21:42:20.590' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (6011, CAST(N'2023-03-30T21:47:40.767' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (6012, CAST(N'2023-03-30T21:49:36.283' AS DateTime), N'Inicio Sesión', N'El Usuario John Ingreso al Sistema.', 2)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7002, CAST(N'2023-03-31T07:56:12.490' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7003, CAST(N'2023-03-31T08:00:06.203' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7004, CAST(N'2023-03-31T08:03:11.727' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7005, CAST(N'2023-03-31T08:03:46.427' AS DateTime), N'Inicio Sesión', N'El Usuario Fatima Ingreso al Sistema.', 1003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7006, CAST(N'2023-03-31T08:05:25.837' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7007, CAST(N'2023-03-31T08:11:46.713' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7008, CAST(N'2023-03-31T08:13:06.437' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7009, CAST(N'2023-03-31T08:14:35.580' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7010, CAST(N'2023-03-31T08:15:23.130' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7011, CAST(N'2023-03-31T08:16:00.867' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7012, CAST(N'2023-03-31T08:16:33.510' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7013, CAST(N'2023-03-31T08:18:01.670' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7014, CAST(N'2023-03-31T08:19:40.477' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7015, CAST(N'2023-03-31T08:20:25.630' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7016, CAST(N'2023-03-31T08:23:28.173' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7017, CAST(N'2023-03-31T08:24:05.290' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7018, CAST(N'2023-03-31T08:25:50.510' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7019, CAST(N'2023-03-31T08:26:37.127' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7020, CAST(N'2023-03-31T08:29:48.553' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7021, CAST(N'2023-03-31T08:31:31.857' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7022, CAST(N'2023-03-31T08:32:38.953' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7023, CAST(N'2023-03-31T08:38:18.613' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7024, CAST(N'2023-03-31T09:40:48.943' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7025, CAST(N'2023-03-31T09:56:53.380' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7026, CAST(N'2023-03-31T11:06:26.630' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7027, CAST(N'2023-03-31T12:18:18.467' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7028, CAST(N'2023-03-31T12:22:04.607' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7029, CAST(N'2023-03-31T12:37:15.277' AS DateTime), N'Inicio Sesión', N'El Usuario Lizzy Ingreso al Sistema.', 5003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (7030, CAST(N'2023-03-31T12:39:40.483' AS DateTime), N'Inicio Sesión', N'El Usuario Lizzy Ingreso al Sistema.', 5003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (8002, CAST(N'2023-04-01T08:20:57.523' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (8003, CAST(N'2023-04-01T09:25:45.810' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (8004, CAST(N'2023-04-01T09:27:33.907' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (8005, CAST(N'2023-04-01T09:47:22.227' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (8006, CAST(N'2023-04-01T09:49:31.483' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (8007, CAST(N'2023-04-01T09:53:51.590' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (8008, CAST(N'2023-04-01T09:59:44.430' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (8009, CAST(N'2023-04-01T10:01:59.520' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (8010, CAST(N'2023-04-01T10:03:11.380' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (8011, CAST(N'2023-04-01T10:04:53.790' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (8012, CAST(N'2023-04-01T10:06:01.640' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (8013, CAST(N'2023-04-01T10:08:10.763' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (8014, CAST(N'2023-04-01T10:08:50.357' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (8015, CAST(N'2023-04-01T10:18:52.537' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (8016, CAST(N'2023-04-01T10:20:30.517' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (8017, CAST(N'2023-04-01T10:46:39.213' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (8018, CAST(N'2023-04-01T11:09:08.570' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (9002, CAST(N'2023-04-02T16:22:50.030' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (9003, CAST(N'2023-04-02T18:37:59.773' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (9004, CAST(N'2023-04-02T19:15:34.683' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (9005, CAST(N'2023-04-02T19:16:55.143' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (9006, CAST(N'2023-04-02T21:15:34.217' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (9007, CAST(N'2023-04-02T21:18:20.483' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (9008, CAST(N'2023-04-02T21:21:46.110' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (9009, CAST(N'2023-04-02T21:25:25.150' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (9010, CAST(N'2023-04-02T21:26:11.540' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (9011, CAST(N'2023-04-02T21:30:49.817' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (10002, CAST(N'2023-04-03T09:51:37.867' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (10003, CAST(N'2023-04-03T10:13:06.720' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (10004, CAST(N'2023-04-03T10:17:54.620' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (10005, CAST(N'2023-04-03T11:56:09.917' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (10006, CAST(N'2023-04-03T12:04:09.157' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (10007, CAST(N'2023-04-03T12:04:46.773' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
GO
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (11002, CAST(N'2023-04-04T09:33:07.823' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (11003, CAST(N'2023-04-04T09:39:08.247' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (11004, CAST(N'2023-04-04T09:40:00.527' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (11005, CAST(N'2023-04-04T09:41:08.827' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (11006, CAST(N'2023-04-04T09:43:48.180' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (11007, CAST(N'2023-04-04T09:47:04.697' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (11008, CAST(N'2023-04-04T12:24:54.603' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (11009, CAST(N'2023-04-04T12:28:53.957' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (11010, CAST(N'2023-04-04T12:32:01.380' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (11011, CAST(N'2023-04-04T12:33:45.243' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (11012, CAST(N'2023-04-04T12:35:30.313' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (11013, CAST(N'2023-04-04T13:44:22.877' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (12002, CAST(N'2023-04-04T21:06:42.880' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (12003, CAST(N'2023-04-04T21:09:26.860' AS DateTime), N'Inicio Sesión', N'El Usuario Fatima Ingreso al Sistema.', 1003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (12004, CAST(N'2023-04-04T21:10:19.377' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (12005, CAST(N'2023-04-04T21:17:09.993' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (12006, CAST(N'2023-04-04T21:17:48.257' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (12007, CAST(N'2023-04-04T21:18:27.983' AS DateTime), N'Inicio Sesión', N'El Usuario Lizzy Ingreso al Sistema.', 5003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (12008, CAST(N'2023-04-04T21:20:18.810' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (12009, CAST(N'2023-04-04T21:25:31.870' AS DateTime), N'Inicio Sesión', N'El Usuario Lizzy Ingreso al Sistema.', 5003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (12010, CAST(N'2023-04-04T21:45:05.893' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (13002, CAST(N'2023-04-06T21:44:19.510' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (13003, CAST(N'2023-04-06T22:29:19.150' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (14002, CAST(N'2023-04-07T22:48:39.760' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (14003, CAST(N'2023-04-07T23:45:55.483' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (14004, CAST(N'2023-04-07T23:48:52.670' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (14005, CAST(N'2023-04-07T23:51:03.230' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (14006, CAST(N'2023-04-08T00:13:40.527' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (14007, CAST(N'2023-04-08T00:17:41.450' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (15002, CAST(N'2023-04-08T10:22:24.790' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (15003, CAST(N'2023-04-08T10:33:20.267' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (15004, CAST(N'2023-04-08T11:07:32.653' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (15005, CAST(N'2023-04-08T11:28:09.100' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (15006, CAST(N'2023-04-08T13:30:31.890' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
INSERT [dbo].[Bitacora] ([Id_Bitacora], [Fecha_Registro], [Tipo_Evento], [Descripcion_Evento], [Id_Usuario]) VALUES (15007, CAST(N'2023-04-08T14:01:49.273' AS DateTime), N'Inicio Sesión', N'El Usuario Luis Ingreso al Sistema.', 2003)
SET IDENTITY_INSERT [dbo].[Bitacora] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 

INSERT [dbo].[Empleados] ([Id_Empleado], [Nombre_Empleado], [Apellido_Empleado], [Dni_Empleado], [Fecha_Nacimiento], [Direccion_Empleado], [Telefono_Empleado], [Estatus_Us], [Genero], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2, N'Jose Daniel', N'Rodriguez', N'0703199704555', CAST(N'1997-10-04' AS Date), N'La Reforma', N'98765432', 1, N'Masculino', CAST(N'2023-03-12T21:48:49.627' AS DateTime), CAST(N'2023-03-12T21:48:49.627' AS DateTime))
INSERT [dbo].[Empleados] ([Id_Empleado], [Nombre_Empleado], [Apellido_Empleado], [Dni_Empleado], [Fecha_Nacimiento], [Direccion_Empleado], [Telefono_Empleado], [Estatus_Us], [Genero], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (5, N'Fatima ', N'Rodriguez', N'0703198887654', CAST(N'1988-10-04' AS Date), N'Danli', N'98652343', 1, N'Femenino', CAST(N'2023-03-15T21:06:52.280' AS DateTime), CAST(N'2023-03-23T09:41:51.367' AS DateTime))
INSERT [dbo].[Empleados] ([Id_Empleado], [Nombre_Empleado], [Apellido_Empleado], [Dni_Empleado], [Fecha_Nacimiento], [Direccion_Empleado], [Telefono_Empleado], [Estatus_Us], [Genero], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (1003, N'Luis', N'Flores', N'0703200003793', CAST(N'2000-06-07' AS Date), N'Danli', N'98765432', 0, N'Masculino', CAST(N'2023-03-22T21:32:34.697' AS DateTime), CAST(N'2023-03-22T21:32:34.697' AS DateTime))
INSERT [dbo].[Empleados] ([Id_Empleado], [Nombre_Empleado], [Apellido_Empleado], [Dni_Empleado], [Fecha_Nacimiento], [Direccion_Empleado], [Telefono_Empleado], [Estatus_Us], [Genero], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2003, N'Carlos', N'Martinez', N'0706200003793', CAST(N'2000-05-26' AS Date), N'Trojes', N'87654323', 1, N'Masculino', CAST(N'2023-03-26T16:02:34.540' AS DateTime), CAST(N'2023-03-26T16:02:34.540' AS DateTime))
INSERT [dbo].[Empleados] ([Id_Empleado], [Nombre_Empleado], [Apellido_Empleado], [Dni_Empleado], [Fecha_Nacimiento], [Direccion_Empleado], [Telefono_Empleado], [Estatus_Us], [Genero], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (3003, N'Ana', N'Diaz', N'0704200003793', CAST(N'2000-06-17' AS Date), N'Danli', N'89654322', 1, N'Femenino', CAST(N'2023-03-27T21:38:50.540' AS DateTime), CAST(N'2023-03-27T21:38:50.540' AS DateTime))
INSERT [dbo].[Empleados] ([Id_Empleado], [Nombre_Empleado], [Apellido_Empleado], [Dni_Empleado], [Fecha_Nacimiento], [Direccion_Empleado], [Telefono_Empleado], [Estatus_Us], [Genero], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (4003, N'Lizzy', N'Velasquez', N'0704197702348', CAST(N'1977-03-31' AS Date), N'El Paraiso', N'89679876', 1, N'Femenino', CAST(N'2023-03-31T12:35:22.363' AS DateTime), CAST(N'2023-03-31T12:35:22.363' AS DateTime))
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[Especialidades] ON 

INSERT [dbo].[Especialidades] ([Id_Especialidad], [Nombre_Esp], [Fecha_Esp], [Estatus_Esp], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (1, N'Anatomía Patológica', NULL, 1, CAST(N'2023-04-03T11:57:17.230' AS DateTime), CAST(N'2023-04-04T13:44:42.117' AS DateTime))
INSERT [dbo].[Especialidades] ([Id_Especialidad], [Nombre_Esp], [Fecha_Esp], [Estatus_Esp], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2, N'Especialidad X', NULL, 1, CAST(N'2023-04-04T21:45:31.870' AS DateTime), CAST(N'2023-04-04T21:45:31.870' AS DateTime))
SET IDENTITY_INSERT [dbo].[Especialidades] OFF
GO
SET IDENTITY_INSERT [dbo].[Examenes] ON 

INSERT [dbo].[Examenes] ([Id_Examen], [Nombre_Exm], [Fecha_Exm], [Estatus_Exm], [Id_analisis], [Costo_Examen], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (1, N'Glucosa ', NULL, 1, 1, CAST(150.00 AS Decimal(10, 2)), CAST(N'2023-03-28T10:35:53.760' AS DateTime), CAST(N'2023-03-28T10:35:53.760' AS DateTime))
INSERT [dbo].[Examenes] ([Id_Examen], [Nombre_Exm], [Fecha_Exm], [Estatus_Exm], [Id_analisis], [Costo_Examen], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2, N'TSH', NULL, 1, 2, CAST(300.00 AS Decimal(10, 2)), CAST(N'2023-03-28T10:47:45.840' AS DateTime), CAST(N'2023-03-28T13:56:12.490' AS DateTime))
INSERT [dbo].[Examenes] ([Id_Examen], [Nombre_Exm], [Fecha_Exm], [Estatus_Exm], [Id_analisis], [Costo_Examen], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (3, N'T3', NULL, 1, 2, CAST(400.00 AS Decimal(10, 2)), CAST(N'2023-03-28T10:48:15.187' AS DateTime), CAST(N'2023-03-28T21:12:42.067' AS DateTime))
INSERT [dbo].[Examenes] ([Id_Examen], [Nombre_Exm], [Fecha_Exm], [Estatus_Exm], [Id_analisis], [Costo_Examen], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (4, N'T4', NULL, 1, 2, CAST(450.00 AS Decimal(10, 2)), CAST(N'2023-03-28T10:48:34.470' AS DateTime), CAST(N'2023-03-28T21:09:34.470' AS DateTime))
INSERT [dbo].[Examenes] ([Id_Examen], [Nombre_Exm], [Fecha_Exm], [Estatus_Exm], [Id_analisis], [Costo_Examen], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (1002, N'R.P.R/V.D.R.L ', NULL, 1, 1002, CAST(100.00 AS Decimal(10, 2)), CAST(N'2023-03-28T21:19:26.920' AS DateTime), CAST(N'2023-03-28T21:19:26.920' AS DateTime))
SET IDENTITY_INSERT [dbo].[Examenes] OFF
GO
SET IDENTITY_INSERT [dbo].[Inventario] ON 

INSERT [dbo].[Inventario] ([Id_Inventario], [Id_Producto], [Numero_Serial], [Ubicacion_Almacenamiento], [Fecha_Compra], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (1, 1, N'QWTH1234UH', N'Estante #1', CAST(N'2023-04-07T00:00:00.000' AS DateTime), CAST(N'2023-04-07T22:44:35.597' AS DateTime), CAST(N'2023-04-07T22:44:35.597' AS DateTime))
INSERT [dbo].[Inventario] ([Id_Inventario], [Id_Producto], [Numero_Serial], [Ubicacion_Almacenamiento], [Fecha_Compra], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2, 2, N'YJ5AEFKW42', N'Estante 2', CAST(N'2023-04-08T00:17:50.017' AS DateTime), CAST(N'2023-04-08T00:18:13.267' AS DateTime), CAST(N'2023-04-08T00:18:13.267' AS DateTime))
SET IDENTITY_INSERT [dbo].[Inventario] OFF
GO
SET IDENTITY_INSERT [dbo].[Medicos] ON 

INSERT [dbo].[Medicos] ([Id_Medico], [Nombres], [Apellidos], [Dni], [Fecha_Nacimiento], [Direccion], [Telefono], [Estatus_us], [Genero], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (1, N'John', N'Nuñez', N'0801200003793', CAST(N'2000-08-07' AS Date), N'Danli', N'98765432', 1, N'Masculino', CAST(N'2023-03-08T09:57:59.507' AS DateTime), CAST(N'2023-03-21T09:51:35.587' AS DateTime))
INSERT [dbo].[Medicos] ([Id_Medico], [Nombres], [Apellidos], [Dni], [Fecha_Nacimiento], [Direccion], [Telefono], [Estatus_us], [Genero], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2, N'Juan Antanio', N'Moncada', N'0704199509876', CAST(N'1995-04-18' AS Date), N'Cuyali', N'97865467', 1, N'Masculino', CAST(N'2023-04-02T19:18:08.293' AS DateTime), CAST(N'2023-04-03T09:55:43.403' AS DateTime))
SET IDENTITY_INSERT [dbo].[Medicos] OFF
GO
INSERT [dbo].[Medicos_Especialidades] ([Id_Medico], [Id_Especialidad], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (1, 1, CAST(N'2023-04-04T09:46:48.703' AS DateTime), CAST(N'2023-04-08T10:26:51.130' AS DateTime))
INSERT [dbo].[Medicos_Especialidades] ([Id_Medico], [Id_Especialidad], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2, 1, CAST(N'2023-04-04T12:35:42.590' AS DateTime), CAST(N'2023-04-04T12:35:42.590' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Pacientes] ON 

INSERT [dbo].[Pacientes] ([Id_Paciente], [Nombre_Paciente], [Apellido_Paciente], [Dni_Paciente], [Fecha_Nacimiento], [Direccion_Paciente], [Telefono_Paciente], [Genero], [Estatus_Us], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (1, N'Allan', N'Mejia', N'0803200003793', CAST(N'2000-01-01' AS Date), N'Danli', N'98654344', N'Masculino', 0, CAST(N'2023-03-21T14:59:02.977' AS DateTime), CAST(N'2023-03-21T14:59:02.977' AS DateTime))
INSERT [dbo].[Pacientes] ([Id_Paciente], [Nombre_Paciente], [Apellido_Paciente], [Dni_Paciente], [Fecha_Nacimiento], [Direccion_Paciente], [Telefono_Paciente], [Genero], [Estatus_Us], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2, N'Jose', N'Mejia', N'0703199707678', CAST(N'1997-03-21' AS Date), N'Danli', N'89765432', N'Masculino', 0, CAST(N'2023-03-21T21:03:03.673' AS DateTime), CAST(N'2023-03-22T21:05:16.710' AS DateTime))
INSERT [dbo].[Pacientes] ([Id_Paciente], [Nombre_Paciente], [Apellido_Paciente], [Dni_Paciente], [Fecha_Nacimiento], [Direccion_Paciente], [Telefono_Paciente], [Genero], [Estatus_Us], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (3, N'Jasmin', N'Carcamo', N'0801200007654', CAST(N'2000-03-21' AS Date), N'Jasmatran', N'98673456', N'Femenino', 1, CAST(N'2023-03-21T21:23:59.817' AS DateTime), CAST(N'2023-03-21T21:23:59.817' AS DateTime))
INSERT [dbo].[Pacientes] ([Id_Paciente], [Nombre_Paciente], [Apellido_Paciente], [Dni_Paciente], [Fecha_Nacimiento], [Direccion_Paciente], [Telefono_Paciente], [Genero], [Estatus_Us], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (1002, N'Eduardo', N'Daniel', N'0703199707678', CAST(N'1997-03-21' AS Date), N'Danli', N'89765438', N'Masculino', 1, CAST(N'2023-03-22T13:57:53.103' AS DateTime), CAST(N'2023-03-22T13:57:53.103' AS DateTime))
SET IDENTITY_INSERT [dbo].[Pacientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Permisos] ON 

INSERT [dbo].[Permisos] ([Id_Permiso], [Permiso], [Descripcion], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2, N'Frm_Pacientes', N'Pantalla de Pacientes', CAST(N'2023-03-13T09:57:50.167' AS DateTime), CAST(N'2023-03-13T09:57:50.167' AS DateTime))
INSERT [dbo].[Permisos] ([Id_Permiso], [Permiso], [Descripcion], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (3, N'Frm_Calendario', N'Pantalla de Calendario', CAST(N'2023-03-13T09:57:50.167' AS DateTime), CAST(N'2023-03-13T09:57:50.167' AS DateTime))
INSERT [dbo].[Permisos] ([Id_Permiso], [Permiso], [Descripcion], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (4, N'Frm_Usuarios_Main', N'Pantalla de Usuarios', CAST(N'2023-03-13T09:58:58.177' AS DateTime), CAST(N'2023-03-13T09:58:58.177' AS DateTime))
INSERT [dbo].[Permisos] ([Id_Permiso], [Permiso], [Descripcion], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2002, N'Frm_Bitacora', N'Pantalla de Bitacora', CAST(N'2023-03-15T11:57:31.420' AS DateTime), CAST(N'2023-03-15T11:57:31.420' AS DateTime))
INSERT [dbo].[Permisos] ([Id_Permiso], [Permiso], [Descripcion], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2003, N'Frm_Medico', N'Pantalla de Medico', CAST(N'2023-03-15T11:57:31.420' AS DateTime), CAST(N'2023-03-15T11:57:31.420' AS DateTime))
INSERT [dbo].[Permisos] ([Id_Permiso], [Permiso], [Descripcion], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2005, N'Frm_Catalogo', N'Pantalla de Catalogo de Examenes', CAST(N'2023-03-15T11:57:31.420' AS DateTime), CAST(N'2023-03-15T11:57:31.420' AS DateTime))
INSERT [dbo].[Permisos] ([Id_Permiso], [Permiso], [Descripcion], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2006, N'Frm_Reportes', N'Pantalla de Reportes', CAST(N'2023-03-15T11:57:31.420' AS DateTime), CAST(N'2023-03-15T11:57:31.420' AS DateTime))
INSERT [dbo].[Permisos] ([Id_Permiso], [Permiso], [Descripcion], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2007, N'Frm_Facturacion', N'Pantalla de Facturación', CAST(N'2023-03-15T11:57:31.420' AS DateTime), CAST(N'2023-03-15T11:57:31.420' AS DateTime))
INSERT [dbo].[Permisos] ([Id_Permiso], [Permiso], [Descripcion], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2008, N'Frm_Examenes_Med', N'Pantalla de Examenes Medicos', CAST(N'2023-03-15T11:57:31.420' AS DateTime), CAST(N'2023-03-15T11:57:31.420' AS DateTime))
INSERT [dbo].[Permisos] ([Id_Permiso], [Permiso], [Descripcion], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2009, N'Frm_Empleados', N'Pantalla de Empleados', CAST(N'2023-03-15T11:57:31.420' AS DateTime), CAST(N'2023-03-15T11:57:31.420' AS DateTime))
INSERT [dbo].[Permisos] ([Id_Permiso], [Permiso], [Descripcion], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (4002, N'btn_Cerrar', N'Cerrar Sesion', CAST(N'2023-03-16T09:05:40.763' AS DateTime), CAST(N'2023-03-16T09:05:40.763' AS DateTime))
SET IDENTITY_INSERT [dbo].[Permisos] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([Id_Producto], [Nombre_Producto], [Nombre_Proveedor], [Cantidad_Stock], [Cantidad_Minima], [Precio_Producto], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (1, N'Placas de TLC', N'Placas de TLC', 15, 5, CAST(200 AS Decimal(10, 0)), CAST(N'2023-04-07T22:44:35.587' AS DateTime), CAST(N'2023-04-07T22:44:35.587' AS DateTime))
INSERT [dbo].[Productos] ([Id_Producto], [Nombre_Producto], [Nombre_Proveedor], [Cantidad_Stock], [Cantidad_Minima], [Precio_Producto], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2, N'Silicagel', N'Silicagel', 6, 5, CAST(160 AS Decimal(10, 0)), CAST(N'2023-04-08T00:18:13.263' AS DateTime), CAST(N'2023-04-08T00:18:13.263' AS DateTime))
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([Id_Rol], [Nombre_Rol], [Estatus_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (1, N'Adminstrador', 1, CAST(N'2023-03-08T09:38:54.507' AS DateTime), CAST(N'2023-04-01T10:20:14.740' AS DateTime))
INSERT [dbo].[Roles] ([Id_Rol], [Nombre_Rol], [Estatus_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2, N'Medico', 0, CAST(N'2023-03-08T09:38:54.507' AS DateTime), CAST(N'2023-04-08T11:15:01.543' AS DateTime))
INSERT [dbo].[Roles] ([Id_Rol], [Nombre_Rol], [Estatus_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (3, N'Recepcionista', 1, CAST(N'2023-03-08T09:38:54.507' AS DateTime), CAST(N'2023-03-08T09:38:54.507' AS DateTime))
INSERT [dbo].[Roles] ([Id_Rol], [Nombre_Rol], [Estatus_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (4, N'Enfermeraaa', 1, CAST(N'2023-03-31T12:25:25.690' AS DateTime), CAST(N'2023-04-01T10:08:22.040' AS DateTime))
INSERT [dbo].[Roles] ([Id_Rol], [Nombre_Rol], [Estatus_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (1004, N'Técnicos de laboratorio', 1, CAST(N'2023-04-01T08:24:46.850' AS DateTime), CAST(N'2023-04-01T10:19:14.663' AS DateTime))
INSERT [dbo].[Roles] ([Id_Rol], [Nombre_Rol], [Estatus_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2004, N'Analista Clinico', 1, CAST(N'2023-04-04T21:15:23.463' AS DateTime), CAST(N'2023-04-04T21:15:23.463' AS DateTime))
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2, 1, CAST(N'2023-03-29T14:53:11.323' AS DateTime), CAST(N'2023-03-30T21:49:23.980' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2, 2, CAST(N'2023-03-13T10:00:49.917' AS DateTime), CAST(N'2023-04-08T14:02:21.447' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2, 3, CAST(N'2023-03-30T21:36:03.393' AS DateTime), CAST(N'2023-03-30T21:36:03.393' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2, 4, CAST(N'2023-03-31T12:33:15.530' AS DateTime), CAST(N'2023-03-31T12:33:15.530' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (3, 1, CAST(N'2023-03-29T14:53:11.323' AS DateTime), CAST(N'2023-03-30T21:49:23.980' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (3, 2, CAST(N'2023-03-13T10:00:56.067' AS DateTime), CAST(N'2023-04-08T14:02:21.450' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (3, 3, CAST(N'2023-03-30T21:36:03.397' AS DateTime), CAST(N'2023-03-30T21:36:03.397' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (4, 1, CAST(N'2023-03-29T14:53:11.323' AS DateTime), CAST(N'2023-03-30T21:49:23.980' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2002, 1, CAST(N'2023-03-29T14:53:11.323' AS DateTime), CAST(N'2023-03-30T21:49:23.983' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2002, 2, CAST(N'2023-04-08T14:02:21.450' AS DateTime), CAST(N'2023-04-08T14:02:21.450' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2003, 1, CAST(N'2023-03-29T14:53:11.323' AS DateTime), CAST(N'2023-03-30T21:49:23.983' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2005, 1, CAST(N'2023-03-29T14:53:11.323' AS DateTime), CAST(N'2023-03-30T21:49:23.983' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2005, 2, CAST(N'2023-03-15T12:14:05.040' AS DateTime), CAST(N'2023-04-08T14:02:21.450' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2005, 3, CAST(N'2023-03-30T21:36:03.403' AS DateTime), CAST(N'2023-03-30T21:36:03.403' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2006, 1, CAST(N'2023-03-29T14:53:11.323' AS DateTime), CAST(N'2023-03-30T21:49:23.983' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2006, 2, CAST(N'2023-03-15T12:13:48.867' AS DateTime), CAST(N'2023-04-08T14:02:21.453' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2006, 3, CAST(N'2023-03-15T12:15:48.263' AS DateTime), CAST(N'2023-03-30T21:36:03.403' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2007, 1, CAST(N'2023-03-29T14:53:11.323' AS DateTime), CAST(N'2023-03-30T21:49:23.987' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2007, 3, CAST(N'2023-03-30T21:36:03.403' AS DateTime), CAST(N'2023-03-30T21:36:03.403' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2008, 1, CAST(N'2023-03-29T14:53:11.323' AS DateTime), CAST(N'2023-03-30T21:49:23.987' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2008, 2, CAST(N'2023-03-15T12:12:55.910' AS DateTime), CAST(N'2023-04-08T14:02:21.453' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2008, 3, CAST(N'2023-03-30T21:36:03.407' AS DateTime), CAST(N'2023-03-30T21:36:03.407' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2009, 1, CAST(N'2023-03-29T14:53:11.323' AS DateTime), CAST(N'2023-03-30T21:49:23.987' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (4002, 1, CAST(N'2023-03-29T14:53:11.323' AS DateTime), CAST(N'2023-03-29T14:53:11.323' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (4002, 2, CAST(N'2023-03-16T09:05:59.100' AS DateTime), CAST(N'2023-03-16T09:05:59.100' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (4002, 3, CAST(N'2023-03-16T09:06:05.013' AS DateTime), CAST(N'2023-03-16T09:06:05.013' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (4002, 1004, CAST(N'2023-04-01T08:24:46.853' AS DateTime), CAST(N'2023-04-01T08:24:46.853' AS DateTime))
INSERT [dbo].[Roles_Permisos] ([Id_Permiso], [Id_Rol], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (4002, 2004, CAST(N'2023-04-04T21:15:23.463' AS DateTime), CAST(N'2023-04-04T21:15:23.463' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([id_usuario], [Nombre_Us], [Dni_Us], [Contrasenia_Us], [Estatus_Us], [Correo_Us], [Intentos_Us], [Pin_Recuperacion], [Fecha_Gen_Pin], [Id_Rol], [Fecha_Bloqueo], [Motivo_Bloqueo], [Fecha_Desbloqueo], [Descripcion_Bloqueo], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2, N'John', N'0801200003793', 0x02000000121344F58A1724682BCE69C6AFD79F83E6658A7BA98BB73EE34F1AD80CF390111326528F52B6B21A9F5D15E0A851EBDB, 1, N'JohnFlores58@gmail.com', 0, N'4945', CAST(N'2023-03-21T21:06:26.000' AS DateTime), 2, NULL, NULL, NULL, NULL, CAST(N'2023-03-08T10:00:41.000' AS DateTime), CAST(N'2023-03-30T21:49:36.280' AS DateTime))
INSERT [dbo].[Usuarios] ([id_usuario], [Nombre_Us], [Dni_Us], [Contrasenia_Us], [Estatus_Us], [Correo_Us], [Intentos_Us], [Pin_Recuperacion], [Fecha_Gen_Pin], [Id_Rol], [Fecha_Bloqueo], [Motivo_Bloqueo], [Fecha_Desbloqueo], [Descripcion_Bloqueo], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (1002, N'Daniel', N'0703199704555', 0x0200000047D2D5C8AF9E5E60F1AF8918D7DC159D220E69AA0A0A7082946DDCCAEB9A0F9BBFC4D9AE3AE078A93009A5D00EBECFFA, 1, N'Jose-DanielR@unicah.edu', 0, NULL, NULL, 1, NULL, NULL, NULL, NULL, CAST(N'2023-03-12T21:49:53.733' AS DateTime), CAST(N'2023-03-26T16:50:19.923' AS DateTime))
INSERT [dbo].[Usuarios] ([id_usuario], [Nombre_Us], [Dni_Us], [Contrasenia_Us], [Estatus_Us], [Correo_Us], [Intentos_Us], [Pin_Recuperacion], [Fecha_Gen_Pin], [Id_Rol], [Fecha_Bloqueo], [Motivo_Bloqueo], [Fecha_Desbloqueo], [Descripcion_Bloqueo], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (1003, N'Fatima', N'0703198887654', 0x020000002520E7B478002243E0EEE1087199C0D49CDB1310C329B805989E559FCF2EC744AA7A48379DB620142C03ECC3F6D1D401, 1, N'fatima34@gmail.com', 0, N'1690', CAST(N'2023-03-27T10:18:52.360' AS DateTime), 3, NULL, NULL, NULL, NULL, CAST(N'2023-03-15T21:09:03.983' AS DateTime), CAST(N'2023-04-04T21:09:26.850' AS DateTime))
INSERT [dbo].[Usuarios] ([id_usuario], [Nombre_Us], [Dni_Us], [Contrasenia_Us], [Estatus_Us], [Correo_Us], [Intentos_Us], [Pin_Recuperacion], [Fecha_Gen_Pin], [Id_Rol], [Fecha_Bloqueo], [Motivo_Bloqueo], [Fecha_Desbloqueo], [Descripcion_Bloqueo], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (2003, N'Luis', N'0703200003793', 0x02000000C1B410713FF85AB3483FA7C83CEC5D83EE26BB906C027F219F0FA0B0C5D338148E8771D7EFA8269E62537B37BC8BF031, 1, N'lf016158@gmail.com', 0, NULL, NULL, 1, NULL, NULL, NULL, NULL, CAST(N'2023-03-23T11:28:34.483' AS DateTime), CAST(N'2023-04-08T14:01:49.263' AS DateTime))
INSERT [dbo].[Usuarios] ([id_usuario], [Nombre_Us], [Dni_Us], [Contrasenia_Us], [Estatus_Us], [Correo_Us], [Intentos_Us], [Pin_Recuperacion], [Fecha_Gen_Pin], [Id_Rol], [Fecha_Bloqueo], [Motivo_Bloqueo], [Fecha_Desbloqueo], [Descripcion_Bloqueo], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (3003, N'Carlos', N'0706200003793', 0x020000001BD3668FEEFF37E5D043097375DC3E1F6B20DCD2028D8415E0FA9E3A0C0C7830108FFC5A54F82F5FCB37EE41B6593888, 1, N'CarlosM4@gmail.com', 0, NULL, NULL, 3, NULL, NULL, NULL, NULL, CAST(N'2023-03-26T16:08:14.067' AS DateTime), CAST(N'2023-03-26T16:11:05.767' AS DateTime))
INSERT [dbo].[Usuarios] ([id_usuario], [Nombre_Us], [Dni_Us], [Contrasenia_Us], [Estatus_Us], [Correo_Us], [Intentos_Us], [Pin_Recuperacion], [Fecha_Gen_Pin], [Id_Rol], [Fecha_Bloqueo], [Motivo_Bloqueo], [Fecha_Desbloqueo], [Descripcion_Bloqueo], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (4003, N'Ana', N'0704200003793', 0x020000001CE93F846A4BCE282BBBA2C0910D2F8900830C5D357FB19BC28FE1CFC8CC14B841CA4F9A50A88E2988327BF34A354164, 1, N'AnaM765@gmail.com', NULL, NULL, NULL, 3, NULL, NULL, NULL, NULL, CAST(N'2023-03-27T21:40:53.717' AS DateTime), CAST(N'2023-03-27T21:40:53.717' AS DateTime))
INSERT [dbo].[Usuarios] ([id_usuario], [Nombre_Us], [Dni_Us], [Contrasenia_Us], [Estatus_Us], [Correo_Us], [Intentos_Us], [Pin_Recuperacion], [Fecha_Gen_Pin], [Id_Rol], [Fecha_Bloqueo], [Motivo_Bloqueo], [Fecha_Desbloqueo], [Descripcion_Bloqueo], [Fecha_Registro], [Fecha_Actualizacion]) VALUES (5003, N'Lizzy', N'0704197702348', 0x02000000CCFA7B1D5C8E5E0B3DB98734F0F777C5D8C521A9B73EC0F0AF23BC9013FFFC8C678DB9DA15BBCC1EDE5C0F71D6667EA1, 1, N'LV6789@gmail.com', 0, NULL, NULL, 2004, NULL, NULL, NULL, NULL, CAST(N'2023-03-31T12:36:50.147' AS DateTime), CAST(N'2023-04-04T21:25:31.840' AS DateTime))
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Producto__D99BD26E5214BAB9]    Script Date: 8/4/2023 15:19:51 ******/
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [UQ__Producto__D99BD26E5214BAB9] UNIQUE NONCLUSTERED 
(
	[Nombre_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
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
ALTER TABLE [dbo].[Inventario] ADD  CONSTRAINT [DF__Inventari__Fecha__160F4887]  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Inventario] ADD  CONSTRAINT [DF__Inventari__Fecha__17036CC0]  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
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
ALTER TABLE [dbo].[Permisos] ADD  CONSTRAINT [DF__Permisos__Fecha___48CFD27E]  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Permisos] ADD  CONSTRAINT [DF__Permisos__Fecha___49C3F6B7]  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF__Productos__Canti__0E6E26BF]  DEFAULT ((0)) FOR [Cantidad_Stock]
GO
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF__Productos__Canti__0F624AF8]  DEFAULT ((0)) FOR [Cantidad_Minima]
GO
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF__Productos__Preci__10566F31]  DEFAULT ((0)) FOR [Precio_Producto]
GO
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF__Productos__Fecha__114A936A]  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF__Productos__Fecha__123EB7A3]  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Resultados_Examenes] ADD  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Resultados_Examenes] ADD  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Resultados_Examenes_Detalles] ADD  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Resultados_Examenes_Detalles] ADD  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
GO
ALTER TABLE [dbo].[Roles] ADD  CONSTRAINT [DF__Roles__Fecha_Reg__44FF419A]  DEFAULT (getdate()) FOR [Fecha_Registro]
GO
ALTER TABLE [dbo].[Roles] ADD  CONSTRAINT [DF__Roles__Fecha_Act__45F365D3]  DEFAULT (getdate()) FOR [Fecha_Actualizacion]
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
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [FK__Inventari__Id_Pr__17F790F9] FOREIGN KEY([Id_Producto])
REFERENCES [dbo].[Productos] ([Id_Producto])
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [FK__Inventari__Id_Pr__17F790F9]
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
ALTER TABLE [dbo].[Roles_Permisos]  WITH CHECK ADD  CONSTRAINT [FK__Roles_Per__Id_Pe__4F7CD00D] FOREIGN KEY([Id_Permiso])
REFERENCES [dbo].[Permisos] ([Id_Permiso])
GO
ALTER TABLE [dbo].[Roles_Permisos] CHECK CONSTRAINT [FK__Roles_Per__Id_Pe__4F7CD00D]
GO
ALTER TABLE [dbo].[Roles_Permisos]  WITH CHECK ADD  CONSTRAINT [FK__Roles_Per__Id_Ro__4E88ABD4] FOREIGN KEY([Id_Rol])
REFERENCES [dbo].[Roles] ([Id_Rol])
GO
ALTER TABLE [dbo].[Roles_Permisos] CHECK CONSTRAINT [FK__Roles_Per__Id_Ro__4E88ABD4]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK__Usuarios__Fecha___5535A963] FOREIGN KEY([Id_Rol])
REFERENCES [dbo].[Roles] ([Id_Rol])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK__Usuarios__Fecha___5535A963]
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
/****** Object:  StoredProcedure [dbo].[AsignarEspecialidades]    Script Date: 8/4/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AsignarEspecialidades](@idMedico int,@especialidad nvarchar(500),@estado bit)
as begin

declare @idEspecialidad int = (select Id_Especialidad from Especialidades where Nombre_Esp = @especialidad)

if(@estado = 1)
begin

if(exists(select * from Medicos_Especialidades where Id_Medico = @idMedico and Id_Especialidad = @idEspecialidad) )
begin
update Medicos_Especialidades set Id_Medico = @idMedico ,Id_Especialidad = @idEspecialidad,Fecha_Actualizacion = GETDATE() 
where Id_Medico = @idMedico and Id_Especialidad = @idEspecialidad

end
else begin

insert into Medicos_Especialidades(Id_Especialidad,Id_Medico) values (@idEspecialidad,@idMedico)

end
end
else begin 

if(exists(select * from Medicos_Especialidades where Id_Especialidad = @idEspecialidad and Id_Medico = @idMedico) )
begin

delete from Medicos_Especialidades where Id_Especialidad = @idEspecialidad and Id_Medico = @idMedico

end

end

end
GO
/****** Object:  StoredProcedure [dbo].[AsignarPermisos]    Script Date: 8/4/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AsignarPermisos](@idRol int,@permiso nvarchar(500),@estado int)
as begin

declare @idPermiso int = (select Id_Permiso from Permisos where Descripcion = @permiso)

if(@estado = 1)
begin

if(exists(select * from Roles_Permisos where Id_Rol = @idRol and Id_Permiso = @idPermiso) )
begin
update Roles_Permisos set Id_Rol = @idRol ,Id_Permiso = @idPermiso,Fecha_Actualizacion = GETDATE() 
where Id_Rol = @idRol and Id_Permiso = @idPermiso

end
else begin

insert into Roles_Permisos (Id_Rol,Id_Permiso) values (@idRol,@idPermiso)

end
end
else begin 

if(exists(select * from Roles_Permisos where Id_Rol = @idRol and Id_Permiso = @idPermiso) )
begin

delete from Roles_Permisos where Id_Rol = @idRol and Id_Permiso = @idPermiso

end

end

end
GO
/****** Object:  StoredProcedure [dbo].[BuscarPersonal]    Script Date: 8/4/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[BuscarPersonal] (@filtro nvarchar(100))
as begin

declare @TableUx table (
Id int,
Nombre nvarchar(100),
Dni nvarchar(30),
Cargo nvarchar(50)
);

if @filtro <> 'All'
begin

if(exists(select * from Empleados where Nombre_Empleado like CONCAT('%',@filtro,'%') or Apellido_Empleado like CONCAT('%',@filtro,'%') or Dni_Empleado like CONCAT('%',@filtro,'%')))
begin

insert into @TableUx (Id,Nombre,Dni,Cargo) select Id_Empleado,CONCAT(Nombre_Empleado,' ',Apellido_Empleado),Dni_Empleado,'Empleado' from Empleados where Nombre_Empleado like CONCAT('%',@filtro,'%') or Apellido_Empleado like CONCAT('%',@filtro,'%') or Dni_Empleado like CONCAT('%',@filtro,'%')

end


if(exists(select * from Medicos where Nombres like CONCAT('%',@filtro,'%') or Apellidos like CONCAT('%',@filtro,'%') or Dni like CONCAT('%',@filtro,'%')))
begin

insert into @TableUx (Id,Nombre,Dni,Cargo) select Id_Medico,CONCAT(Nombres,' ',Apellidos),Dni,'Medico' from Medicos where Nombres like CONCAT('%',@filtro,'%') or Apellidos like CONCAT('%',@filtro,'%') or Dni like CONCAT('%',@filtro,'%')

end


end
else
begin

insert into @TableUx (Id,Nombre,Dni,Cargo) select Id_Medico,CONCAT(Nombres,' ',Apellidos),Dni,'Medico' from Medicos 
insert into @TableUx (Id,Nombre,Dni,Cargo) select Id_Empleado,CONCAT(Nombre_Empleado,' ',Apellido_Empleado),Dni_Empleado,'Empleado' from Empleados 
end


select * from @TableUx

end
GO
/****** Object:  StoredProcedure [dbo].[CambiarPassword]    Script Date: 8/4/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CambiarPassword](@id int,@password nvarchar(50),@mensaje nvarchar(150) output)
as begin

declare @encriptacion VARBINARY(MAX) = (SELECT ENCRYPTBYPASSPHRASE('password', @password))

if(exists(select * from Usuarios where id_usuario = @id))
begin
update Usuarios set Contrasenia_Us = @encriptacion where id_usuario = @id

set @mensaje = 'Contraseña Actualizada Correctamente.'

end
else begin

set @mensaje = 'Usuario no Encontrado.'

end

end
GO
/****** Object:  StoredProcedure [dbo].[Editar_Usuario]    Script Date: 8/4/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Editar_Usuario]
(
  @Nombre_us VARCHAR(255),
  @Dni_Us nvarchar(30),
  @Contrasenia_Us nvarchar(50),
  @Correo_Us VARCHAR(255),
  @id_Rol int,
@mensaje nvarchar(150) output
)
as
begin

declare @encriptacion VARBINARY(MAX) = (SELECT ENCRYPTBYPASSPHRASE('password', @Contrasenia_Us))

if(exists (select * from [dbo].[Medicos] where Dni = @Dni_Us) or exists (Select * from [dbo].[Empleados] where Dni_Empleado = @Dni_Us))


IF(exists(Select * from [dbo].[Usuarios] where Dni_Us = @Dni_Us))
begin

update Usuarios set Id_Rol = @id_Rol,Correo_Us = @Correo_Us,Nombre_Us=@Nombre_us,Contrasenia_Us = @encriptacion where  Dni_Us = @Dni_Us

set @mensaje = 'Usuario Actualizado Con Exito'
end
ELSE

set @mensaje = 'Usuario no existente en nuestros registros'

else


set @mensaje = 'Numero de Identidad no se encuentra registrado en la base de datos'

end
GO
/****** Object:  StoredProcedure [dbo].[ListaPacientes]    Script Date: 8/4/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [dbo].[ListaPacientes](@inicio int,@fin int)
as begin

select 
p.RowN as '#',
CONCAT(p.Nombre_Paciente,' ',p.Apellido_Paciente) as 'Nombre Completo',
p.Telefono_Paciente as 'Telefono',
p.Genero as 'Genero',
p.Estatus_Us 'Activo',
p.Id_Paciente 'Código'
from (
	Select 
	ROW_NUMBER () over (Order by [Id_Paciente] desc) as 'RowN',
	*
	from Pacientes
) p
where RowN between @inicio and @fin
order by Id_Paciente desc
 
end
GO
/****** Object:  StoredProcedure [dbo].[Login_Lab]    Script Date: 8/4/2023 15:19:51 ******/
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
r.Nombre_rol as 'cargo',
u.id_usuario as 'id_Usuario'
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
r.Nombre_rol as 'cargo',
u.id_usuario as 'id_Usuario'
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
/****** Object:  StoredProcedure [dbo].[nuevoInventario]    Script Date: 8/4/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[nuevoInventario](
@nombreProducto nvarchar(50)
,@nombreProveedor nvarchar(50)
,@cantidad int
,@precio decimal(10,2)
,@numeroSerial nvarchar(50)
,@ubicacion nvarchar(250)
,@fechaCompra datetime
,@mensaje nvarchar(250) output
)
as begin
declare @idProducto int = 0

if(exists(select * from Productos where Nombre_Producto = @nombreProducto))


set @mensaje = 'Ya existe un producto registrado con este nombre.'

else 

insert into Productos(Nombre_Producto,Nombre_Proveedor,Cantidad_Stock,Cantidad_Minima,Precio_Producto)
values (@nombreProducto,@nombreProducto,@cantidad,5,@precio)

set @idProducto = (select Id_Producto from Productos where Nombre_Producto = @nombreProducto)

insert into Inventario (Id_Producto,Numero_Serial,Ubicacion_Almacenamiento,Fecha_Compra)
values (@idProducto,@numeroSerial,@ubicacion,@fechaCompra)

set @mensaje = 'Producto registrado con éxito.'

end
GO
/****** Object:  StoredProcedure [dbo].[PermisoUsuario]    Script Date: 8/4/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PermisoUsuario](@idRol int)
as begin

declare @tablaActivos Table(
num int,
idPermiso int,
Permiso nvarchar(50),
Descripcion nvarchar(500),
Estado int
);

declare @Posiciones table(
id int ,
PosX int,
PosY int
)

insert into @tablaActivos(num,idPermiso,Permiso,Descripcion,Estado) (select ROW_NUMBER () over (Order by p.Estado desc) as 'RowN',p.* from
(select p.Id_Permiso,p.Permiso,p.Descripcion ,
coalesce((select 1 from Roles_Permisos where Id_Permiso = p.Id_Permiso and Id_Rol = @idRol),0) 'Estado'
from Permisos p) p)

declare @total int = (select count(*) from Permisos)

DECLARE @Cont2 INT = 1;
declare @posY int = 99;
WHILE(@Cont2 <= @total) BEGIN
	insert into @Posiciones(id,PosX,PosY) values (@Cont2,0,@posY)
	set @Cont2 += 1;
	set @posY += 47;
END


select * from @tablaActivos ta
join @Posiciones p on p.id = ta.num



end



GO
/****** Object:  StoredProcedure [dbo].[RecoverPassword]    Script Date: 8/4/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[RecoverPassword](@Nombre_user nvarchar(100))
as begin

declare @NumeroDesde int = 1000 ;
declare @NumeroHasta int = 9999 ;
declare @Dni nvarchar(50) = (Select Dni_Us from Usuarios where Nombre_us = @Nombre_user or Dni_Us = @Nombre_user)


if(exists(select * from Usuarios where Nombre_Us=@Nombre_user or Dni_Us=@Nombre_user))
begin

update Usuarios set Pin_Recuperacion = (SELECT ROUND(((@NumeroHasta - @NumeroDesde) * RAND() + @NumeroDesde), 0)) , Fecha_Actualizacion = GETDATE(),Fecha_Gen_Pin = GETDATE() where Nombre_Us=@Nombre_user or Dni_Us=@Nombre_user

IF(exists (Select * from Medicos where Dni = @Dni))
begin 

select CONCAT(m.Nombres,' ',m.Apellidos) as 'nombre',u.Correo_Us,u.Pin_Recuperacion,u.id_usuario from Medicos m
join Usuarios u on u.Dni_Us = m.Dni
where u.Dni_Us = @Dni;

end
else begin

select CONCAT(m.Nombre_Empleado,' ',m.Apellido_Empleado) as 'nombre',u.Correo_Us,u.Pin_Recuperacion,u.id_usuario from Empleados m
join Usuarios u on u.Dni_Us = m.Dni_Empleado
where u.Dni_Us = @Dni;

end



end 


end

GO
/****** Object:  StoredProcedure [dbo].[Registrar_Usuario]    Script Date: 8/4/2023 15:19:51 ******/
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
/****** Object:  StoredProcedure [dbo].[Verificar_Usuario]    Script Date: 8/4/2023 15:19:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Verificar_Usuario](@Id_Usuario int,@user nvarchar(50),@password nvarchar(50))
as begin

declare @Contraseña_Encriptada varbinary(max) = (select Contrasenia_Us from Usuarios R where R.Nombre_us = @user or R.Dni_Us = @user)
declare @Contra nvarchar(50) = CONVERT(nvarchar(MAX), DECRYPTBYPASSPHRASE('password', @Contraseña_Encriptada)) 
declare @Dni nvarchar(50) = (Select Dni_Us from Usuarios where Nombre_us = @user or Dni_Us = @user)

if @Contra = @password 


Select * from [dbo].[Usuarios] R where R.Nombre_us = @user or R.Dni_Us = @user and R.Dni_Us =  @Dni 


end



GO
USE [master]
GO
ALTER DATABASE [Laboratorio_clinico] SET  READ_WRITE 
GO
