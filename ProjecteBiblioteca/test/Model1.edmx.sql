
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/19/2018 17:27:22
-- Generated from EDMX file: C:\Users\Eduard Vila\Dropbox\DAM 2\M15\LaCasaDelLibro\ProjecteBiblioteca\test\Model1.edmx
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Sancio'
CREATE TABLE [dbo].[Sancio] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [dataSancio] datetime  NOT NULL,
    [idPrestec] int  NOT NULL,
    [Copias_Id] int  NOT NULL
);
GO

-- Creating table 'DiesNoHabils'
CREATE TABLE [dbo].[DiesNoHabils] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [data] datetime  NOT NULL
);
GO

-- Creating table 'LlistaEspera'
CREATE TABLE [dbo].[LlistaEspera] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [posicio] int  NOT NULL,
    [idLlibre] int  NOT NULL
);
GO

-- Creating table 'Llibre'
CREATE TABLE [dbo].[Llibre] (
    [ISBN] int IDENTITY(1,1) NOT NULL,
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

-- Creating table 'Prestecs'
CREATE TABLE [dbo].[Prestecs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdCopia] int  NOT NULL,
    [dataInici] datetime  NOT NULL,
    [Sancios_Id] int  NOT NULL
);
GO

-- Creating table 'Copias'
CREATE TABLE [dbo].[Copias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ISBN] int  NOT NULL,
    [dataIntroduccio] datetime  NOT NULL,
    [dataDarreraModificacio] datetime  NOT NULL,
    [dataBaixa] datetime  NOT NULL,
    [Llibre_ISBN] int  NOT NULL
);
GO

-- Creating table 'Socis'
CREATE TABLE [dbo].[Socis] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nom] nvarchar(max)  NOT NULL,
    [cognom] nvarchar(max)  NOT NULL,
    [dataIntroduccio] datetime  NOT NULL,
    [dataDarreraModificacio] datetime  NOT NULL,
    [dataBaixa] datetime  NOT NULL
);
GO

-- Creating table 'Autors'
CREATE TABLE [dbo].[Autors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Cognom] nvarchar(max)  NOT NULL,
    [dataIntroduccio] datetime  NOT NULL,
    [dataDarreraModificacio] datetime  NOT NULL,
    [dataBaixa] datetime  NOT NULL
);
GO

-- Creating table 'LlibreAutor'
CREATE TABLE [dbo].[LlibreAutor] (
    [Llibre_ISBN] int  NOT NULL,
    [Autors_Id] int  NOT NULL
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

-- Creating primary key on [Id] in table 'Sancio'
ALTER TABLE [dbo].[Sancio]
ADD CONSTRAINT [PK_Sancio]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DiesNoHabils'
ALTER TABLE [dbo].[DiesNoHabils]
ADD CONSTRAINT [PK_DiesNoHabils]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LlistaEspera'
ALTER TABLE [dbo].[LlistaEspera]
ADD CONSTRAINT [PK_LlistaEspera]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ISBN] in table 'Llibre'
ALTER TABLE [dbo].[Llibre]
ADD CONSTRAINT [PK_Llibre]
    PRIMARY KEY CLUSTERED ([ISBN] ASC);
GO

-- Creating primary key on [Id] in table 'Prestecs'
ALTER TABLE [dbo].[Prestecs]
ADD CONSTRAINT [PK_Prestecs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Copias'
ALTER TABLE [dbo].[Copias]
ADD CONSTRAINT [PK_Copias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Socis'
ALTER TABLE [dbo].[Socis]
ADD CONSTRAINT [PK_Socis]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Autors'
ALTER TABLE [dbo].[Autors]
ADD CONSTRAINT [PK_Autors]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Llibre_ISBN], [Autors_Id] in table 'LlibreAutor'
ALTER TABLE [dbo].[LlibreAutor]
ADD CONSTRAINT [PK_LlibreAutor]
    PRIMARY KEY CLUSTERED ([Llibre_ISBN], [Autors_Id] ASC);
GO

-- Creating primary key on [Sancio_Id], [Socis_Id] in table 'SancioSoci'
ALTER TABLE [dbo].[SancioSoci]
ADD CONSTRAINT [PK_SancioSoci]
    PRIMARY KEY CLUSTERED ([Sancio_Id], [Socis_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

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

-- Creating foreign key on [Llibre_ISBN] in table 'LlibreAutor'
ALTER TABLE [dbo].[LlibreAutor]
ADD CONSTRAINT [FK_LlibreAutor_Llibre]
    FOREIGN KEY ([Llibre_ISBN])
    REFERENCES [dbo].[Llibre]
        ([ISBN])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Autors_Id] in table 'LlibreAutor'
ALTER TABLE [dbo].[LlibreAutor]
ADD CONSTRAINT [FK_LlibreAutor_Autor]
    FOREIGN KEY ([Autors_Id])
    REFERENCES [dbo].[Autors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LlibreAutor_Autor'
CREATE INDEX [IX_FK_LlibreAutor_Autor]
ON [dbo].[LlibreAutor]
    ([Autors_Id]);
GO

-- Creating foreign key on [Llibre_ISBN] in table 'Copias'
ALTER TABLE [dbo].[Copias]
ADD CONSTRAINT [FK_LlibreCopia]
    FOREIGN KEY ([Llibre_ISBN])
    REFERENCES [dbo].[Llibre]
        ([ISBN])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LlibreCopia'
CREATE INDEX [IX_FK_LlibreCopia]
ON [dbo].[Copias]
    ([Llibre_ISBN]);
GO

-- Creating foreign key on [Copias_Id] in table 'Sancio'
ALTER TABLE [dbo].[Sancio]
ADD CONSTRAINT [FK_SancioCopia]
    FOREIGN KEY ([Copias_Id])
    REFERENCES [dbo].[Copias]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SancioCopia'
CREATE INDEX [IX_FK_SancioCopia]
ON [dbo].[Sancio]
    ([Copias_Id]);
GO

-- Creating foreign key on [Sancios_Id] in table 'Prestecs'
ALTER TABLE [dbo].[Prestecs]
ADD CONSTRAINT [FK_PrestecSancio]
    FOREIGN KEY ([Sancios_Id])
    REFERENCES [dbo].[Sancio]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PrestecSancio'
CREATE INDEX [IX_FK_PrestecSancio]
ON [dbo].[Prestecs]
    ([Sancios_Id]);
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
ADD CONSTRAINT [FK_SancioSoci_Soci]
    FOREIGN KEY ([Socis_Id])
    REFERENCES [dbo].[Socis]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SancioSoci_Soci'
CREATE INDEX [IX_FK_SancioSoci_Soci]
ON [dbo].[SancioSoci]
    ([Socis_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------