USE [master]
GO
/****** Object:  Database [Biblioteca]    Script Date: 24-Oct-18 20:39:58 ******/
CREATE DATABASE [Biblioteca]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Biblioteca', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Biblioteca.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Biblioteca_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Biblioteca_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Biblioteca] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Biblioteca].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Biblioteca] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Biblioteca] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Biblioteca] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Biblioteca] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Biblioteca] SET ARITHABORT OFF 
GO
ALTER DATABASE [Biblioteca] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Biblioteca] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Biblioteca] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Biblioteca] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Biblioteca] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Biblioteca] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Biblioteca] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Biblioteca] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Biblioteca] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Biblioteca] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Biblioteca] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Biblioteca] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Biblioteca] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Biblioteca] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Biblioteca] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Biblioteca] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Biblioteca] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Biblioteca] SET RECOVERY FULL 
GO
ALTER DATABASE [Biblioteca] SET  MULTI_USER 
GO
ALTER DATABASE [Biblioteca] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Biblioteca] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Biblioteca] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Biblioteca] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Biblioteca] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Biblioteca', N'ON'
GO
ALTER DATABASE [Biblioteca] SET QUERY_STORE = OFF
GO
USE [Biblioteca]
GO
/****** Object:  Table [dbo].[Autors]    Script Date: 24-Oct-18 20:39:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](max) NOT NULL,
	[Cognom] [nvarchar](max) NOT NULL,
	[dataIntroduccio] [datetime] NOT NULL,
	[dataDarreraModificacio] [datetime] NOT NULL,
	[dataBaixa] [datetime] NOT NULL,
 CONSTRAINT [PK_Autors] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Copias]    Script Date: 24-Oct-18 20:39:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Copias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ISBN] [nvarchar](50) NOT NULL,
	[dataIntroduccio] [datetime] NOT NULL,
	[dataDarreraModificacio] [datetime] NOT NULL,
	[dataBaixa] [datetime] NOT NULL,
	[Llibre_ISBN] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Copias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiaNoHabil]    Script Date: 24-Oct-18 20:39:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiaNoHabil](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[data] [datetime] NOT NULL,
 CONSTRAINT [PK_DiaNoHabil] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Llibre]    Script Date: 24-Oct-18 20:39:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Llibre](
	[ISBN] [nvarchar](50) NOT NULL,
	[Titol] [nvarchar](max) NOT NULL,
	[numPagines] [int] NOT NULL,
	[disponible] [bit] NOT NULL,
	[editorial] [nvarchar](max) NOT NULL,
	[dataIntroduccio] [datetime] NOT NULL,
	[dataDarreraModificacio] [datetime] NOT NULL,
	[dataBaixa] [datetime] NOT NULL,
	[LlistaEsperas_Id] [int] NOT NULL,
 CONSTRAINT [PK_Llibre] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LlibreAutor]    Script Date: 24-Oct-18 20:39:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LlibreAutor](
	[Llibre_ISBN] [nvarchar](50) NOT NULL,
	[Autors_Id] [int] NOT NULL,
 CONSTRAINT [PK_LlibreAutor] PRIMARY KEY CLUSTERED 
(
	[Llibre_ISBN] ASC,
	[Autors_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LlistaEspera]    Script Date: 24-Oct-18 20:39:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LlistaEspera](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[posicio] [int] NOT NULL,
	[idLlibre] [int] NOT NULL,
 CONSTRAINT [PK_LlistaEspera] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prestecs]    Script Date: 24-Oct-18 20:39:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prestecs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCopia] [int] NOT NULL,
	[dataInici] [datetime] NOT NULL,
	[Sancios_Id] [int] NOT NULL,
 CONSTRAINT [PK_Prestecs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sancio]    Script Date: 24-Oct-18 20:39:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sancio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[dataSancio] [datetime] NOT NULL,
	[idPrestec] [int] NOT NULL,
	[dataReturn] [datetime] NOT NULL,
	[dataFinal] [datetime] NOT NULL,
	[Copias_Id] [int] NOT NULL,
 CONSTRAINT [PK_Sancio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SancioSoci]    Script Date: 24-Oct-18 20:39:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SancioSoci](
	[Sancio_Id] [int] NOT NULL,
	[Socis_Id] [int] NOT NULL,
 CONSTRAINT [PK_SancioSoci] PRIMARY KEY CLUSTERED 
(
	[Sancio_Id] ASC,
	[Socis_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Socis]    Script Date: 24-Oct-18 20:39:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Socis](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [nvarchar](max) NOT NULL,
	[cognom] [nvarchar](max) NOT NULL,
	[dataIntroduccio] [datetime] NOT NULL,
	[dataDarreraModificacio] [datetime] NOT NULL,
	[dataBaixa] [datetime] NOT NULL,
 CONSTRAINT [PK_Socis] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_LlibreCopia]    Script Date: 24-Oct-18 20:39:59 ******/
