USE [master]
GO
/****** Object:  Database [ProductionManagementSystem]    Script Date: 8/12/2016 2:42:29 PM ******/
CREATE DATABASE [ProductionManagementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProductionManagementSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\ProductionManagementSystem.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProductionManagementSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\ProductionManagementSystem_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ProductionManagementSystem] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProductionManagementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProductionManagementSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProductionManagementSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProductionManagementSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProductionManagementSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProductionManagementSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProductionManagementSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProductionManagementSystem] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ProductionManagementSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProductionManagementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProductionManagementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProductionManagementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProductionManagementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProductionManagementSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProductionManagementSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProductionManagementSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProductionManagementSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProductionManagementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProductionManagementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProductionManagementSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProductionManagementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProductionManagementSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProductionManagementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProductionManagementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProductionManagementSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProductionManagementSystem] SET  MULTI_USER 
GO
ALTER DATABASE [ProductionManagementSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProductionManagementSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProductionManagementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProductionManagementSystem] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProductionManagementSystem', N'ON'
GO
USE [ProductionManagementSystem]
GO
/****** Object:  Table [dbo].[EmployeeProduction]    Script Date: 8/12/2016 2:42:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmployeeProduction](
	[ProductID] [bigint] NOT NULL,
	[ShipmentID] [varchar](500) NOT NULL,
	[ISBN] [varchar](20) NOT NULL,
	[UserID] [varchar](50) NOT NULL,
	[PageCount] [int] NOT NULL,
	[FormatName] [varchar](100) NOT NULL,
	[Status] [varchar](100) NULL,
	[DoneDate] [datetime] NULL,
 CONSTRAINT [PK_EmployeeProduction] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC,
	[ShipmentID] ASC,
	[ISBN] ASC,
	[UserID] ASC,
	[FormatName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FeedbackTracking]    Script Date: 8/12/2016 2:42:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FeedbackTracking](
	[FeedbackID] [varchar](500) NOT NULL,
	[ShpID] [bigint] NOT NULL,
	[ShipmentID] [varchar](500) NOT NULL,
	[ISBN] [varchar](20) NULL,
	[FormatName] [varchar](100) NOT NULL,
	[FeedbackDate] [datetime2](7) NULL,
	[Remark] [varchar](1000) NULL,
 CONSTRAINT [PK_FeedbackTracking] PRIMARY KEY CLUSTERED 
(
	[FeedbackID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Format]    Script Date: 8/12/2016 2:42:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Format](
	[FormatName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Format] PRIMARY KEY CLUSTERED 
(
	[FormatName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[IncentiveScheme]    Script Date: 8/12/2016 2:42:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IncentiveScheme](
	[IncentiveID] [bigint] IDENTITY(1,1) NOT NULL,
	[IncentiveMonth] [datetime2](7) NOT NULL,
	[IncentiveAmount] [money] NOT NULL,
	[ForBook] [int] NULL,
	[ForPage] [int] NULL,
	[IncentiveRule] [int] NULL,
 CONSTRAINT [PK_IncentiveScheme] PRIMARY KEY CLUSTERED 
(
	[IncentiveID] ASC,
	[IncentiveMonth] ASC,
	[IncentiveAmount] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Priority]    Script Date: 8/12/2016 2:42:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Priority](
	[PriorityName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Priority] PRIMARY KEY CLUSTERED 
(
	[PriorityName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductionManagementDetail]    Script Date: 8/12/2016 2:42:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductionManagementDetail](
	[ShpID] [bigint] NOT NULL,
	[ShipmentID] [varchar](500) NOT NULL,
	[FormatName] [varchar](100) NOT NULL,
	[ISBN] [varchar](20) NULL,
	[PageCount] [int] NOT NULL,
	[UserID] [varchar](50) NULL,
	[StartDate] [datetime2](7) NULL,
	[ProductionStatus] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ProductionManagementDetail] PRIMARY KEY CLUSTERED 
(
	[ShpID] ASC,
	[ShipmentID] ASC,
	[FormatName] ASC,
	[ProductionStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductionManagementHeader]    Script Date: 8/12/2016 2:42:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductionManagementHeader](
	[ShpID] [bigint] NOT NULL,
	[ShipmentID] [varchar](500) NOT NULL,
	[FormatName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ProductionManagementHeader] PRIMARY KEY CLUSTERED 
(
	[ShpID] ASC,
	[ShipmentID] ASC,
	[FormatName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductionStatus]    Script Date: 8/12/2016 2:42:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductionStatus](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductID] [bigint] NOT NULL,
	[ShipmentID] [varchar](500) NOT NULL,
	[ISBN] [varchar](20) NOT NULL,
	[StartDate] [datetime] NULL,
	[FormatName] [varchar](100) NOT NULL,
	[UserID] [varchar](50) NOT NULL,
	[Status] [varchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Publisher]    Script Date: 8/12/2016 2:42:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Publisher](
	[PublisherID] [varchar](100) NOT NULL,
	[PublisherName] [varchar](100) NULL,
 CONSTRAINT [PK_Publisher] PRIMARY KEY CLUSTERED 
(
	[PublisherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QRDetail]    Script Date: 8/12/2016 2:42:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QRDetail](
	[ProductID] [bigint] NOT NULL,
	[ShipmentID] [varchar](500) NOT NULL,
	[ISBN] [varchar](20) NOT NULL,
	[FormatName] [varchar](100) NOT NULL,
	[UserID] [varchar](50) NOT NULL,
	[PageCount] [int] NOT NULL,
	[QRDate] [datetime] NULL,
	[Status] [varchar](100) NULL,
 CONSTRAINT [PK_QRDetail] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC,
	[ShipmentID] ASC,
	[ISBN] ASC,
	[FormatName] ASC,
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[QRHeader]    Script Date: 8/12/2016 2:42:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[QRHeader](
	[ProductID] [bigint] NOT NULL,
	[ShipmentID] [varchar](500) NOT NULL,
	[ISBN] [varchar](20) NOT NULL,
	[FormatName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_QRHeader] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC,
	[ShipmentID] ASC,
	[ISBN] ASC,
	[FormatName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ShipmentDetail]    Script Date: 8/12/2016 2:42:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ShipmentDetail](
	[ShpID] [bigint] IDENTITY(1,1) NOT NULL,
	[ShipmentID] [varchar](500) NOT NULL,
	[DownloadedDate] [datetime] NOT NULL,
	[Publisher] [varchar](100) NULL,
	[ISBN] [varchar](20) NULL,
	[DISBN] [varchar](20) NULL,
	[Title] [varchar](1000) NULL,
	[Author] [varchar](500) NULL,
	[Author1] [varchar](500) NULL,
	[PageCount] [int] NOT NULL,
	[Complexcity] [varchar](50) NULL,
	[PCPCode] [varchar](50) NULL,
	[DateOfAllocation] [datetime] NULL,
	[PubDate] [datetime] NULL,
	[Priority] [varchar](50) NULL,
	[Language] [varchar](50) NULL,
	[Team] [varchar](100) NULL,
	[UserID] [varchar](50) NULL,
	[AuditLoadedDate] [datetime] NULL,
	[AuditCount] [int] NULL,
	[AuditName] [varchar](2000) NULL,
	[AuditStatus] [varchar](50) NULL,
	[XmittedDate] [datetime] NULL,
	[DueDate] [datetime] NULL,
	[DollerUploadedDate] [datetime] NULL,
	[DollerFileName] [varchar](100) NULL,
	[FinalPrice] [float] NULL,
	[Comment] [varchar](5000) NULL,
	[Format] [varchar](100) NULL,
	[InternalReference] [varchar](5000) NULL,
	[SingleUnits] [float] NULL,
	[QueryDate] [datetime] NULL,
	[TATDelivery] [int] NULL,
	[ProductionDone] [int] NULL,
	[QRDone] [int] NULL,
	[TransmissionDone] [int] NULL,
	[ClientFeedback] [int] NULL,
 CONSTRAINT [PK_ShipmentDetail] PRIMARY KEY CLUSTERED 
(
	[ShpID] ASC,
	[ShipmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ShipmentDetailFormats]    Script Date: 8/12/2016 2:42:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ShipmentDetailFormats](
	[ShpID] [bigint] NOT NULL,
	[ShipmentID] [varchar](500) NOT NULL,
	[FormatName] [varchar](100) NOT NULL,
	[ProductionStatus] [varchar](100) NOT NULL,
 CONSTRAINT [PK_ShipmentDetailFormats] PRIMARY KEY CLUSTERED 
(
	[ShpID] ASC,
	[ShipmentID] ASC,
	[FormatName] ASC,
	[ProductionStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ShipmentHeader]    Script Date: 8/12/2016 2:42:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ShipmentHeader](
	[ShipmentID] [varchar](500) NOT NULL,
	[FileCount] [int] NOT NULL,
	[DownloadedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ShipmentHeader_1] PRIMARY KEY CLUSTERED 
(
	[ShipmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TATDelivery]    Script Date: 8/12/2016 2:42:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TATDelivery](
	[ShpID] [bigint] NOT NULL,
	[ShipmentID] [varchar](500) NOT NULL,
	[ISBN] [varchar](20) NULL,
	[PriorityName] [varchar](50) NULL,
	[FormatName] [varchar](100) NULL,
	[PubDate] [datetime] NULL,
	[TATDate] [datetime] NULL,
	[DateOfAllocation] [datetime] NULL,
	[Team] [varchar](100) NULL,
 CONSTRAINT [PK_TATDelivery_1] PRIMARY KEY CLUSTERED 
(
	[ShpID] ASC,
	[ShipmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserDepartment]    Script Date: 8/12/2016 2:42:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserDepartment](
	[DepartmentID] [varchar](50) NOT NULL,
	[DeparmentName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_UserDepartment] PRIMARY KEY CLUSTERED 
(
	[DeparmentName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserLevel]    Script Date: 8/12/2016 2:42:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserLevel](
	[LevelID] [varchar](50) NOT NULL,
	[LevelName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_UserLevel] PRIMARY KEY CLUSTERED 
(
	[LevelName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserManagement]    Script Date: 8/12/2016 2:42:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserManagement](
	[UserID] [varchar](50) NOT NULL,
	[UserName] [varchar](500) NULL,
	[UserFullName] [varchar](255) NULL,
	[Password] [varchar](255) NULL,
	[UserLevel] [varchar](50) NULL,
	[UserTeam] [varchar](100) NULL,
	[UserDepartment] [varchar](50) NULL,
 CONSTRAINT [PK_UserManagement_1] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserTeam]    Script Date: 8/12/2016 2:42:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserTeam](
	[TeamID] [varchar](100) NOT NULL,
	[TeamName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_UserTeam] PRIMARY KEY CLUSTERED 
(
	[TeamName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[IncentiveApplied]    Script Date: 8/12/2016 2:42:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IncentiveApplied]
AS
SELECT        dbo.EmployeeProduction.UserID, dbo.EmployeeProduction.PageCount, dbo.EmployeeProduction.ProductID, dbo.EmployeeProduction.ShipmentID, dbo.IncentiveScheme.IncentiveMonth, 
                         dbo.IncentiveScheme.IncentiveAmount, dbo.IncentiveScheme.ForBook, dbo.IncentiveScheme.ForPage, dbo.IncentiveScheme.IncentiveRule, dbo.EmployeeProduction.ISBN, dbo.IncentiveScheme.IncentiveID
FROM            dbo.EmployeeProduction CROSS JOIN
                         dbo.IncentiveScheme

GO
/****** Object:  View [dbo].[IncentivesForPageCountSUM]    Script Date: 8/12/2016 2:42:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[IncentivesForPageCountSUM]
AS
SELECT        SUM(PageCount) AS Expr1, UserID
FROM            dbo.EmployeeProduction
GROUP BY UserID

GO
/****** Object:  View [dbo].[ProductionSummary]    Script Date: 8/12/2016 2:42:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ProductionSummary]
AS
SELECT        ShpID, ShipmentID, ISBN, PageCount, Team, AuditCount, AuditName, AuditStatus, XmittedDate, AuditLoadedDate, DownloadedDate, FinalPrice, ProductionDone, QRDone, TransmissionDone, ClientFeedback
FROM            dbo.ShipmentDetail

GO
ALTER TABLE [dbo].[FeedbackTracking]  WITH CHECK ADD  CONSTRAINT [FK_FeedbackTracking_Format] FOREIGN KEY([FormatName])
REFERENCES [dbo].[Format] ([FormatName])
GO
ALTER TABLE [dbo].[FeedbackTracking] CHECK CONSTRAINT [FK_FeedbackTracking_Format]
GO
ALTER TABLE [dbo].[FeedbackTracking]  WITH CHECK ADD  CONSTRAINT [FK_FeedbackTracking_ShipmentDetail] FOREIGN KEY([ShpID], [ShipmentID])
REFERENCES [dbo].[ShipmentDetail] ([ShpID], [ShipmentID])
GO
ALTER TABLE [dbo].[FeedbackTracking] CHECK CONSTRAINT [FK_FeedbackTracking_ShipmentDetail]
GO
ALTER TABLE [dbo].[ProductionManagementDetail]  WITH CHECK ADD  CONSTRAINT [FK_ProductionManagementDetail_ProductionManagementHeader] FOREIGN KEY([ShpID], [ShipmentID], [FormatName])
REFERENCES [dbo].[ProductionManagementHeader] ([ShpID], [ShipmentID], [FormatName])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ProductionManagementDetail] CHECK CONSTRAINT [FK_ProductionManagementDetail_ProductionManagementHeader]
GO
ALTER TABLE [dbo].[ProductionManagementDetail]  WITH CHECK ADD  CONSTRAINT [FK_ProductionManagementDetail_ShipmentDetailFormats1] FOREIGN KEY([ShpID], [ShipmentID], [FormatName], [ProductionStatus])
REFERENCES [dbo].[ShipmentDetailFormats] ([ShpID], [ShipmentID], [FormatName], [ProductionStatus])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ProductionManagementDetail] CHECK CONSTRAINT [FK_ProductionManagementDetail_ShipmentDetailFormats1]
GO
ALTER TABLE [dbo].[ProductionManagementDetail]  WITH CHECK ADD  CONSTRAINT [FK_ProductionManagementDetail_UserManagement] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserManagement] ([UserID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ProductionManagementDetail] CHECK CONSTRAINT [FK_ProductionManagementDetail_UserManagement]
GO
ALTER TABLE [dbo].[QRDetail]  WITH CHECK ADD  CONSTRAINT [FK_QRDetail_QRHeader] FOREIGN KEY([ProductID], [ShipmentID], [ISBN], [FormatName])
REFERENCES [dbo].[QRHeader] ([ProductID], [ShipmentID], [ISBN], [FormatName])
GO
ALTER TABLE [dbo].[QRDetail] CHECK CONSTRAINT [FK_QRDetail_QRHeader]
GO
ALTER TABLE [dbo].[ShipmentDetail]  WITH CHECK ADD  CONSTRAINT [FK_ShipmentDetail_ShipmentHeader] FOREIGN KEY([ShipmentID])
REFERENCES [dbo].[ShipmentHeader] ([ShipmentID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ShipmentDetail] CHECK CONSTRAINT [FK_ShipmentDetail_ShipmentHeader]
GO
ALTER TABLE [dbo].[ShipmentDetailFormats]  WITH CHECK ADD  CONSTRAINT [FK_ShipmentDetailFormats_Format] FOREIGN KEY([FormatName])
REFERENCES [dbo].[Format] ([FormatName])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ShipmentDetailFormats] CHECK CONSTRAINT [FK_ShipmentDetailFormats_Format]
GO
ALTER TABLE [dbo].[ShipmentDetailFormats]  WITH CHECK ADD  CONSTRAINT [FK_ShipmentDetailFormats_ShipmentHeader] FOREIGN KEY([ShipmentID])
REFERENCES [dbo].[ShipmentHeader] ([ShipmentID])
GO
ALTER TABLE [dbo].[ShipmentDetailFormats] CHECK CONSTRAINT [FK_ShipmentDetailFormats_ShipmentHeader]
GO
ALTER TABLE [dbo].[TATDelivery]  WITH CHECK ADD  CONSTRAINT [FK_TATDelivery_Priority] FOREIGN KEY([PriorityName])
REFERENCES [dbo].[Priority] ([PriorityName])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TATDelivery] CHECK CONSTRAINT [FK_TATDelivery_Priority]
GO
ALTER TABLE [dbo].[TATDelivery]  WITH CHECK ADD  CONSTRAINT [FK_TATDelivery_ShipmentDetail] FOREIGN KEY([ShpID], [ShipmentID])
REFERENCES [dbo].[ShipmentDetail] ([ShpID], [ShipmentID])
GO
ALTER TABLE [dbo].[TATDelivery] CHECK CONSTRAINT [FK_TATDelivery_ShipmentDetail]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[43] 4[14] 2[23] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "EmployeeProduction"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 204
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "IncentiveScheme"
            Begin Extent = 
               Top = 6
               Left = 314
               Bottom = 195
               Right = 554
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 12
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 1725
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IncentiveApplied'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IncentiveApplied'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[21] 2[15] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "EmployeeProduction"
            Begin Extent = 
               Top = 6
               Left = 257
               Bottom = 211
               Right = 520
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 18
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IncentivesForPageCountSUM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'IncentivesForPageCountSUM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[21] 4[41] 2[13] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = -894
      End
      Begin Tables = 
         Begin Table = "ShipmentDetail"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 290
               Right = 284
            End
            DisplayFlags = 280
            TopColumn = 24
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 38
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ProductionSummary'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ProductionSummary'
GO
USE [master]
GO
ALTER DATABASE [ProductionManagementSystem] SET  READ_WRITE 
GO
