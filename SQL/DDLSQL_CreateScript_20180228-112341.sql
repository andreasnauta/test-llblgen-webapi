﻿
-- ----------------------------------------------------------------------------------------------------------------
-- Generated by LLBLGen Pro v5.3  Build: 5.3.2
-- SQL Server DDL Script generated from project: Simple Model
-- Project filename: C:\Development\test-llblgen-webapi\Simple Model.llblgenproj
-- Script generated on: 28-feb-2018 11:23.41
--
-- This is a Create script for creating a NEW data model. If you want DDL SQL for updating an existing model,
-- please create an Update script instead. 
--
-- This script might create schemas, which requires you to assign a proper user to the schema. Adjust the CREATE SCHEMA
-- statements below, if any, to avoid errors at runtime. Schemas aren't dropped in the DROP section.
--
--      >>>>> WARNING <<<<<
--      This is a CREATE script, with DROP statements for the existing tables, foreign keys and other constraints
--      This means that existing tables, data, constraints and other elements in the catalog/schemas addressed
--      are deleted. Use this Create script only to create new schemas with tables/constraints and other elements.
--
-- ----------------------------------------------------------------------------------------------------------------
-- ###############################################################################################################
-- DROP statements for existing elements. 
-- ###############################################################################################################
-- DROP statements for dropping existing elements with the same names as the ones created are commented out below. 
-- If you want to enable these statements for DROPping the existing elements first (which will remove all the data
-- in these existing elements), uncomment these statements by removing the two comment markers /* and */

-- Remove the comment marker on the NEXT line to enable DROP statements to remove existing elements
/* 

USE [SimpleModel]
GO
*/
-- Remove the comment marker on the PREVIOUS line to enable DROP statements to remove existing elements

-- ###############################################################################################################
-- Create statements for catalogs, schemas, tables and sequences
-- ###############################################################################################################
-- ----------------------------------------------------------------------------------------------------------------
-- Catalog 'SimpleModel'
-- ----------------------------------------------------------------------------------------------------------------

USE master
GO
CREATE DATABASE [SimpleModel] /* ON PRIMARY (NAME=SimpleModel_dat, FILENAME='c:\mycatalogs\SimpleModel.mdf', SIZE=10MB) */
GO


USE [SimpleModel]
GO
-- ----------------------------------------------------------------------------------------------------------------
-- Schema 'Core'
-- ----------------------------------------------------------------------------------------------------------------

CREATE SCHEMA [Core] /* AUTHORIZATION owner_name */
GO

-- -------[ Tables ]-----------------------------------------------------------------------------------------------

