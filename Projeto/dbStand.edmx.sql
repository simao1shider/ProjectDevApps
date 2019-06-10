
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/08/2019 18:16:08
-- Generated from EDMX file: C:\Users\Simão Marques\OneDrive\TESP_PSI\Desenvolvimento de Aplicações\Projeto\ProjectDevApps\Projeto\dbStand.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [dbStand];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ServicoParcela]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ParcelaSet] DROP CONSTRAINT [FK_ServicoParcela];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroOfficinaServico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ServicoSet] DROP CONSTRAINT [FK_CarroOfficinaServico];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteCarroOfficina]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarroSet_CarroOfficina] DROP CONSTRAINT [FK_ClienteCarroOfficina];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VendaSet] DROP CONSTRAINT [FK_ClienteVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_VendaCarroVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VendaSet] DROP CONSTRAINT [FK_VendaCarroVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroAluguerAluguer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AluguerSet] DROP CONSTRAINT [FK_CarroAluguerAluguer];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteAluguer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AluguerSet] DROP CONSTRAINT [FK_ClienteAluguer];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroOfficina_inherits_Carro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarroSet_CarroOfficina] DROP CONSTRAINT [FK_CarroOfficina_inherits_Carro];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroVenda_inherits_Carro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarroSet_CarroVenda] DROP CONSTRAINT [FK_CarroVenda_inherits_Carro];
GO
IF OBJECT_ID(N'[dbo].[FK_CarroAluguer_inherits_Carro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarroSet_CarroAluguer] DROP CONSTRAINT [FK_CarroAluguer_inherits_Carro];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ServicoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ServicoSet];
GO
IF OBJECT_ID(N'[dbo].[AluguerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AluguerSet];
GO
IF OBJECT_ID(N'[dbo].[ParcelaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ParcelaSet];
GO
IF OBJECT_ID(N'[dbo].[CarroSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarroSet];
GO
IF OBJECT_ID(N'[dbo].[ClienteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClienteSet];
GO
IF OBJECT_ID(N'[dbo].[VendaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VendaSet];
GO
IF OBJECT_ID(N'[dbo].[CarroSet_CarroOfficina]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarroSet_CarroOfficina];
GO
IF OBJECT_ID(N'[dbo].[CarroSet_CarroVenda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarroSet_CarroVenda];
GO
IF OBJECT_ID(N'[dbo].[CarroSet_CarroAluguer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarroSet_CarroAluguer];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ServicoSet'
CREATE TABLE [dbo].[ServicoSet] (
    [IdServicos] int IDENTITY(1,1) NOT NULL,
    [DataEntrada] datetime  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [DataSaida] datetime  NOT NULL,
    [CarroOfficina_IdCarro] int  NOT NULL
);
GO

-- Creating table 'AluguerSet'
CREATE TABLE [dbo].[AluguerSet] (
    [IdAluguer] int IDENTITY(1,1) NOT NULL,
    [DataInicio] datetime  NOT NULL,
    [DataFim] datetime  NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Kms] int  NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [CarroAluguer_IdCarro] int  NOT NULL
);
GO

-- Creating table 'ParcelaSet'
CREATE TABLE [dbo].[ParcelaSet] (
    [IdParcela] int IDENTITY(1,1) NOT NULL,
    [Valor] decimal(18,2)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [ServicoIdServicos] nvarchar(max)  NOT NULL,
    [ServicoIdServicos1] int  NOT NULL
);
GO

-- Creating table 'CarroSet'
CREATE TABLE [dbo].[CarroSet] (
    [IdCarro] int IDENTITY(1,1) NOT NULL,
    [NumeroChassis] nvarchar(max)  NOT NULL,
    [Marca] nvarchar(max)  NOT NULL,
    [Modelo] nvarchar(max)  NOT NULL,
    [Combustivel] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ClienteSet'
CREATE TABLE [dbo].[ClienteSet] (
    [IdCliente] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [NIF] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Contacto] int  NOT NULL
);
GO

-- Creating table 'VendaSet'
CREATE TABLE [dbo].[VendaSet] (
    [IdVenda] int IDENTITY(1,1) NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [Data] datetime  NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [CarroVenda_IdCarro] int  NOT NULL
);
GO

-- Creating table 'CarroSet_CarroOfficina'
CREATE TABLE [dbo].[CarroSet_CarroOfficina] (
    [Matricula] nvarchar(max)  NOT NULL,
    [Kms] int  NOT NULL,
    [ClienteIdCliente] int  NOT NULL,
    [IdCarro] int  NOT NULL
);
GO

-- Creating table 'CarroSet_CarroVenda'
CREATE TABLE [dbo].[CarroSet_CarroVenda] (
    [Extras] nvarchar(max)  NOT NULL,
    [IdCarro] int  NOT NULL
);
GO

-- Creating table 'CarroSet_CarroAluguer'
CREATE TABLE [dbo].[CarroSet_CarroAluguer] (
    [Estado] nvarchar(max)  NOT NULL,
    [Matricula] nvarchar(max)  NOT NULL,
    [IdCarro] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdServicos] in table 'ServicoSet'
ALTER TABLE [dbo].[ServicoSet]
ADD CONSTRAINT [PK_ServicoSet]
    PRIMARY KEY CLUSTERED ([IdServicos] ASC);
GO

-- Creating primary key on [IdAluguer] in table 'AluguerSet'
ALTER TABLE [dbo].[AluguerSet]
ADD CONSTRAINT [PK_AluguerSet]
    PRIMARY KEY CLUSTERED ([IdAluguer] ASC);
GO

-- Creating primary key on [IdParcela] in table 'ParcelaSet'
ALTER TABLE [dbo].[ParcelaSet]
ADD CONSTRAINT [PK_ParcelaSet]
    PRIMARY KEY CLUSTERED ([IdParcela] ASC);
GO

-- Creating primary key on [IdCarro] in table 'CarroSet'
ALTER TABLE [dbo].[CarroSet]
ADD CONSTRAINT [PK_CarroSet]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdCliente] in table 'ClienteSet'
ALTER TABLE [dbo].[ClienteSet]
ADD CONSTRAINT [PK_ClienteSet]
    PRIMARY KEY CLUSTERED ([IdCliente] ASC);
GO

-- Creating primary key on [IdVenda] in table 'VendaSet'
ALTER TABLE [dbo].[VendaSet]
ADD CONSTRAINT [PK_VendaSet]
    PRIMARY KEY CLUSTERED ([IdVenda] ASC);
GO

-- Creating primary key on [IdCarro] in table 'CarroSet_CarroOfficina'
ALTER TABLE [dbo].[CarroSet_CarroOfficina]
ADD CONSTRAINT [PK_CarroSet_CarroOfficina]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdCarro] in table 'CarroSet_CarroVenda'
ALTER TABLE [dbo].[CarroSet_CarroVenda]
ADD CONSTRAINT [PK_CarroSet_CarroVenda]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- Creating primary key on [IdCarro] in table 'CarroSet_CarroAluguer'
ALTER TABLE [dbo].[CarroSet_CarroAluguer]
ADD CONSTRAINT [PK_CarroSet_CarroAluguer]
    PRIMARY KEY CLUSTERED ([IdCarro] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ServicoIdServicos1] in table 'ParcelaSet'
ALTER TABLE [dbo].[ParcelaSet]
ADD CONSTRAINT [FK_ServicoParcela]
    FOREIGN KEY ([ServicoIdServicos1])
    REFERENCES [dbo].[ServicoSet]
        ([IdServicos])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServicoParcela'
CREATE INDEX [IX_FK_ServicoParcela]
ON [dbo].[ParcelaSet]
    ([ServicoIdServicos1]);
GO

-- Creating foreign key on [CarroOfficina_IdCarro] in table 'ServicoSet'
ALTER TABLE [dbo].[ServicoSet]
ADD CONSTRAINT [FK_CarroOfficinaServico]
    FOREIGN KEY ([CarroOfficina_IdCarro])
    REFERENCES [dbo].[CarroSet_CarroOfficina]
        ([IdCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarroOfficinaServico'
CREATE INDEX [IX_FK_CarroOfficinaServico]
ON [dbo].[ServicoSet]
    ([CarroOfficina_IdCarro]);
GO

-- Creating foreign key on [ClienteIdCliente] in table 'CarroSet_CarroOfficina'
ALTER TABLE [dbo].[CarroSet_CarroOfficina]
ADD CONSTRAINT [FK_ClienteCarroOfficina]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[ClienteSet]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCarroOfficina'
CREATE INDEX [IX_FK_ClienteCarroOfficina]
ON [dbo].[CarroSet_CarroOfficina]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [ClienteIdCliente] in table 'VendaSet'
ALTER TABLE [dbo].[VendaSet]
ADD CONSTRAINT [FK_ClienteVenda]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[ClienteSet]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteVenda'
CREATE INDEX [IX_FK_ClienteVenda]
ON [dbo].[VendaSet]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [CarroVenda_IdCarro] in table 'VendaSet'
ALTER TABLE [dbo].[VendaSet]
ADD CONSTRAINT [FK_VendaCarroVenda]
    FOREIGN KEY ([CarroVenda_IdCarro])
    REFERENCES [dbo].[CarroSet_CarroVenda]
        ([IdCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VendaCarroVenda'
CREATE INDEX [IX_FK_VendaCarroVenda]
ON [dbo].[VendaSet]
    ([CarroVenda_IdCarro]);
GO

-- Creating foreign key on [CarroAluguer_IdCarro] in table 'AluguerSet'
ALTER TABLE [dbo].[AluguerSet]
ADD CONSTRAINT [FK_CarroAluguerAluguer]
    FOREIGN KEY ([CarroAluguer_IdCarro])
    REFERENCES [dbo].[CarroSet_CarroAluguer]
        ([IdCarro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarroAluguerAluguer'
CREATE INDEX [IX_FK_CarroAluguerAluguer]
ON [dbo].[AluguerSet]
    ([CarroAluguer_IdCarro]);
GO

-- Creating foreign key on [ClienteIdCliente] in table 'AluguerSet'
ALTER TABLE [dbo].[AluguerSet]
ADD CONSTRAINT [FK_ClienteAluguer]
    FOREIGN KEY ([ClienteIdCliente])
    REFERENCES [dbo].[ClienteSet]
        ([IdCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteAluguer'
CREATE INDEX [IX_FK_ClienteAluguer]
ON [dbo].[AluguerSet]
    ([ClienteIdCliente]);
GO

-- Creating foreign key on [IdCarro] in table 'CarroSet_CarroOfficina'
ALTER TABLE [dbo].[CarroSet_CarroOfficina]
ADD CONSTRAINT [FK_CarroOfficina_inherits_Carro]
    FOREIGN KEY ([IdCarro])
    REFERENCES [dbo].[CarroSet]
        ([IdCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCarro] in table 'CarroSet_CarroVenda'
ALTER TABLE [dbo].[CarroSet_CarroVenda]
ADD CONSTRAINT [FK_CarroVenda_inherits_Carro]
    FOREIGN KEY ([IdCarro])
    REFERENCES [dbo].[CarroSet]
        ([IdCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCarro] in table 'CarroSet_CarroAluguer'
ALTER TABLE [dbo].[CarroSet_CarroAluguer]
ADD CONSTRAINT [FK_CarroAluguer_inherits_Carro]
    FOREIGN KEY ([IdCarro])
    REFERENCES [dbo].[CarroSet]
        ([IdCarro])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------