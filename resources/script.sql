USE [master]
GO
/****** Object:  Database [AbrilClinica]    Script Date: 26/3/2024 22:29:34 ******/
CREATE DATABASE [AbrilClinica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AbrilClinica', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\AbrilClinica.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AbrilClinica_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\AbrilClinica_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [AbrilClinica] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AbrilClinica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AbrilClinica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AbrilClinica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AbrilClinica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AbrilClinica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AbrilClinica] SET ARITHABORT OFF 
GO
ALTER DATABASE [AbrilClinica] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AbrilClinica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AbrilClinica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AbrilClinica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AbrilClinica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AbrilClinica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AbrilClinica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AbrilClinica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AbrilClinica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AbrilClinica] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AbrilClinica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AbrilClinica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AbrilClinica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AbrilClinica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AbrilClinica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AbrilClinica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AbrilClinica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AbrilClinica] SET RECOVERY FULL 
GO
ALTER DATABASE [AbrilClinica] SET  MULTI_USER 
GO
ALTER DATABASE [AbrilClinica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AbrilClinica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AbrilClinica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AbrilClinica] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AbrilClinica] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AbrilClinica] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'AbrilClinica', N'ON'
GO
ALTER DATABASE [AbrilClinica] SET QUERY_STORE = ON
GO
ALTER DATABASE [AbrilClinica] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [AbrilClinica]
GO
/****** Object:  Table [dbo].[Administrador]    Script Date: 26/3/2024 22:29:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrador](
	[Nombre] [varchar](100) NULL,
	[Apellido] [varchar](100) NULL,
	[Usuario] [varchar](100) NULL,
	[Contrasenia] [varchar](100) NULL,
	[EsAdmin] [bit] NULL,
	[IdDoctor] [int] NULL,
	[Especialidad] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 26/3/2024 22:29:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente](
	[Nombre] [varchar](100) NULL,
	[Apellido] [varchar](100) NULL,
	[Usuario] [varchar](100) NULL,
	[Contrasenia] [varchar](100) NULL,
	[EsAdmin] [bit] NULL,
	[Dni] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turnos]    Script Date: 26/3/2024 22:29:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turnos](
	[Id] [int] NULL,
	[DniPaciente] [int] NULL,
	[Especialidad] [varchar](100) NULL,
	[Fecha] [date] NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [AbrilClinica] SET  READ_WRITE 
GO