CREATE TABLE [Core].[Collection] 
(
	[Id] [int] IDENTITY (1,1) NOT NULL, 
	[Name] [nvarchar] (MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL 
)
GO

CREATE TABLE [Core].[Item] 
(
	[CollectionId] [int] NOT NULL, 
	[Description] [nvarchar] (MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL, 
	[Id] [int] IDENTITY (1,1) NOT NULL 
)
GO
-- ----------------------------------------------------------------------------------------------------------------
-- Schema 'Domain'
-- ----------------------------------------------------------------------------------------------------------------

CREATE SCHEMA [Domain] /* AUTHORIZATION owner_name */
GO

-- -------[ Tables ]-----------------------------------------------------------------------------------------------

CREATE TABLE [Domain].[DomainItem] 
(
	[Id] [int] NOT NULL, 
	[OldItemId] [int] NOT NULL 
)
GO
-- ----------------------------------------------------------------------------------------------------------------
-- Schema 'Specific'
-- ----------------------------------------------------------------------------------------------------------------

CREATE SCHEMA [Specific] /* AUTHORIZATION owner_name */
GO

-- -------[ Tables ]-----------------------------------------------------------------------------------------------

CREATE TABLE [Specific].[SpecificItem] 
(
	[Id] [int] NOT NULL, 
	[Note] [nvarchar] (MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL 
)
GO

-- ###############################################################################################################
-- Create statements for Primary key constraints, Foreign key constraints, Unique constraints and Default Values
-- ###############################################################################################################
-- ----------------------------------------------------------------------------------------------------------------
-- Catalog 'SimpleModel'
-- ----------------------------------------------------------------------------------------------------------------

USE [SimpleModel]
GO
-- ----------------------------------------------------------------------------------------------------------------
-- Primary Key constraints for schema 'Core'
-- ----------------------------------------------------------------------------------------------------------------

ALTER TABLE [Core].[Collection] WITH NOCHECK 
	ADD CONSTRAINT [PK_8d10ad74c2cb5e6ab8b97a4bd49] PRIMARY KEY CLUSTERED 
	( 
		[Id] 
	)
GO

ALTER TABLE [Core].[Item] WITH NOCHECK 
	ADD CONSTRAINT [PK_afcd35a4a4b958670d1128179e5] PRIMARY KEY CLUSTERED 
	( 
		[Id] 
	)
GO
-- ----------------------------------------------------------------------------------------------------------------
-- Unique constraints for schema 'Core'
-- ----------------------------------------------------------------------------------------------------------------
-- ----------------------------------------------------------------------------------------------------------------
-- Default values for schema 'Core'
-- ----------------------------------------------------------------------------------------------------------------
-- ----------------------------------------------------------------------------------------------------------------
-- Primary Key constraints for schema 'Domain'
-- ----------------------------------------------------------------------------------------------------------------

ALTER TABLE [Domain].[DomainItem] WITH NOCHECK 
	ADD CONSTRAINT [PK_ade581347618a3a03e945bc69f8] PRIMARY KEY CLUSTERED 
	( 
		[Id] 
	)
GO
-- ----------------------------------------------------------------------------------------------------------------
-- Unique constraints for schema 'Domain'
-- ----------------------------------------------------------------------------------------------------------------
-- ----------------------------------------------------------------------------------------------------------------
-- Default values for schema 'Domain'
-- ----------------------------------------------------------------------------------------------------------------
-- ----------------------------------------------------------------------------------------------------------------
-- Primary Key constraints for schema 'Specific'
-- ----------------------------------------------------------------------------------------------------------------

ALTER TABLE [Specific].[SpecificItem] WITH NOCHECK 
	ADD CONSTRAINT [PK_1e57df54a14b46ffdfa2f1a7e87] PRIMARY KEY CLUSTERED 
	( 
		[Id] 
	)
GO
-- ----------------------------------------------------------------------------------------------------------------
-- Unique constraints for schema 'Specific'
-- ----------------------------------------------------------------------------------------------------------------
-- ----------------------------------------------------------------------------------------------------------------
-- Default values for schema 'Specific'
-- ----------------------------------------------------------------------------------------------------------------
-- ----------------------------------------------------------------------------------------------------------------
-- All foreign Key constraints
-- ----------------------------------------------------------------------------------------------------------------

ALTER TABLE [Core].[Item] 
	ADD CONSTRAINT [FK_fc808344380a37dec4d633ada36] FOREIGN KEY
	(
		[CollectionId] 
	)
	REFERENCES [Core].[Collection]
	(
		[Id] 
	)
	ON DELETE CASCADE
	ON UPDATE NO ACTION
GO


ALTER TABLE [Domain].[DomainItem] 
	ADD CONSTRAINT [FK_d12edd44b5aa5f0bf22b311ec9f] FOREIGN KEY
	(
		[Id] 
	)
	REFERENCES [Core].[Item]
	(
		[Id] 
	)
	ON DELETE CASCADE
	ON UPDATE NO ACTION
GO


ALTER TABLE [Specific].[SpecificItem] 
	ADD CONSTRAINT [FK_ed0220f42cab80268e8722796c0] FOREIGN KEY
	(
		[Id] 
	)
	REFERENCES [Domain].[DomainItem]
	(
		[Id] 
	)
	ON DELETE CASCADE
	ON UPDATE NO ACTION
GO
