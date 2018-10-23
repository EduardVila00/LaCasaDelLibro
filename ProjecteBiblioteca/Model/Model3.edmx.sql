
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/23/2018 18:13:03
-- Generated from EDMX file: C:\Users\Eduard Vila\Source\Repos\EduardVila00\LaCasaDelLibro\ProjecteBiblioteca\Model\Model2.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Biblioteca];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_LlibreAutor_Autor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LlibreAutor] DROP CONSTRAINT [FK_LlibreAutor_Autor];
GO
IF OBJECT_ID(N'[dbo].[FK_LlibreAutor_Llibre]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LlibreAutor] DROP CONSTRAINT [FK_LlibreAutor_Llibre];
GO
IF OBJECT_ID(N'[dbo].[FK_LlibreCopia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Copias] DROP CONSTRAINT [FK_LlibreCopia];
GO
IF OBJECT_ID(N'[dbo].[FK_LlibreLlistaEspera]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Llibre] DROP CONSTRAINT [FK_LlibreLlistaEspera];
GO
IF OBJECT_ID(N'[dbo].[FK_PrestecSancio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Prestecs] DROP CONSTRAINT [FK_PrestecSancio];
GO
IF OBJECT_ID(N'[dbo].[FK_SancioCopia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sancio] DROP CONSTRAINT [FK_SancioCopia];
GO
IF OBJECT_ID(N'[dbo].[FK_SancioSoci_Sancio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SancioSoci] DROP CONSTRAINT [FK_SancioSoci_Sancio];
GO
IF OBJECT_ID(N'[dbo].[FK_SancioSoci_Soci]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SancioSoci] DROP CONSTRAINT [FK_SancioSoci_Soci];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Autors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Autors];
GO
IF OBJECT_ID(N'[dbo].[Copias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Copias];
GO
IF OBJECT_ID(N'[dbo].[DiesNoHabils]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DiesNoHabils];
GO
IF OBJECT_ID(N'[dbo].[Llibre]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Llibre];
GO
IF OBJECT_ID(N'[dbo].[LlibreAutor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LlibreAutor];
GO
IF OBJECT_ID(N'[dbo].[LlistaEspera]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LlistaEspera];
GO
IF OBJECT_ID(N'[dbo].[Prestecs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Prestecs];
GO
IF OBJECT_ID(N'[dbo].[Sancio]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sancio];
GO
IF OBJECT_ID(N'[dbo].[SancioSoci]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SancioSoci];
GO
IF OBJECT_ID(N'[dbo].[Socis]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Socis];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Autor'
CREATE TABLE [dbo].[Autor] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Cognom] nvarchar(max)  NOT NULL,
    [dataIntroduccio] datetime  NOT NULL,
    [dataDarreraModificacio] datetime  NOT NULL,
    [dataBaixa] datetime  NOT NULL
);
GO

-- Creating table 'Copia'
CREATE TABLE [dbo].[Copia] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ISBN] nvarchar(max)  NOT NULL,
    [dataIntroduccio] datetime  NOT NULL,
    [dataDarreraModificacio] datetime  NOT NULL,
    [dataBaixa] datetime  NOT NULL,
    [Llibre_ISBN] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DiaNoHabil'
CREATE TABLE [dbo].[DiaNoHabil] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [data] datetime  NOT NULL
);
GO

-- Creating table 'Llibre'
CREATE TABLE [dbo].[Llibre] (
    [ISBN] nvarchar(max)  NOT NULL,
    [Titol] nvarchar(max)  NOT NULL,
    [numPagines] int  NOT NULL,
    [disponible] bit  NOT NULL,
    [editorial] nvarchar(max)  NOT NULL,
    [dataIntroduccio] datetime  NOT NULL,
    [dataDarreraModificacio] datetime  NOT NULL,
    [dataBaixa] datetime  NOT NULL,
    [LlistaEsperas_Id] int  NOT NULL
);
GO

-- Creating table 'LlistaEspera'
CREATE TABLE [dbo].[LlistaEspera] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [posicio] int  NOT NULL,
    [idLlibre] int  NOT NULL
);
GO

-- Creating table 'Prestec'
CREATE TABLE [dbo].[Prestec] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdCopia] int  NOT NULL,
    [dataInici] datetime  NOT NULL,
    [dataFinal] datetime  NOT NULL,
    [dataReal] datetime  NOT NULL,
    [Sancios_Id] int  NOT NULL
);
GO

-- Creating table 'Sancio'
CREATE TABLE [dbo].[Sancio] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [dataSancio] datetime  NOT NULL,
    [idPrestec] int  NOT NULL,
    [Copias_Id] int  NOT NULL
);
GO

-- Creating table 'Soci'
CREATE TABLE [dbo].[Soci] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nom] nvarchar(max)  NOT NULL,
    [cognom] nvarchar(max)  NOT NULL,
    [dataIntroduccio] datetime  NOT NULL,
    [dataDarreraModificacio] datetime  NOT NULL,
    [dataBaixa] datetime  NOT NULL
);
GO

-- Creating table 'LlibreAutor'
CREATE TABLE [dbo].[LlibreAutor] (
    [Autors_Id] int  NOT NULL,
    [Llibre_ISBN] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SancioSoci'
CREATE TABLE [dbo].[SancioSoci] (
    [Sancio_Id] int  NOT NULL,
    [Socis_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Autor'
ALTER TABLE [dbo].[Autor]
ADD CONSTRAINT [PK_Autor]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Copia'
ALTER TABLE [dbo].[Copia]
ADD CONSTRAINT [PK_Copia]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DiaNoHabil'
ALTER TABLE [dbo].[DiaNoHabil]
ADD CONSTRAINT [PK_DiaNoHabil]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ISBN] in table 'Llibre'
ALTER TABLE [dbo].[Llibre]
ADD CONSTRAINT [PK_Llibre]
    PRIMARY KEY CLUSTERED ([ISBN] ASC);
GO

-- Creating primary key on [Id] in table 'LlistaEspera'
ALTER TABLE [dbo].[LlistaEspera]
ADD CONSTRAINT [PK_LlistaEspera]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Prestec'
ALTER TABLE [dbo].[Prestec]
ADD CONSTRAINT [PK_Prestec]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sancio'
ALTER TABLE [dbo].[Sancio]
ADD CONSTRAINT [PK_Sancio]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Soci'
ALTER TABLE [dbo].[Soci]
ADD CONSTRAINT [PK_Soci]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Autors_Id], [Llibre_ISBN] in table 'LlibreAutor'
ALTER TABLE [dbo].[LlibreAutor]
ADD CONSTRAINT [PK_LlibreAutor]
    PRIMARY KEY CLUSTERED ([Autors_Id], [Llibre_ISBN] ASC);
GO

-- Creating primary key on [Sancio_Id], [Socis_Id] in table 'SancioSoci'
ALTER TABLE [dbo].[SancioSoci]
ADD CONSTRAINT [PK_SancioSoci]
    PRIMARY KEY CLUSTERED ([Sancio_Id], [Socis_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Llibre_ISBN] in table 'Copia'
ALTER TABLE [dbo].[Copia]
ADD CONSTRAINT [FK_LlibreCopia]
    FOREIGN KEY ([Llibre_ISBN])
    REFERENCES [dbo].[Llibre]
        ([ISBN])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LlibreCopia'
CREATE INDEX [IX_FK_LlibreCopia]
ON [dbo].[Copia]
    ([Llibre_ISBN]);
GO

-- Creating foreign key on [Copias_Id] in table 'Sancio'
ALTER TABLE [dbo].[Sancio]
ADD CONSTRAINT [FK_SancioCopia]
    FOREIGN KEY ([Copias_Id])
    REFERENCES [dbo].[Copia]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SancioCopia'
CREATE INDEX [IX_FK_SancioCopia]
ON [dbo].[Sancio]
    ([Copias_Id]);
GO

-- Creating foreign key on [LlistaEsperas_Id] in table 'Llibre'
ALTER TABLE [dbo].[Llibre]
ADD CONSTRAINT [FK_LlibreLlistaEspera]
    FOREIGN KEY ([LlistaEsperas_Id])
    REFERENCES [dbo].[LlistaEspera]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LlibreLlistaEspera'
CREATE INDEX [IX_FK_LlibreLlistaEspera]
ON [dbo].[Llibre]
    ([LlistaEsperas_Id]);
GO

-- Creating foreign key on [Sancios_Id] in table 'Prestec'
ALTER TABLE [dbo].[Prestec]
ADD CONSTRAINT [FK_PrestecSancio]
    FOREIGN KEY ([Sancios_Id])
    REFERENCES [dbo].[Sancio]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PrestecSancio'
CREATE INDEX [IX_FK_PrestecSancio]
ON [dbo].[Prestec]
    ([Sancios_Id]);
GO

-- Creating foreign key on [Autors_Id] in table 'LlibreAutor'
ALTER TABLE [dbo].[LlibreAutor]
ADD CONSTRAINT [FK_LlibreAutor_Autors]
    FOREIGN KEY ([Autors_Id])
    REFERENCES [dbo].[Autor]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Llibre_ISBN] in table 'LlibreAutor'
ALTER TABLE [dbo].[LlibreAutor]
ADD CONSTRAINT [FK_LlibreAutor_Llibre]
    FOREIGN KEY ([Llibre_ISBN])
    REFERENCES [dbo].[Llibre]
        ([ISBN])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LlibreAutor_Llibre'
CREATE INDEX [IX_FK_LlibreAutor_Llibre]
ON [dbo].[LlibreAutor]
    ([Llibre_ISBN]);
GO

-- Creating foreign key on [Sancio_Id] in table 'SancioSoci'
ALTER TABLE [dbo].[SancioSoci]
ADD CONSTRAINT [FK_SancioSoci_Sancio]
    FOREIGN KEY ([Sancio_Id])
    REFERENCES [dbo].[Sancio]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Socis_Id] in table 'SancioSoci'
ALTER TABLE [dbo].[SancioSoci]
ADD CONSTRAINT [FK_SancioSoci_Socis]
    FOREIGN KEY ([Socis_Id])
    REFERENCES [dbo].[Soci]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SancioSoci_Socis'
CREATE INDEX [IX_FK_SancioSoci_Socis]
ON [dbo].[SancioSoci]
    ([Socis_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------