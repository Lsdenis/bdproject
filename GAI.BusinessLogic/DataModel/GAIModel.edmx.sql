
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 12/08/2013 22:35:00
-- Generated from EDMX file: E:\DropBox\Dropbox\College\БД и СУБД\GAI\GAI.BusinessLogic\DataModel\GAIModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GAI];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Inspection_Firm]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Inspections] DROP CONSTRAINT [FK_Inspection_Firm];
GO
IF OBJECT_ID(N'[dbo].[FK_Insurance_Firm]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Insurances] DROP CONSTRAINT [FK_Insurance_Firm];
GO
IF OBJECT_ID(N'[dbo].[FK_Inspection_Transport]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Inspections] DROP CONSTRAINT [FK_Inspection_Transport];
GO
IF OBJECT_ID(N'[dbo].[FK_Insurance_Transport]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Insurances] DROP CONSTRAINT [FK_Insurance_Transport];
GO
IF OBJECT_ID(N'[dbo].[FK_Offense_Offense_Type]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Offenses] DROP CONSTRAINT [FK_Offense_Offense_Type];
GO
IF OBJECT_ID(N'[dbo].[FK_Offense_Owner]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Offenses] DROP CONSTRAINT [FK_Offense_Owner];
GO
IF OBJECT_ID(N'[dbo].[FK_Transport_Owner]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transports] DROP CONSTRAINT [FK_Transport_Owner];
GO
IF OBJECT_ID(N'[dbo].[FK_Transport_PoliceDepartment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transports] DROP CONSTRAINT [FK_Transport_PoliceDepartment];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Firms]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Firms];
GO
IF OBJECT_ID(N'[dbo].[Inspections]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Inspections];
GO
IF OBJECT_ID(N'[dbo].[Insurances]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Insurances];
GO
IF OBJECT_ID(N'[dbo].[Offenses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Offenses];
GO
IF OBJECT_ID(N'[dbo].[Offense_Types]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Offense_Types];
GO
IF OBJECT_ID(N'[dbo].[Owners]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Owners];
GO
IF OBJECT_ID(N'[dbo].[PoliceDepartments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PoliceDepartments];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[Transports]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transports];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Firms'
CREATE TABLE [dbo].[Firms] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(max)  NULL,
    [City] varchar(max)  NULL,
    [Street] varchar(max)  NULL,
    [House] varchar(max)  NULL,
    [Owner_Name] varchar(max)  NULL,
    [Owner_Surname] varchar(max)  NULL,
    [Registration_Date] datetime  NULL,
    [Deleted] bit  NULL
);
GO

-- Creating table 'Inspections'
CREATE TABLE [dbo].[Inspections] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Id_Transport] int  NULL,
    [Id_Firm] int  NULL,
    [Inspection_Date] datetime  NULL,
    [Duration_Time] datetime  NULL,
    [Deleted] bit  NULL
);
GO

-- Creating table 'Insurances'
CREATE TABLE [dbo].[Insurances] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Id_Transport] int  NULL,
    [Id_Firm] int  NULL,
    [Start_Date] datetime  NULL,
    [End_Date] datetime  NULL,
    [Sum] int  NULL,
    [Type] varchar(max)  NULL,
    [Deleted] bit  NULL
);
GO

-- Creating table 'Offenses'
CREATE TABLE [dbo].[Offenses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Id_Owner] int  NULL,
    [Id_Offense] int  NULL,
    [Deleted] bit  NULL
);
GO

-- Creating table 'Offense_Types'
CREATE TABLE [dbo].[Offense_Types] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Type] varchar(max)  NULL,
    [Deleted] bit  NULL
);
GO

-- Creating table 'Owners'
CREATE TABLE [dbo].[Owners] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(max)  NULL,
    [Surname] varchar(max)  NULL,
    [Patronymic] varchar(max)  NULL,
    [City] varchar(max)  NULL,
    [District] varchar(max)  NULL,
    [Street] varchar(max)  NULL,
    [House] varchar(max)  NULL,
    [Flat] varchar(max)  NULL,
    [Deleted] bit  NULL
);
GO

-- Creating table 'PoliceDepartments'
CREATE TABLE [dbo].[PoliceDepartments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(max)  NULL,
    [Deleted] bit  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Transports'
CREATE TABLE [dbo].[Transports] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Id_Police_Department] int  NULL,
    [Id_Owner] int  NULL,
    [License_Plates] varchar(max)  NULL,
    [Brand_Model] varchar(max)  NULL,
    [Creation_Date] datetime  NULL,
    [Color] varchar(max)  NULL,
    [Carcass] int  NULL,
    [Type] varchar(max)  NULL,
    [Max_Weight] int  NULL,
    [Notes] varchar(max)  NULL,
    [Deleted] bit  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Firms'
ALTER TABLE [dbo].[Firms]
ADD CONSTRAINT [PK_Firms]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Inspections'
ALTER TABLE [dbo].[Inspections]
ADD CONSTRAINT [PK_Inspections]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Insurances'
ALTER TABLE [dbo].[Insurances]
ADD CONSTRAINT [PK_Insurances]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Offenses'
ALTER TABLE [dbo].[Offenses]
ADD CONSTRAINT [PK_Offenses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Offense_Types'
ALTER TABLE [dbo].[Offense_Types]
ADD CONSTRAINT [PK_Offense_Types]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Owners'
ALTER TABLE [dbo].[Owners]
ADD CONSTRAINT [PK_Owners]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PoliceDepartments'
ALTER TABLE [dbo].[PoliceDepartments]
ADD CONSTRAINT [PK_PoliceDepartments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [Id] in table 'Transports'
ALTER TABLE [dbo].[Transports]
ADD CONSTRAINT [PK_Transports]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Id_Firm] in table 'Inspections'
ALTER TABLE [dbo].[Inspections]
ADD CONSTRAINT [FK_Inspection_Firm]
    FOREIGN KEY ([Id_Firm])
    REFERENCES [dbo].[Firms]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Inspection_Firm'
CREATE INDEX [IX_FK_Inspection_Firm]
ON [dbo].[Inspections]
    ([Id_Firm]);
GO

-- Creating foreign key on [Id_Firm] in table 'Insurances'
ALTER TABLE [dbo].[Insurances]
ADD CONSTRAINT [FK_Insurance_Firm]
    FOREIGN KEY ([Id_Firm])
    REFERENCES [dbo].[Firms]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Insurance_Firm'
CREATE INDEX [IX_FK_Insurance_Firm]
ON [dbo].[Insurances]
    ([Id_Firm]);
GO

-- Creating foreign key on [Id_Transport] in table 'Inspections'
ALTER TABLE [dbo].[Inspections]
ADD CONSTRAINT [FK_Inspection_Transport]
    FOREIGN KEY ([Id_Transport])
    REFERENCES [dbo].[Transports]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Inspection_Transport'
CREATE INDEX [IX_FK_Inspection_Transport]
ON [dbo].[Inspections]
    ([Id_Transport]);
GO

-- Creating foreign key on [Id_Transport] in table 'Insurances'
ALTER TABLE [dbo].[Insurances]
ADD CONSTRAINT [FK_Insurance_Transport]
    FOREIGN KEY ([Id_Transport])
    REFERENCES [dbo].[Transports]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Insurance_Transport'
CREATE INDEX [IX_FK_Insurance_Transport]
ON [dbo].[Insurances]
    ([Id_Transport]);
GO

-- Creating foreign key on [Id_Offense] in table 'Offenses'
ALTER TABLE [dbo].[Offenses]
ADD CONSTRAINT [FK_Offense_Offense_Type]
    FOREIGN KEY ([Id_Offense])
    REFERENCES [dbo].[Offense_Types]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Offense_Offense_Type'
CREATE INDEX [IX_FK_Offense_Offense_Type]
ON [dbo].[Offenses]
    ([Id_Offense]);
GO

-- Creating foreign key on [Id_Owner] in table 'Offenses'
ALTER TABLE [dbo].[Offenses]
ADD CONSTRAINT [FK_Offense_Owner]
    FOREIGN KEY ([Id_Owner])
    REFERENCES [dbo].[Owners]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Offense_Owner'
CREATE INDEX [IX_FK_Offense_Owner]
ON [dbo].[Offenses]
    ([Id_Owner]);
GO

-- Creating foreign key on [Id_Owner] in table 'Transports'
ALTER TABLE [dbo].[Transports]
ADD CONSTRAINT [FK_Transport_Owner]
    FOREIGN KEY ([Id_Owner])
    REFERENCES [dbo].[Owners]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Transport_Owner'
CREATE INDEX [IX_FK_Transport_Owner]
ON [dbo].[Transports]
    ([Id_Owner]);
GO

-- Creating foreign key on [Id_Police_Department] in table 'Transports'
ALTER TABLE [dbo].[Transports]
ADD CONSTRAINT [FK_Transport_PoliceDepartment]
    FOREIGN KEY ([Id_Police_Department])
    REFERENCES [dbo].[PoliceDepartments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Transport_PoliceDepartment'
CREATE INDEX [IX_FK_Transport_PoliceDepartment]
ON [dbo].[Transports]
    ([Id_Police_Department]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------