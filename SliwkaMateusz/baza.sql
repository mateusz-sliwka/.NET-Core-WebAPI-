USE [master]
GO
/****** Object:  Database [DrivingSchool]    Script Date: 20.01.2020 17:49:55 ******/
CREATE DATABASE [DrivingSchool]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DrivingSchool', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\DrivingSchool.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DrivingSchool_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\DrivingSchool_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DrivingSchool] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DrivingSchool].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DrivingSchool] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DrivingSchool] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DrivingSchool] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DrivingSchool] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DrivingSchool] SET ARITHABORT OFF 
GO
ALTER DATABASE [DrivingSchool] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DrivingSchool] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DrivingSchool] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DrivingSchool] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DrivingSchool] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DrivingSchool] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DrivingSchool] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DrivingSchool] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DrivingSchool] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DrivingSchool] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DrivingSchool] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DrivingSchool] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DrivingSchool] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DrivingSchool] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DrivingSchool] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DrivingSchool] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [DrivingSchool] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DrivingSchool] SET RECOVERY FULL 
GO
ALTER DATABASE [DrivingSchool] SET  MULTI_USER 
GO
ALTER DATABASE [DrivingSchool] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DrivingSchool] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DrivingSchool] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DrivingSchool] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DrivingSchool] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DrivingSchool', N'ON'
GO
ALTER DATABASE [DrivingSchool] SET QUERY_STORE = OFF
GO
USE [DrivingSchool]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 20.01.2020 17:49:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 20.01.2020 17:49:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Brand] [nvarchar](max) NULL,
	[Model] [nvarchar](max) NULL,
	[Mileage] [int] NOT NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Instructors]    Script Date: 20.01.2020 17:49:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Instructors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Category] [nvarchar](max) NULL,
 CONSTRAINT [PK_Instructors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200120151755_Initial Create2', N'3.1.1')
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Mileage]) VALUES (3, N'Honda', N'Civic', 10000)
INSERT [dbo].[Cars] ([Id], [Brand], [Model], [Mileage]) VALUES (4, N'Subary', N'Impreza WRX STI', 42300)
SET IDENTITY_INSERT [dbo].[Cars] OFF
SET IDENTITY_INSERT [dbo].[Instructors] ON 

INSERT [dbo].[Instructors] ([Id], [FirstName], [LastName], [Category]) VALUES (2, N'Krzysztof2', N'Testowy2', N'B')
INSERT [dbo].[Instructors] ([Id], [FirstName], [LastName], [Category]) VALUES (3, N'Mateusz', N'Śliwka', N'A')
INSERT [dbo].[Instructors] ([Id], [FirstName], [LastName], [Category]) VALUES (4, N'Maciej', N'Kowalski', N'A2')
INSERT [dbo].[Instructors] ([Id], [FirstName], [LastName], [Category]) VALUES (5, N'Jan', N'Nowaki', N'A2')
INSERT [dbo].[Instructors] ([Id], [FirstName], [LastName], [Category]) VALUES (6, N'Janusz', N'Bamber', N'D')
SET IDENTITY_INSERT [dbo].[Instructors] OFF
USE [master]
GO
ALTER DATABASE [DrivingSchool] SET  READ_WRITE 
GO
