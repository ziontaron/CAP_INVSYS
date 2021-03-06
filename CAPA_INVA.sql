USE [master]
GO
/****** Object:  Database [CAPA_INV]    Script Date: 08/21/2017 15:17:19 ******/
CREATE DATABASE [CAPA_INV] ON  PRIMARY 
( NAME = N'CAPA_INV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CAPA_INV.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CAPA_INV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\CAPA_INV_log.LDF' , SIZE = 512KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CAPA_INV] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CAPA_INV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CAPA_INV] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [CAPA_INV] SET ANSI_NULLS OFF
GO
ALTER DATABASE [CAPA_INV] SET ANSI_PADDING OFF
GO
ALTER DATABASE [CAPA_INV] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [CAPA_INV] SET ARITHABORT OFF
GO
ALTER DATABASE [CAPA_INV] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [CAPA_INV] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [CAPA_INV] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [CAPA_INV] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [CAPA_INV] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [CAPA_INV] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [CAPA_INV] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [CAPA_INV] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [CAPA_INV] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [CAPA_INV] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [CAPA_INV] SET  ENABLE_BROKER
GO
ALTER DATABASE [CAPA_INV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [CAPA_INV] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [CAPA_INV] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [CAPA_INV] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [CAPA_INV] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [CAPA_INV] SET READ_COMMITTED_SNAPSHOT ON
GO
ALTER DATABASE [CAPA_INV] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [CAPA_INV] SET  READ_WRITE
GO
ALTER DATABASE [CAPA_INV] SET RECOVERY FULL
GO
ALTER DATABASE [CAPA_INV] SET  MULTI_USER
GO
ALTER DATABASE [CAPA_INV] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [CAPA_INV] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'CAPA_INV', N'ON'
GO
USE [CAPA_INV]
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 08/21/2017 15:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[TicketKey] [int] NOT NULL,
	[TicketCounter] [int] IDENTITY(1,1) NOT NULL,
	[cat_TicketTypeKey] [int] NOT NULL,
	[InventoryEventKey] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Ticket] PRIMARY KEY CLUSTERED 
(
	[TicketKey] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InventoryEvent]    Script Date: 08/21/2017 15:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InventoryEvent](
	[InventoryEventKey] [int] IDENTITY(1,1) NOT NULL,
	[InventoryEventName] [nvarchar](50) NOT NULL,
	[InventoryEventDescription] [nvarchar](max) NOT NULL,
	[CreationDate] [date] NOT NULL,
	[TerminationDate] [date] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.InventoryEvent] PRIMARY KEY CLUSTERED 
(
	[InventoryEventKey] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cat_TicketType]    Script Date: 08/21/2017 15:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cat_TicketType](
	[TicketTypeKey] [int] IDENTITY(1,1) NOT NULL,
	[TicketType] [nvarchar](50) NOT NULL,
	[TicketTypeDescirption] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_dbo.cat_TicketType] PRIMARY KEY CLUSTERED 
(
	[TicketTypeKey] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 08/21/2017 15:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[UserKey] [int] IDENTITY(1,1) NOT NULL,
	[Value] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](20) NOT NULL,
	[Role] [nvarchar](50) NULL,
	[AuthorizatorPassword] [nvarchar](50) NULL,
	[Email] [nvarchar](256) NULL,
	[Phone1] [nvarchar](50) NULL,
	[Phone2] [nvarchar](50) NULL,
	[Identicon] [varbinary](max) NULL,
	[Identicon64] [varchar](max) NULL,
	[EmailPassword] [nvarchar](max) NULL,
	[EmailServer] [nvarchar](max) NULL,
	[EmailPort] [nvarchar](max) NULL,
	[sys_active] [bit] NOT NULL,
	[is_locked] [bit] NOT NULL,
	[document_status] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.User] PRIMARY KEY CLUSTERED 
(
	[UserKey] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_UserName] ON [dbo].[User] 