CREATE NONCLUSTERED INDEX [IX_FK_LlibreCopia] ON [dbo].[Copias]
(
	[Llibre_ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_LlibreLlistaEspera]    Script Date: 24-Oct-18 20:39:59 ******/
CREATE NONCLUSTERED INDEX [IX_FK_LlibreLlistaEspera] ON [dbo].[Llibre]
(
	[LlistaEsperas_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_LlibreAutor_Autor]    Script Date: 24-Oct-18 20:39:59 ******/
CREATE NONCLUSTERED INDEX [IX_FK_LlibreAutor_Autor] ON [dbo].[LlibreAutor]
(
	[Autors_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_PrestecSancio]    Script Date: 24-Oct-18 20:39:59 ******/
CREATE NONCLUSTERED INDEX [IX_FK_PrestecSancio] ON [dbo].[Prestecs]
(
	[Sancios_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_SancioCopia]    Script Date: 24-Oct-18 20:39:59 ******/
CREATE NONCLUSTERED INDEX [IX_FK_SancioCopia] ON [dbo].[Sancio]
(
	[Copias_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_SancioSoci_Soci]    Script Date: 24-Oct-18 20:39:59 ******/
CREATE NONCLUSTERED INDEX [IX_FK_SancioSoci_Soci] ON [dbo].[SancioSoci]
(
	[Socis_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Copias]  WITH CHECK ADD  CONSTRAINT [FK_LlibreCopia] FOREIGN KEY([Llibre_ISBN])
REFERENCES [dbo].[Llibre] ([ISBN])
GO
ALTER TABLE [dbo].[Copias] CHECK CONSTRAINT [FK_LlibreCopia]
GO
ALTER TABLE [dbo].[Llibre]  WITH CHECK ADD  CONSTRAINT [FK_LlibreLlistaEspera] FOREIGN KEY([LlistaEsperas_Id])
REFERENCES [dbo].[LlistaEspera] ([Id])
GO
ALTER TABLE [dbo].[Llibre] CHECK CONSTRAINT [FK_LlibreLlistaEspera]
GO
ALTER TABLE [dbo].[LlibreAutor]  WITH CHECK ADD  CONSTRAINT [FK_LlibreAutor_Autor] FOREIGN KEY([Autors_Id])
REFERENCES [dbo].[Autors] ([Id])
GO
ALTER TABLE [dbo].[LlibreAutor] CHECK CONSTRAINT [FK_LlibreAutor_Autor]
GO
ALTER TABLE [dbo].[LlibreAutor]  WITH CHECK ADD  CONSTRAINT [FK_LlibreAutor_Llibre] FOREIGN KEY([Llibre_ISBN])
REFERENCES [dbo].[Llibre] ([ISBN])
GO
ALTER TABLE [dbo].[LlibreAutor] CHECK CONSTRAINT [FK_LlibreAutor_Llibre]
GO
ALTER TABLE [dbo].[Prestecs]  WITH CHECK ADD  CONSTRAINT [FK_PrestecSancio] FOREIGN KEY([Sancios_Id])
REFERENCES [dbo].[Sancio] ([Id])
GO
ALTER TABLE [dbo].[Prestecs] CHECK CONSTRAINT [FK_PrestecSancio]
GO
ALTER TABLE [dbo].[Sancio]  WITH CHECK ADD  CONSTRAINT [FK_SancioCopia] FOREIGN KEY([Copias_Id])
REFERENCES [dbo].[Copias] ([Id])
GO
ALTER TABLE [dbo].[Sancio] CHECK CONSTRAINT [FK_SancioCopia]
GO
ALTER TABLE [dbo].[SancioSoci]  WITH CHECK ADD  CONSTRAINT [FK_SancioSoci_Sancio] FOREIGN KEY([Sancio_Id])
REFERENCES [dbo].[Sancio] ([Id])
GO
ALTER TABLE [dbo].[SancioSoci] CHECK CONSTRAINT [FK_SancioSoci_Sancio]
GO
ALTER TABLE [dbo].[SancioSoci]  WITH CHECK ADD  CONSTRAINT [FK_SancioSoci_Soci] FOREIGN KEY([Socis_Id])
REFERENCES [dbo].[Socis] ([Id])
GO
ALTER TABLE [dbo].[SancioSoci] CHECK CONSTRAINT [FK_SancioSoci_Soci]
GO
USE [master]
GO
ALTER DATABASE [Biblioteca] SET  READ_WRITE 
GO
