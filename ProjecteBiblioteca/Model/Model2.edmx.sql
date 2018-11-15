
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/15/2018 19:31:16
-- Generated from EDMX file: C:\Users\Eduard Vila\Source\Repos\EduardVila00\LaCasaDelLibro\ProjecteBiblioteca\Model\Model1.edmx
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

IF OBJECT_ID(N'[dbo].[FK_AutorLlibre]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Llibre] DROP CONSTRAINT [FK_AutorLlibre];
GO
IF OBJECT_ID(N'[dbo].[FK_CopiaPrestec]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Prestec] DROP CONSTRAINT [FK_CopiaPrestec];
GO
IF OBJECT_ID(N'[dbo].[FK_LlibreCopia]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Copia] DROP CONSTRAINT [FK_LlibreCopia];
GO
IF OBJECT_ID(N'[dbo].[FK_LlibreLlistaEspera]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LlistaEspera] DROP CONSTRAINT [FK_LlibreLlistaEspera];
GO
IF OBJECT_ID(N'[dbo].[FK_PrestecSocis]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Prestec] DROP CONSTRAINT [FK_PrestecSocis];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Autor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Autor];
GO
IF OBJECT_ID(N'[dbo].[Copia]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Copia];
GO
IF OBJECT_ID(N'[dbo].[DiaNoHabil]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DiaNoHabil];
GO
IF OBJECT_ID(N'[dbo].[Llibre]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Llibre];
GO
IF OBJECT_ID(N'[dbo].[LlistaEspera]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LlistaEspera];
GO
IF OBJECT_ID(N'[dbo].[Prestec]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Prestec];
GO
IF OBJECT_ID(N'[dbo].[Soci]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Soci];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Autor'
CREATE TABLE [dbo].[Autor] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nom] nvarchar(50)  NOT NULL,
    [cognoms] nvarchar(50)  NOT NULL,
    [dataIntroduccio] datetime  NOT NULL,
    [dataDarreraModificacio] datetime  NOT NULL,
    [dataBaixa] datetime  NULL
);
GO

-- Creating table 'Copia'
CREATE TABLE [dbo].[Copia] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [disponible] bit  NOT NULL,
    [dataIntroduccio] datetime  NOT NULL,
    [dataDarreraModificacio] datetime  NOT NULL,
    [dataBaixa] datetime  NULL,
    [LlibreIsbn] nvarchar(50)  NOT NULL
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
    [Isbn] nvarchar(50)  NOT NULL,
    [titol] nvarchar(50)  NOT NULL,
    [numPagines] int  NOT NULL,
    [editorial] nvarchar(50)  NOT NULL,
    [idioma] nvarchar(50)  NOT NULL,
    [dataIntroduccio] datetime  NOT NULL,
    [dataDarreraModificacio] datetime  NOT NULL,
    [dataBaixa] datetime  NULL
);
GO

-- Creating table 'LlistaEspera'
CREATE TABLE [dbo].[LlistaEspera] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LlibreIsbn] nvarchar(50)  NOT NULL,
    [idSoci] int  NOT NULL
);
GO

-- Creating table 'Prestec'
CREATE TABLE [dbo].[Prestec] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [dataInici] datetime  NOT NULL,
    [dataFinal] datetime  NOT NULL,
    [dataRetorn] datetime  NULL,
    [CopiaId] int  NOT NULL,
    [SocisId] int  NOT NULL
);
GO

-- Creating table 'Soci'
CREATE TABLE [dbo].[Soci] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nom] nvarchar(50)  NOT NULL,
    [cognoms] nvarchar(50)  NOT NULL,
    [dataIntroduccio] datetime  NOT NULL,
    [dataDarreraModificacio] datetime  NOT NULL,
    [dataBaixa] datetime  NULL
);
GO

-- Creating table 'AutorLlibre'
CREATE TABLE [dbo].[AutorLlibre] (
    [Autor_Id] int  NOT NULL,
    [Llibre_Isbn] nvarchar(50)  NOT NULL
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

-- Creating primary key on [Isbn] in table 'Llibre'
ALTER TABLE [dbo].[Llibre]
ADD CONSTRAINT [PK_Llibre]
    PRIMARY KEY CLUSTERED ([Isbn] ASC);
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

-- Creating primary key on [Id] in table 'Soci'
ALTER TABLE [dbo].[Soci]
ADD CONSTRAINT [PK_Soci]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Autor_Id], [Llibre_Isbn] in table 'AutorLlibre'
ALTER TABLE [dbo].[AutorLlibre]
ADD CONSTRAINT [PK_AutorLlibre]
    PRIMARY KEY CLUSTERED ([Autor_Id], [Llibre_Isbn] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CopiaId] in table 'Prestec'
ALTER TABLE [dbo].[Prestec]
ADD CONSTRAINT [FK_CopiaPrestec]
    FOREIGN KEY ([CopiaId])
    REFERENCES [dbo].[Copia]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CopiaPrestec'
CREATE INDEX [IX_FK_CopiaPrestec]
ON [dbo].[Prestec]
    ([CopiaId]);
GO

-- Creating foreign key on [LlibreIsbn] in table 'Copia'
ALTER TABLE [dbo].[Copia]
ADD CONSTRAINT [FK_LlibreCopia]
    FOREIGN KEY ([LlibreIsbn])
    REFERENCES [dbo].[Llibre]
        ([Isbn])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LlibreCopia'
CREATE INDEX [IX_FK_LlibreCopia]
ON [dbo].[Copia]
    ([LlibreIsbn]);
GO

-- Creating foreign key on [LlibreIsbn] in table 'LlistaEspera'
ALTER TABLE [dbo].[LlistaEspera]
ADD CONSTRAINT [FK_LlibreLlistaEspera]
    FOREIGN KEY ([LlibreIsbn])
    REFERENCES [dbo].[Llibre]
        ([Isbn])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LlibreLlistaEspera'
CREATE INDEX [IX_FK_LlibreLlistaEspera]
ON [dbo].[LlistaEspera]
    ([LlibreIsbn]);
GO

-- Creating foreign key on [SocisId] in table 'Prestec'
ALTER TABLE [dbo].[Prestec]
ADD CONSTRAINT [FK_PrestecSocis]
    FOREIGN KEY ([SocisId])
    REFERENCES [dbo].[Soci]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PrestecSocis'
CREATE INDEX [IX_FK_PrestecSocis]
ON [dbo].[Prestec]
    ([SocisId]);
GO

-- Creating foreign key on [Autor_Id] in table 'AutorLlibre'
ALTER TABLE [dbo].[AutorLlibre]
ADD CONSTRAINT [FK_AutorLlibre_Autor]
    FOREIGN KEY ([Autor_Id])
    REFERENCES [dbo].[Autor]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Llibre_Isbn] in table 'AutorLlibre'
ALTER TABLE [dbo].[AutorLlibre]
ADD CONSTRAINT [FK_AutorLlibre_Llibre]
    FOREIGN KEY ([Llibre_Isbn])
    REFERENCES [dbo].[Llibre]
        ([Isbn])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AutorLlibre_Llibre'
CREATE INDEX [IX_FK_AutorLlibre_Llibre]
ON [dbo].[AutorLlibre]
    ([Llibre_Isbn]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------