(
	[UserName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TicketCount]    Script Date: 08/21/2017 15:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TicketCount](
	[TagCountKey] [int] IDENTITY(1,1) NOT NULL,
	[CounterInitials] [nvarchar](10) NULL,
	[CountedDate] [datetime] NULL,
	[TicketKey] [int] NOT NULL,
	[ItemNumber] [nvarchar](50) NULL,
	[ItemDescription] [nvarchar](100) NULL,
	[ItemRef] [nvarchar](10) NULL,
	[LotNumber] [nvarchar](50) NULL,
	[CountQTY] [int] NOT NULL,
	[ReCountQty] [int] NOT NULL,
	[SKT] [nvarchar](15) NULL,
	[BIN] [nvarchar](15) NULL,
	[IC] [nvarchar](3) NULL,
	[Verified] [bit] NOT NULL,
	[CountStatus] [nvarchar](10) NULL,
	[BlankTag] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.TicketCount] PRIMARY KEY CLUSTERED 
(
	[TagCountKey] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_TicketKey] ON [dbo].[TicketCount] 
(
	[TicketKey] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MOTagHeader]    Script Date: 08/21/2017 15:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOTagHeader](
	[MOTagHeaderKey] [int] IDENTITY(1,1) NOT NULL,
	[TicketKey] [int] NOT NULL,
	[Planner] [nvarchar](50) NULL,
	[MO] [nvarchar](50) NULL,
	[MO_Ln] [nvarchar](10) NULL,
	[MO_Status] [nvarchar](3) NULL,
	[Order_Qty] [int] NULL,
	[QtyRecv] [int] NULL,
	[LineType] [nvarchar](3) NULL,
	[QtyWip] [int] NULL,
 CONSTRAINT [PK_dbo.MOTagHeader] PRIMARY KEY CLUSTERED 
(
	[MOTagHeaderKey] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_TicketKey] ON [dbo].[MOTagHeader] 
(
	[TicketKey] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MOTagCount]    Script Date: 08/21/2017 15:17:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MOTagCount](
	[MOTagCountKey] [int] IDENTITY(1,1) NOT NULL,
	[MOTagHeaderKey] [int] NOT NULL,
	[SeqNum] [int] NOT NULL,
	[Component] [nvarchar](50) NOT NULL,
	[CompDesc] [nvarchar](50) NOT NULL,
	[UM] [nchar](10) NOT NULL,
 CONSTRAINT [PK_dbo.MOTagCount] PRIMARY KEY CLUSTERED 
(
	[MOTagCountKey] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_MOTagHeaderKey] ON [dbo].[MOTagCount] 
(
	[MOTagHeaderKey] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_dbo.TicketCount_dbo.Ticket_TicketKey]    Script Date: 08/21/2017 15:17:20 ******/
ALTER TABLE [dbo].[TicketCount]  WITH CHECK ADD  CONSTRAINT [FK_dbo.TicketCount_dbo.Ticket_TicketKey] FOREIGN KEY([TicketKey])
REFERENCES [dbo].[Ticket] ([TicketKey])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TicketCount] CHECK CONSTRAINT [FK_dbo.TicketCount_dbo.Ticket_TicketKey]
GO
/****** Object:  ForeignKey [FK_dbo.MOTagHeader_dbo.Ticket_TicketKey]    Script Date: 08/21/2017 15:17:20 ******/
ALTER TABLE [dbo].[MOTagHeader]  WITH CHECK ADD  CONSTRAINT [FK_dbo.MOTagHeader_dbo.Ticket_TicketKey] FOREIGN KEY([TicketKey])
REFERENCES [dbo].[Ticket] ([TicketKey])
GO
ALTER TABLE [dbo].[MOTagHeader] CHECK CONSTRAINT [FK_dbo.MOTagHeader_dbo.Ticket_TicketKey]
GO
/****** Object:  ForeignKey [FK_dbo.MOTagCount_dbo.MOTagHeader_MOTagHeaderKey]    Script Date: 08/21/2017 15:17:20 ******/
ALTER TABLE [dbo].[MOTagCount]  WITH CHECK ADD  CONSTRAINT [FK_dbo.MOTagCount_dbo.MOTagHeader_MOTagHeaderKey] FOREIGN KEY([MOTagHeaderKey])
REFERENCES [dbo].[MOTagHeader] ([MOTagHeaderKey])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MOTagCount] CHECK CONSTRAINT [FK_dbo.MOTagCount_dbo.MOTagHeader_MOTagHeaderKey]
GO
