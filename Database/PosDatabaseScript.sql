USE [master]
GO
/****** Object:  Database [AccountantDB]    Script Date: 15/10/2026 03:17:49 م ******/
CREATE DATABASE [AccountantDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AccountantDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\AccountantDB.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AccountantDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\AccountantDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [AccountantDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AccountantDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AccountantDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AccountantDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AccountantDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AccountantDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AccountantDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [AccountantDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AccountantDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AccountantDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AccountantDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AccountantDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AccountantDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AccountantDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AccountantDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AccountantDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AccountantDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [AccountantDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AccountantDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AccountantDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AccountantDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AccountantDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AccountantDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AccountantDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AccountantDB] SET RECOVERY FULL 
GO
ALTER DATABASE [AccountantDB] SET  MULTI_USER 
GO
ALTER DATABASE [AccountantDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AccountantDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AccountantDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AccountantDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AccountantDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AccountantDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'AccountantDB', N'ON'
GO
ALTER DATABASE [AccountantDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [AccountantDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [AccountantDB]
GO
/****** Object:  Schema [Customers]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE SCHEMA [Customers]
GO
/****** Object:  Schema [Expenses]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE SCHEMA [Expenses]
GO
/****** Object:  Schema [Partners]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE SCHEMA [Partners]
GO
/****** Object:  Schema [PartnerTransactions]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE SCHEMA [PartnerTransactions]
GO
/****** Object:  Schema [People]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE SCHEMA [People]
GO
/****** Object:  Schema [Products]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE SCHEMA [Products]
GO
/****** Object:  Schema [Purchases]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE SCHEMA [Purchases]
GO
/****** Object:  Schema [Sales]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE SCHEMA [Sales]
GO
/****** Object:  Schema [Suppliers]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE SCHEMA [Suppliers]
GO
/****** Object:  Schema [Users]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE SCHEMA [Users]
GO
/****** Object:  UserDefinedTableType [dbo].[PurchaseDetailsTVP]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE TYPE [dbo].[PurchaseDetailsTVP] AS TABLE(
	[ProductID] [int] NULL,
	[ProductName] [nvarchar](300) NULL,
	[CostPrice] [decimal](18, 2) NULL,
	[Quantity] [int] NULL,
	[TotalPrice] [decimal](18, 2) NULL,
	[ReturnedQuantity] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[SaleDetailType]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE TYPE [dbo].[SaleDetailType] AS TABLE(
	[ProductID] [int] NULL,
	[SellingPrice] [decimal](18, 2) NULL,
	[Quantity] [int] NULL,
	[ReturnedQuantity] [int] NULL,
	[DiscountAmount] [decimal](18, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [Partners].[PartnerPercentageType]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE TYPE [Partners].[PartnerPercentageType] AS TABLE(
	[PartnerID] [int] NOT NULL,
	[ProfitPercentage] [decimal](5, 2) NOT NULL,
	PRIMARY KEY CLUSTERED 
(
	[PartnerID] ASC
)WITH (IGNORE_DUP_KEY = OFF)
)
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Notes] [nvarchar](max) NULL,
	[TotalRemainingDebt] [decimal](18, 2) NOT NULL,
	[CreditLimit] [decimal](18, 2) NOT NULL,
	[CustomerType] [int] NULL,
	[DiscountPercentage] [decimal](5, 2) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_PersonID] UNIQUE NONCLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenses](
	[ExpenseID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[ExpenseTypeID] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[ExpenseDescription] [nvarchar](500) NULL,
 CONSTRAINT [PK_Expense] PRIMARY KEY CLUSTERED 
(
	[ExpenseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExpenseTransactions]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpenseTransactions](
	[ExpenseTransactionID] [bigint] IDENTITY(1,1) NOT NULL,
	[PartnerTransactionID] [bigint] NOT NULL,
	[ExpenseID] [bigint] NOT NULL,
 CONSTRAINT [PK_ExpenseTransaction] PRIMARY KEY CLUSTERED 
(
	[ExpenseTransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExpenseTypes]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpenseTypes](
	[ExpenseTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](40) NOT NULL,
	[Description] [nvarchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[ExpenseTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Partners]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Partners](
	[PartnerID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[CurrentBalance] [decimal](18, 2) NOT NULL,
	[ProfitPercentage] [decimal](5, 2) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Partner] PRIMARY KEY CLUSTERED 
(
	[PartnerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PartnerTransactions]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartnerTransactions](
	[PartnerTransactionID] [bigint] IDENTITY(1,1) NOT NULL,
	[PartnerID] [int] NOT NULL,
	[TransactionType] [int] NOT NULL,
	[Amount] [decimal](18, 4) NOT NULL,
	[CreatedDate] [datetime2](3) NOT NULL,
	[Notes] [nvarchar](500) NULL,
 CONSTRAINT [PK_PartnerTransaction_ID] PRIMARY KEY CLUSTERED 
(
	[PartnerTransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentMethods]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentMethods](
	[PaymentMethodID] [int] IDENTITY(1,1) NOT NULL,
	[PaymentMethodName] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PaymentMethodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[People]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[SecondName] [nvarchar](100) NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](25) NULL,
	[CreateDate] [datetime2](0) NOT NULL,
	[ModifyDate] [datetime2](0) NULL,
	[Address] [nvarchar](500) NULL,
	[ImagePath] [nvarchar](300) NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategories]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ProductCategory] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_CategoryName] UNIQUE NONCLUSTERED 
(
	[CategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_ProductCategory_Name] UNIQUE NONCLUSTERED 
(
	[CategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductCategoryID] [int] NOT NULL,
	[CostPrice] [decimal](18, 2) NOT NULL,
	[SellingPrice] [decimal](18, 2) NOT NULL,
	[UnitOfSale] [nvarchar](50) NOT NULL,
	[ProductName] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](400) NULL,
	[ImagePath] [nvarchar](500) NULL,
	[BarCode] [nvarchar](100) NULL,
	[QuantityInStock] [int] NOT NULL,
	[MinimumQuantityForWarning] [int] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[ModifyDate] [datetime2](7) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProfitRuns]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfitRuns](
	[ProfitRunID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[SaleID] [int] NOT NULL,
	[TotalCost] [decimal](18, 2) NOT NULL,
	[TotalSelling] [decimal](18, 2) NOT NULL,
	[NetProfit]  AS ([TotalSelling]-[TotalCost]) PERSISTED,
	[CreatedDate] [datetime2](3) NOT NULL,
 CONSTRAINT [PK_ProfitRuns_ID] PRIMARY KEY CLUSTERED 
(
	[ProfitRunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProfitTransactions]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfitTransactions](
	[ProfitTransactionID] [bigint] IDENTITY(1,1) NOT NULL,
	[PartnerTransactionID] [bigint] NOT NULL,
	[ProfitRunID] [int] NOT NULL,
 CONSTRAINT [PK_ProfitTransaction_ID] PRIMARY KEY CLUSTERED 
(
	[ProfitTransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_ProfitTransaction_PartnerTransaction_ProfitRun] UNIQUE NONCLUSTERED 
(
	[PartnerTransactionID] ASC,
	[ProfitRunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseDetails]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseDetails](
	[PurchaseDetailID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[ProductName] [nvarchar](200) NOT NULL,
	[CostPrice] [decimal](18, 2) NOT NULL,
	[SellingPrice] [decimal](18, 2) NOT NULL,
	[Quantity] [int] NOT NULL,
	[TotalPrice]  AS (([Quantity]-[ReturnedQuantity])*[CostPrice]) PERSISTED,
	[ReturnedQuantity] [int] NOT NULL,
 CONSTRAINT [PK_PurchaseDetail] PRIMARY KEY CLUSTERED 
(
	[PurchaseDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Purchases]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchases](
	[PurchaseID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[SupplierID] [int] NOT NULL,
	[PaymentMethodID] [int] NOT NULL,
	[TotalAmount] [decimal](18, 2) NOT NULL,
	[PaidAmount] [decimal](18, 2) NOT NULL,
	[DiscountAmount] [decimal](18, 2) NOT NULL,
	[RemainingAmountDebt]  AS (([TotalAmount]-[PaidAmount])-[DiscountAmount]) PERSISTED,
	[CreateDate] [datetime2](7) NOT NULL,
	[Notes] [nvarchar](500) NULL,
	[ModifyDate] [datetime2](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[PurchaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SaleDetails]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleDetails](
	[SaleDetailID] [bigint] IDENTITY(1,1) NOT NULL,
	[SaleID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[CostPrice] [decimal](18, 2) NOT NULL,
	[SellingPrice] [decimal](18, 2) NOT NULL,
	[Quantity] [int] NOT NULL,
	[ReturnedQuantity] [int] NOT NULL,
	[ProductName] [nvarchar](100) NOT NULL,
	[DiscountAmount] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_SaleDetail] PRIMARY KEY CLUSTERED 
(
	[SaleDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[SaleID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[PaymentMethodID] [int] NOT NULL,
	[TotalAmount] [decimal](18, 2) NOT NULL,
	[PaidAmount] [decimal](18, 2) NOT NULL,
	[DiscountAmount] [decimal](18, 2) NOT NULL,
	[CreateDate] [datetime2](0) NOT NULL,
	[ModifyDate] [datetime2](7) NULL,
	[Notes] [nvarchar](1000) NULL,
 CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[TotalRemainingDebt] [decimal](18, 2) NOT NULL,
	[Notes] [nvarchar](1000) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[HashPassword] [nvarchar](400) NOT NULL,
	[Notes] [nvarchar](1000) NULL,
	[PermissionInBinary] [int] NOT NULL,
	[CreatedDate] [datetime2](0) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[PasswordSalt] [nchar](400) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_User_UserName] UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_Customer_PersonID]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_Customer_PersonID] ON [dbo].[Customers]
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Expense_ExpenseTypeID]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_Expense_ExpenseTypeID] ON [dbo].[Expenses]
(
	[ExpenseTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Expense_UserID]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_Expense_UserID] ON [dbo].[Expenses]
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Partner_PersonID]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_Partner_PersonID] ON [dbo].[Partners]
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PartnerTransaction_PartnerID]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_PartnerTransaction_PartnerID] ON [dbo].[PartnerTransactions]
(
	[PartnerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PartnerTransaction_Type_CreatedDate]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_PartnerTransaction_Type_CreatedDate] ON [dbo].[PartnerTransactions]
(
	[TransactionType] ASC,
	[CreatedDate] ASC
)
INCLUDE([Amount]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Person_LastName_FirstName]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_Person_LastName_FirstName] ON [dbo].[People]
(
	[LastName] ASC,
	[FirstName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ProductCategory_CategoryName]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_ProductCategory_CategoryName] ON [dbo].[ProductCategories]
(
	[CategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Product_BarCode]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_Product_BarCode] ON [dbo].[Products]
(
	[BarCode] ASC
)
WHERE ([BarCode] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Product_Name]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_Product_Name] ON [dbo].[Products]
(
	[ProductName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Product_ProductCategoryID]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_Product_ProductCategoryID] ON [dbo].[Products]
(
	[ProductCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProfitRuns_CreatedDate_NetProfit]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_ProfitRuns_CreatedDate_NetProfit] ON [dbo].[ProfitRuns]
(
	[CreatedDate] ASC
)
INCLUDE([NetProfit],[TotalSelling]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProfitRuns_SaleID]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_ProfitRuns_SaleID] ON [dbo].[ProfitRuns]
(
	[SaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProfitRuns_UserID]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_ProfitRuns_UserID] ON [dbo].[ProfitRuns]
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProfitTransaction_PartnerTransactionID]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_ProfitTransaction_PartnerTransactionID] ON [dbo].[ProfitTransactions]
(
	[PartnerTransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProfitTransaction_ProfitRunID]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_ProfitTransaction_ProfitRunID] ON [dbo].[ProfitTransactions]
(
	[ProfitRunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PurchaseDetail_ProductID]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_PurchaseDetail_ProductID] ON [dbo].[PurchaseDetails]
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PurchaseDetail_PurchaseID]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_PurchaseDetail_PurchaseID] ON [dbo].[PurchaseDetails]
(
	[PurchaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Purchase_CreateDate]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_Purchase_CreateDate] ON [dbo].[Purchases]
(
	[CreateDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Purchase_PaymentMethodID]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_Purchase_PaymentMethodID] ON [dbo].[Purchases]
(
	[PaymentMethodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Purchase_SupplierID]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_Purchase_SupplierID] ON [dbo].[Purchases]
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Purchase_UserID]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_Purchase_UserID] ON [dbo].[Purchases]
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SaleDetail_ProductID]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_SaleDetail_ProductID] ON [dbo].[SaleDetails]
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SaleDetail_SaleID]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_SaleDetail_SaleID] ON [dbo].[SaleDetails]
(
	[SaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Sale_Customer]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_Sale_Customer] ON [dbo].[Sales]
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Sale_Payment]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_Sale_Payment] ON [dbo].[Sales]
(
	[PaymentMethodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Sale_User]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_Sale_User] ON [dbo].[Sales]
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Supplier_PersonID]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_Supplier_PersonID] ON [dbo].[Suppliers]
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_User_IsActive]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_User_IsActive] ON [dbo].[Users]
(
	[IsActive] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_User_PersonID]    Script Date: 15/10/2026 03:17:50 م ******/
CREATE NONCLUSTERED INDEX [IX_User_PersonID] ON [dbo].[Users]
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Customers] ADD  CONSTRAINT [DF_Customer_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Customers] ADD  CONSTRAINT [DF_Customer_Debt]  DEFAULT ((0.00)) FOR [TotalRemainingDebt]
GO
ALTER TABLE [dbo].[Customers] ADD  CONSTRAINT [DF_Customer_Limit]  DEFAULT ((0.00)) FOR [CreditLimit]
GO
ALTER TABLE [dbo].[Customers] ADD  CONSTRAINT [DF_Customer_Discount]  DEFAULT ((0.00)) FOR [DiscountPercentage]
GO
ALTER TABLE [dbo].[Customers] ADD  CONSTRAINT [DF_Customer_CreatedDate]  DEFAULT (sysdatetime()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Customers] ADD  CONSTRAINT [DF_Customer_ModifiedDate]  DEFAULT (sysdatetime()) FOR [ModifiedDate]
GO
ALTER TABLE [dbo].[Expenses] ADD  CONSTRAINT [DF_Expense_CreatedDate]  DEFAULT (sysdatetime()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Partners] ADD  CONSTRAINT [DF_Partner_CurrentBalance]  DEFAULT ((0.00)) FOR [CurrentBalance]
GO
ALTER TABLE [dbo].[Partners] ADD  CONSTRAINT [DF_Partner_ProfitPercentage]  DEFAULT ((0.00)) FOR [ProfitPercentage]
GO
ALTER TABLE [dbo].[Partners] ADD  CONSTRAINT [DF_Partner_CreatedDate]  DEFAULT (sysdatetime()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Partners] ADD  CONSTRAINT [DF_Partner_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[PartnerTransactions] ADD  CONSTRAINT [DF_PartnerTransaction_CreatedDate]  DEFAULT (sysdatetime()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[People] ADD  CONSTRAINT [DF_Person_CreateDate]  DEFAULT (sysdatetime()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[People] ADD  DEFAULT (NULL) FOR [ImagePath]
GO
ALTER TABLE [dbo].[ProductCategories] ADD  CONSTRAINT [DF_ProductCategory_CreatedDate]  DEFAULT (sysdatetime()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Product_CostPrice]  DEFAULT ((0.00)) FOR [CostPrice]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Product_SellingPrice]  DEFAULT ((0.00)) FOR [SellingPrice]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Product_Qty]  DEFAULT ((0)) FOR [QuantityInStock]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Product_MinQty]  DEFAULT ((0)) FOR [MinimumQuantityForWarning]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Product_CreateDate]  DEFAULT (sysdatetime()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Product_ModifyDate]  DEFAULT (sysdatetime()) FOR [ModifyDate]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Product_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[ProfitRuns] ADD  CONSTRAINT [DF_SalesSummary_CreatedDate]  DEFAULT (sysdatetime()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[PurchaseDetails] ADD  CONSTRAINT [DF_PurchaseDetail_ReturnedQuantity]  DEFAULT ((0)) FOR [ReturnedQuantity]
GO
ALTER TABLE [dbo].[Purchases] ADD  DEFAULT ((0)) FOR [TotalAmount]
GO
ALTER TABLE [dbo].[Purchases] ADD  DEFAULT ((0)) FOR [PaidAmount]
GO
ALTER TABLE [dbo].[Purchases] ADD  DEFAULT ((0)) FOR [DiscountAmount]
GO
ALTER TABLE [dbo].[Purchases] ADD  DEFAULT (sysdatetime()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[SaleDetails] ADD  CONSTRAINT [DF__SaleDetai__Retur__467D75B8]  DEFAULT ((0)) FOR [ReturnedQuantity]
GO
ALTER TABLE [dbo].[SaleDetails] ADD  CONSTRAINT [DF_Discount]  DEFAULT ((0)) FOR [DiscountAmount]
GO
ALTER TABLE [dbo].[Sales] ADD  CONSTRAINT [DF_Sale_Total]  DEFAULT ((0)) FOR [TotalAmount]
GO
ALTER TABLE [dbo].[Sales] ADD  CONSTRAINT [DF_Sale_Paid]  DEFAULT ((0)) FOR [PaidAmount]
GO
ALTER TABLE [dbo].[Sales] ADD  CONSTRAINT [DF_Sale_Discount]  DEFAULT ((0)) FOR [DiscountAmount]
GO
ALTER TABLE [dbo].[Sales] ADD  CONSTRAINT [DF_Sale_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Suppliers] ADD  CONSTRAINT [DF_Supplier_Debt]  DEFAULT ((0.00)) FOR [TotalRemainingDebt]
GO
ALTER TABLE [dbo].[Suppliers] ADD  CONSTRAINT [DF_Supplier_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Suppliers] ADD  CONSTRAINT [DF_Supplier_ModifiedDate]  DEFAULT (getdate()) FOR [ModifiedDate]
GO
ALTER TABLE [dbo].[Suppliers] ADD  CONSTRAINT [DF_Supplier_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_User_CreatedDate]  DEFAULT (sysdatetime()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_User_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Person] FOREIGN KEY([PersonID])
REFERENCES [dbo].[People] ([PersonID])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customer_Person]
GO
ALTER TABLE [dbo].[Expenses]  WITH CHECK ADD  CONSTRAINT [FK_Expense_ExpenseType] FOREIGN KEY([ExpenseTypeID])
REFERENCES [dbo].[ExpenseTypes] ([ExpenseTypeID])
GO
ALTER TABLE [dbo].[Expenses] CHECK CONSTRAINT [FK_Expense_ExpenseType]
GO
ALTER TABLE [dbo].[Expenses]  WITH CHECK ADD  CONSTRAINT [FK_Expense_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Expenses] CHECK CONSTRAINT [FK_Expense_User]
GO
ALTER TABLE [dbo].[ExpenseTransactions]  WITH CHECK ADD  CONSTRAINT [FK_ExpenseTransaction_Expense] FOREIGN KEY([ExpenseID])
REFERENCES [dbo].[Expenses] ([ExpenseID])
GO
ALTER TABLE [dbo].[ExpenseTransactions] CHECK CONSTRAINT [FK_ExpenseTransaction_Expense]
GO
ALTER TABLE [dbo].[ExpenseTransactions]  WITH CHECK ADD  CONSTRAINT [FK_ExpenseTransaction_PartnerTransaction] FOREIGN KEY([PartnerTransactionID])
REFERENCES [dbo].[PartnerTransactions] ([PartnerTransactionID])
GO
ALTER TABLE [dbo].[ExpenseTransactions] CHECK CONSTRAINT [FK_ExpenseTransaction_PartnerTransaction]
GO
ALTER TABLE [dbo].[Partners]  WITH CHECK ADD FOREIGN KEY([PersonID])
REFERENCES [dbo].[People] ([PersonID])
GO
ALTER TABLE [dbo].[PartnerTransactions]  WITH CHECK ADD FOREIGN KEY([PartnerID])
REFERENCES [dbo].[Partners] ([PartnerID])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK__Products__Produc__793DFFAF] FOREIGN KEY([ProductCategoryID])
REFERENCES [dbo].[ProductCategories] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK__Products__Produc__793DFFAF]
GO
ALTER TABLE [dbo].[ProfitRuns]  WITH CHECK ADD FOREIGN KEY([SaleID])
REFERENCES [dbo].[Sales] ([SaleID])
GO
ALTER TABLE [dbo].[ProfitRuns]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[ProfitTransactions]  WITH CHECK ADD FOREIGN KEY([PartnerTransactionID])
REFERENCES [dbo].[PartnerTransactions] ([PartnerTransactionID])
GO
ALTER TABLE [dbo].[ProfitTransactions]  WITH CHECK ADD FOREIGN KEY([ProfitRunID])
REFERENCES [dbo].[ProfitRuns] ([ProfitRunID])
GO
ALTER TABLE [dbo].[PurchaseDetails]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseDetail_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[PurchaseDetails] CHECK CONSTRAINT [FK_PurchaseDetail_Product]
GO
ALTER TABLE [dbo].[PurchaseDetails]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseDetail_Purchase] FOREIGN KEY([PurchaseID])
REFERENCES [dbo].[Purchases] ([PurchaseID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PurchaseDetails] CHECK CONSTRAINT [FK_PurchaseDetail_Purchase]
GO
ALTER TABLE [dbo].[Purchases]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_PaymentMethod] FOREIGN KEY([PaymentMethodID])
REFERENCES [dbo].[PaymentMethods] ([PaymentMethodID])
GO
ALTER TABLE [dbo].[Purchases] CHECK CONSTRAINT [FK_Purchase_PaymentMethod]
GO
ALTER TABLE [dbo].[Purchases]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Supplier] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[Purchases] CHECK CONSTRAINT [FK_Purchase_Supplier]
GO
ALTER TABLE [dbo].[Purchases]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Purchases] CHECK CONSTRAINT [FK_Purchase_User]
GO
ALTER TABLE [dbo].[SaleDetails]  WITH CHECK ADD  CONSTRAINT [FK__SaleDetai__Produ__4589517F] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[SaleDetails] CHECK CONSTRAINT [FK__SaleDetai__Produ__4589517F]
GO
ALTER TABLE [dbo].[SaleDetails]  WITH CHECK ADD  CONSTRAINT [FK__SaleDetai__SaleI__44952D46] FOREIGN KEY([SaleID])
REFERENCES [dbo].[Sales] ([SaleID])
GO
ALTER TABLE [dbo].[SaleDetails] CHECK CONSTRAINT [FK__SaleDetai__SaleI__44952D46]
GO
ALTER TABLE [dbo].[SaleDetails]  WITH CHECK ADD  CONSTRAINT [FK_SaleDetail_Sale] FOREIGN KEY([SaleID])
REFERENCES [dbo].[Sales] ([SaleID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SaleDetails] CHECK CONSTRAINT [FK_SaleDetail_Sale]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK__Sales__CustomerI__3BFFE745] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK__Sales__CustomerI__3BFFE745]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK__Sales__PaymentMe__3CF40B7E] FOREIGN KEY([PaymentMethodID])
REFERENCES [dbo].[PaymentMethods] ([PaymentMethodID])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK__Sales__PaymentMe__3CF40B7E]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK__Sales__UserID__3B0BC30C] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK__Sales__UserID__3B0BC30C]
GO
ALTER TABLE [dbo].[Suppliers]  WITH CHECK ADD FOREIGN KEY([PersonID])
REFERENCES [dbo].[People] ([PersonID])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_People] FOREIGN KEY([PersonID])
REFERENCES [dbo].[People] ([PersonID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_People]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [CHK_Customer_CreatedDate_ModifyData] CHECK  (([CreatedDate]<=[ModifiedDate]))
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [CHK_Customer_CreatedDate_ModifyData]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [CHK_Customer_Debt_NonNegative] CHECK  (([TotalRemainingDebt]>=(0)))
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [CHK_Customer_Debt_NonNegative]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [CHK_Customer_Debt_Within_Limit] CHECK  (([TotalRemainingDebt]<=[CreditLimit]))
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [CHK_Customer_Debt_Within_Limit]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [CHK_Customer_Discount_Range] CHECK  (([DiscountPercentage]>=(0) AND [DiscountPercentage]<=(100)))
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [CHK_Customer_Discount_Range]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [CHK_Customer_Limit_NonNegative] CHECK  (([CreditLimit]>=(0)))
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [CHK_Customer_Limit_NonNegative]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [CHK_Customer_Type_Valid] CHECK  (([CustomerType]>(0)))
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [CHK_Customer_Type_Valid]
GO
ALTER TABLE [dbo].[Expenses]  WITH CHECK ADD  CONSTRAINT [CK_Expense_Amount] CHECK  (([Amount]>=(0)))
GO
ALTER TABLE [dbo].[Expenses] CHECK CONSTRAINT [CK_Expense_Amount]
GO
ALTER TABLE [dbo].[Partners]  WITH CHECK ADD  CONSTRAINT [CK_Partner_ModifiedDate_After_Created] CHECK  (([ModifiedDate] IS NULL OR [ModifiedDate]>=[CreatedDate]))
GO
ALTER TABLE [dbo].[Partners] CHECK CONSTRAINT [CK_Partner_ModifiedDate_After_Created]
GO
ALTER TABLE [dbo].[Partners]  WITH CHECK ADD  CONSTRAINT [CK_Partner_ProfitPercentage] CHECK  (([ProfitPercentage]>=(0) AND [ProfitPercentage]<=(100)))
GO
ALTER TABLE [dbo].[Partners] CHECK CONSTRAINT [CK_Partner_ProfitPercentage]
GO
ALTER TABLE [dbo].[PartnerTransactions]  WITH CHECK ADD  CONSTRAINT [CK_PartnerTransaction_TransactionType] CHECK  (([TransactionType]=(4) OR [TransactionType]=(3) OR [TransactionType]=(2) OR [TransactionType]=(1)))
GO
ALTER TABLE [dbo].[PartnerTransactions] CHECK CONSTRAINT [CK_PartnerTransaction_TransactionType]
GO
ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [CK_Person_Address_NotEmpty] CHECK  (([Address] IS NULL OR len(ltrim(rtrim([Address])))>(0)))
GO
ALTER TABLE [dbo].[People] CHECK CONSTRAINT [CK_Person_Address_NotEmpty]
GO
ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [CK_Person_FirstName_NotEmpty] CHECK  ((len(ltrim(rtrim([FirstName])))>(0)))
GO
ALTER TABLE [dbo].[People] CHECK CONSTRAINT [CK_Person_FirstName_NotEmpty]
GO
ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [CK_Person_LastName_NotEmpty] CHECK  ((len(ltrim(rtrim([LastName])))>(0)))
GO
ALTER TABLE [dbo].[People] CHECK CONSTRAINT [CK_Person_LastName_NotEmpty]
GO
ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [CK_Person_ModifiedDate_AfterCreateDate] CHECK  (([ModifyDate] IS NULL OR [ModifyDate]>=[CreateDate]))
GO
ALTER TABLE [dbo].[People] CHECK CONSTRAINT [CK_Person_ModifiedDate_AfterCreateDate]
GO
ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [CK_Person_Phone_Format] CHECK  (([Phone] IS NULL OR NOT [Phone] like '%[^0-9+() -]%'))
GO
ALTER TABLE [dbo].[People] CHECK CONSTRAINT [CK_Person_Phone_Format]
GO
ALTER TABLE [dbo].[People]  WITH CHECK ADD  CONSTRAINT [CK_Person_ThirdName_NotEmpty] CHECK  (([SecondName] IS NULL OR len(ltrim(rtrim([SecondName])))>(0)))
GO
ALTER TABLE [dbo].[People] CHECK CONSTRAINT [CK_Person_ThirdName_NotEmpty]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [CK_Product_Prices] CHECK  (([SellingPrice]>=(0) AND [CostPrice]>=(0)))
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [CK_Product_Prices]
GO
ALTER TABLE [dbo].[PurchaseDetails]  WITH CHECK ADD  CONSTRAINT [CK_PurchaseDetail_CostPrice] CHECK  (([CostPrice]>=(0)))
GO
ALTER TABLE [dbo].[PurchaseDetails] CHECK CONSTRAINT [CK_PurchaseDetail_CostPrice]
GO
ALTER TABLE [dbo].[PurchaseDetails]  WITH CHECK ADD  CONSTRAINT [CK_PurchaseDetail_Quantity] CHECK  (([Quantity]>(0)))
GO
ALTER TABLE [dbo].[PurchaseDetails] CHECK CONSTRAINT [CK_PurchaseDetail_Quantity]
GO
ALTER TABLE [dbo].[PurchaseDetails]  WITH CHECK ADD  CONSTRAINT [CK_PurchaseDetail_ReturnedQuantity] CHECK  (([ReturnedQuantity]>=(0)))
GO
ALTER TABLE [dbo].[PurchaseDetails] CHECK CONSTRAINT [CK_PurchaseDetail_ReturnedQuantity]
GO
ALTER TABLE [dbo].[PurchaseDetails]  WITH CHECK ADD  CONSTRAINT [CK_PurchaseDetail_SellingPrice] CHECK  (([SellingPrice]>=(0)))
GO
ALTER TABLE [dbo].[PurchaseDetails] CHECK CONSTRAINT [CK_PurchaseDetail_SellingPrice]
GO
ALTER TABLE [dbo].[Purchases]  WITH CHECK ADD  CONSTRAINT [CK_Purchase_DiscountAmount] CHECK  (([DiscountAmount]>=(0)))
GO
ALTER TABLE [dbo].[Purchases] CHECK CONSTRAINT [CK_Purchase_DiscountAmount]
GO
ALTER TABLE [dbo].[Purchases]  WITH CHECK ADD  CONSTRAINT [CK_Purchase_PaidAmount] CHECK  (([PaidAmount]>=(0)))
GO
ALTER TABLE [dbo].[Purchases] CHECK CONSTRAINT [CK_Purchase_PaidAmount]
GO
ALTER TABLE [dbo].[Purchases]  WITH CHECK ADD  CONSTRAINT [CK_Purchase_TotalAmount] CHECK  (([TotalAmount]>=(0)))
GO
ALTER TABLE [dbo].[Purchases] CHECK CONSTRAINT [CK_Purchase_TotalAmount]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [CK_User_HashPassword_NotEmpty] CHECK  ((len(ltrim(rtrim([HashPassword])))>(0)))
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [CK_User_HashPassword_NotEmpty]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [CK_User_UserName_NotEmpty] CHECK  ((len(ltrim(rtrim([UserName])))>(0)))
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [CK_User_UserName_NotEmpty]
GO
/****** Object:  StoredProcedure [Customers].[SP_AddNewCustomer]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [Customers].[SP_AddNewCustomer] 
   @PersonID int,@IsActive bit ,@Notes nvarchar(300),@TotalRemainingDebt decimal,@CreditLimit decimal,
   @CustomerType int,@DiscountPercentage decimal
   as begin

   
INSERT INTO [dbo].[Customers]
           ([PersonID]
           ,[IsActive]
           ,[Notes]
           ,[TotalRemainingDebt]
           ,[CreditLimit]
           ,[CustomerType]
           ,[DiscountPercentage]
          )
     VALUES(
           @PersonID
           ,@IsActive
           ,@Notes
           ,@TotalRemainingDebt
           ,@CreditLimit 
           ,@CustomerType 
           ,@DiscountPercentage 
           );

		   select SCOPE_IDENTITY();

   end



GO
/****** Object:  StoredProcedure [Customers].[SP_DeleteCustomerByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [Customers].[SP_DeleteCustomerByID]
@CustomerID int
   as begin
   
delete from Customers where CustomerID=@CustomerID
   end



GO
/****** Object:  StoredProcedure [Customers].[SP_GetAllCustomers]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [Customers].[SP_GetAllCustomers]
@PageNumber int ,@PageSize int
   as begin
   

SELECT Customers.CustomerID, Concat_ws(' ', People.FirstName, People.SecondName, People.LastName) AS FullName,case when People.Phone is null then 'لا يوجد' else People.Phone end as Phone,  case when People.Address is null then 'لا يوجد' else People.Address end as Address, Customers.IsActive,
FORMAT(Customers.TotalRemainingDebt, '0.##') as TotalRemainingDebt
, 
                  Customers.CustomerType
FROM     Customers INNER JOIN
                  People ON Customers.PersonID = People.PersonID
				  order by CustomerID 
 offset(@PageNumber - 1) * @PageSize rows
 fetch next @PageSize rows only
   end



GO
/****** Object:  StoredProcedure [Customers].[SP_GetCustomerByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [Customers].[SP_GetCustomerByID]
@CustomerID int
   as begin
   
select CustomerID
      ,[PersonID]
      ,[IsActive]
      ,[Notes]
      ,[TotalRemainingDebt]
      ,[CreditLimit]
      ,[CustomerType]
      ,[DiscountPercentage]
      ,[CreatedDate]
      ,[ModifiedDate] from Customers where CustomerID=@CustomerID
   end



GO
/****** Object:  StoredProcedure [Customers].[SP_GetCustomerByPersonID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [Customers].[SP_GetCustomerByPersonID]
@PersonID int
   as begin
   
select CustomerID
      ,[PersonID]
      ,[IsActive]
      ,[Notes]
      ,[TotalRemainingDebt]
      ,[CreditLimit]
      ,[CustomerType]
      ,[DiscountPercentage]
      ,[CreatedDate]
      ,[ModifiedDate] from Customers where PersonID=@PersonID
   end



GO
/****** Object:  StoredProcedure [Customers].[SP_GetCustomerByPhone]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [Customers].[SP_GetCustomerByPhone]
@Phone nvarchar(20)
   as begin
   
select CustomerID
      ,p.PersonID
      ,[IsActive]
      ,[Notes]
      ,[TotalRemainingDebt]
      ,[CreditLimit]
      ,[CustomerType]
      ,[DiscountPercentage]
      ,[CreatedDate]
      ,[ModifiedDate] from Customers c join People p on c.PersonID=p.PersonID 
	  where p.Phone=@Phone
   end



GO
/****** Object:  StoredProcedure [Customers].[SP_IsPersonCustomer]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




create procedure [Customers].[SP_IsPersonCustomer] @PersonID int
as begin

if exists(select 1 from Customers where PersonID=@PersonID)
select 1 ;
ELSE
SELECT 0;


end
GO
/****** Object:  StoredProcedure [Customers].[SP_UpdateCustomerByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [Customers].[SP_UpdateCustomerByID] @CustomerID int, 
   @PersonID int,@IsActive bit ,@Notes nvarchar(300),@TotalRemainingDebt decimal,@CreditLimit decimal,
   @CustomerType int,@DiscountPercentage decimal
   as begin

   update Customers set 
           PersonID= @PersonID
           ,IsActive= @IsActive
           ,Notes= @Notes
           ,TotalRemainingDebt= @TotalRemainingDebt
           ,CreditLimit= @CreditLimit 
           ,CustomerType= @CustomerType 
           ,DiscountPercentage= @DiscountPercentage 
           
		   where CustomerID=@CustomerID

		 

   end



GO
/****** Object:  StoredProcedure [Expenses].[SP_AddExpense]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 
 CREATE procedure [Expenses].[SP_AddExpense]
 @UserID int,
 @ExpenseTypeID int,
 @Amount decimal(18,2),
 @Notes nvarchar(300),
 @ExpenseID int out
 as begin

 begin transaction 
  begin try

  --1 add expense
  if(@Notes='')begin set @Notes=null  end

  insert into Expenses values
  (@UserID,@ExpenseTypeID,SYSDATETIME(),@Amount,@Notes);
    
	set @ExpenseID=SCOPE_IDENTITY();

	--2 do transaction of expense type for each partner

	   Declare @PartnerID int,@MaxID int,@Percentage decimal(5,2),@TransactionID int,@ExpenseAmount decimal(18,2);
	  
	  select  @PartnerID=min(PartnerID),@MaxID=max(PartnerID) from Partners
	   
	   while @PartnerID is not null and @PartnerID<=@MaxID
	   begin
	   
	   select @Percentage=ProfitPercentage from Partners where PartnerID=@PartnerID
	   
	   set @ExpenseAmount=(@Amount*@Percentage)/100;
	   exec PartnerTransactions.SP_AddPartnerTransaction @PartnerID,4,@ExpenseAmount,null,@TransactionID output; 
	   
	   --Add ProfitTransaction Record
	   insert into ExpenseTransactions values
	   (@TransactionID,@ExpenseID);


	   select @PartnerID=min(PartnerID) from Partners where PartnerID>@PartnerID

	   end
  commit TRANSACTION
 end try
 begin catch
 
        ROLLBACK TRANSACTION;

            -- Raise the error back to C# Data Access Layer
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
   

 end catch




 end


GO
/****** Object:  StoredProcedure [Partners].[SP_AddNewPartner]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO









CREATE PROCEDURE [Partners].[SP_AddNewPartner]
    @PersonID INT,
    @CurrentBalance DECIMAL(18, 2),
    @ProfitPercentage DECIMAL(5, 2),
    @IsActive BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Partners (PersonID, CurrentBalance, ProfitPercentage, IsActive, CreatedDate)
    VALUES (@PersonID, @CurrentBalance, @ProfitPercentage, @IsActive, SYSDATETIME());
    
    SELECT SCOPE_IDENTITY() AS NewPartnerID;
END
GO
/****** Object:  StoredProcedure [Partners].[SP_DeletePartnerByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Partners].[SP_DeletePartnerByID]
    @PartnerID INT
AS
BEGIN
    SET NOCOUNT ON;


    DELETE FROM Partners WHERE PartnerID = @PartnerID;

	select @@ROWCOUNT;
END
GO
/****** Object:  StoredProcedure [Partners].[SP_GetAllPartners]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Partners].[SP_GetAllPartners]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT PartnerID, FullName=CONCAT_WS(' ',p.FirstName,p.SecondName,p.LastName),Format( CurrentBalance ,'0.##')as CurrentBalance,format( ProfitPercentage ,'0.##')as ProfitPercentage , IsActive
    FROM Partners pr join People p on pr.PersonID=p.PersonID ;
END
GO
/****** Object:  StoredProcedure [Partners].[SP_GetAllPartnersShort]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Partners].[SP_GetAllPartnersShort]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT PartnerID, FullName=CONCAT_WS(' ',p.FirstName ,p.LastName),CurrentBalance
    FROM Partners pr join People p on pr.PersonID=p.PersonID ;
END
GO
/****** Object:  StoredProcedure [Partners].[SP_GetPartnerByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Partners].[SP_GetPartnerByID]
    @PartnerID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT PartnerID, PersonID, CurrentBalance, ProfitPercentage, CreatedDate, ModifiedDate, IsActive
    FROM Partners
    WHERE PartnerID = @PartnerID;
END
GO
/****** Object:  StoredProcedure [Partners].[SP_IsPartnerPerson]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Partners].[SP_IsPartnerPerson]
    @PersonID INT
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM Partners WHERE PersonID = @PersonID)
        SELECT CAST(1 AS BIT) AS IsPartner;
    ELSE
        SELECT CAST(0 AS BIT) AS IsPartner;
END
GO
/****** Object:  StoredProcedure [Partners].[SP_SavePartnerWithPercentages]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- 
--  
CREATE Procedure [Partners].[SP_SavePartnerWithPercentages]
    @PartnerID        INT  =null,                           -- NULL = new partner, value = edit
   @PersonID int,
   @CurrentBalance decimal(18,2),
    @ProfitPercentage DECIMAL(5,2),                         -- this partner's own percentage
    @OtherPartners    Partners.PartnerPercentageType READONLY,   -- old partners with their new percentages
  @IsActive bit
  ,  @NewPartnerID     INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    BEGIN TRY
        BEGIN TRAN;

      

        IF @PartnerID IS NULL
        BEGIN
            

            INSERT INTO Partners (PersonID, CurrentBalance,ProfitPercentage, IsActive)
            VALUES (@PersonID, @CurrentBalance,@ProfitPercentage, 1);
            SET @NewPartnerID = SCOPE_IDENTITY();
        END
        ELSE
        BEGIN
 
             
            UPDATE Partners
            SET ProfitPercentage = @ProfitPercentage,
			  CurrentBalance=@CurrentBalance, IsActive=@IsActive,
			  ModifiedDate=GETDATE()
            WHERE PartnerID = @PartnerID;

            SET @NewPartnerID = @PartnerID;
        END

        -- the other partners' new percentages
        UPDATE p
        SET p.ProfitPercentage = o.ProfitPercentage,
		
		p.ModifiedDate=GETDATE()
        FROM Partners p
        JOIN @OtherPartners o ON o.PartnerID = p.PartnerID
        WHERE p.PartnerID <> @NewPartnerID;

        -- the real guard: total must be exactly 100
        DECLARE @Total DECIMAL(9,2) =
            (SELECT ISNULL(SUM(ProfitPercentage), 0) FROM Partners WHERE IsActive = 1);

        IF @Total <> 100
            THROW 50001, 'Total profit percentage must equal 100.', 1;

        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END
GO
/****** Object:  StoredProcedure [Partners].[SP_UpdatePartnerByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [Partners].[SP_UpdatePartnerByID]
    @PartnerID INT,
	@PersonID int,
    @CurrentBalance DECIMAL(18, 2),
    @ProfitPercentage DECIMAL(5, 2),
    @IsActive BIT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Partners
    SET CurrentBalance = @CurrentBalance,
	PersonID=@PersonID,
        ProfitPercentage = @ProfitPercentage,
        IsActive = @IsActive,
        ModifiedDate = SYSDATETIME()
    WHERE PartnerID = @PartnerID;

	select @@ROWCOUNT

END
GO
/****** Object:  StoredProcedure [PartnerTransactions].[SP_AddPartnerTransaction]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


 CREATE procedure [PartnerTransactions].[SP_AddPartnerTransaction]
 @PartnerID int ,
 @TransactionType int,
 @Amount decimal(18,2),
 @Notes nvarchar(500)=null,
 @PartnerTransactionID int output
 as 
 begin

     SET NOCOUNT ON
	  BEGIN TRANSACTION
	   BEGIN TRY
	   insert into PartnerTransactions 
	   values(@PartnerID,@TransactionType,@Amount,SYSDATETIME(),@Notes)

	   set @PartnerTransactionID=SCOPE_IDENTITY();

	   if(@TransactionType=1 or @TransactionType=4)
	   begin 
	  --Update Partner amount
	  update Partners 
	  set 
	  CurrentBalance=CurrentBalance-@Amount
	  where PartnerID=@PartnerID;

	-- if(@TransactionType=4)
	  
	  --Add record to expenses transaction
	   



	   end

	   if(@TransactionType=2 or @TransactionType=3)
	   begin
	    --Update Partner amount
	  update Partners 
	  set 
	  CurrentBalance=CurrentBalance+@Amount
	  where PartnerID=@PartnerID;

	-- if(@TransactionType=3)
	  
	  --Add record to Profit transaction
	   

	   end

	   

	    COMMIT TRANSACTION
	   end try
	    BEGIN CATCH

        ROLLBACK TRANSACTION;

            -- Raise the error back to C# Data Access Layer
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
   

    END CATCH






 end



GO
/****** Object:  StoredProcedure [PartnerTransactions].[SP_UpdatePartnerTransaction]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


 create procedure [PartnerTransactions].[SP_UpdatePartnerTransaction]
 @PartnerID int ,
 @Amount decimal(18,2),
 @PartnerTransactionID int ,
 @TransactionType int
 as 
 begin

     SET NOCOUNT ON
	  BEGIN TRANSACTION
	   BEGIN TRY

	   declare @OldAmount decimal(18,2)

	   select @OldAmount=Amount from PartnerTransactions where PartnerTransactionID=@PartnerTransactionID

	   update   PartnerTransactions 
	  set Amount=@Amount
	  where PartnerTransactionID=@PartnerTransactionID

	    

	   if(@TransactionType=1 or @TransactionType=4)
	   begin 
	  --Update Partner amount
	  update Partners 
	  set 
	  CurrentBalance=CurrentBalance-(@Amount-@OldAmount)
	  where PartnerID=@PartnerID;

	-- if(@TransactionType=4)
	  
	  --Add record to expenses transaction
	   



	   end

	   if(@TransactionType=2 or @TransactionType=3)
	   begin
	    --Update Partner amount
	  update Partners 
	  set 
	  CurrentBalance=CurrentBalance+(@Amount-@OldAmount)
	  where PartnerID=@PartnerID;

	-- if(@TransactionType=3)
	  
	  --Add record to Profit transaction
	   

	   end

	   

	    COMMIT TRANSACTION
	   end try
	    BEGIN CATCH

        ROLLBACK TRANSACTION;

            -- Raise the error back to C# Data Access Layer
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
   

    END CATCH






 end



GO
/****** Object:  StoredProcedure [People].[SP_AddNewPerson]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



 
 CREATE Procedure [People].[SP_AddNewPerson] 
 @FirstName nvarchar(100),@SecondName nvarchar(100),@LastName nvarchar(100),@Phone nvarchar(25),
 @Address nvarchar(500),@ImagePath nvarchar(300) 	
 as
 begin


 insert into People(FirstName,SecondName,LastName,Phone,CreateDate,ModifyDate,Address,ImagePath) values
 (@FirstName,@SecondName,@LastName,@Phone,SYSDATETIME(),null,@Address,@ImagePath);

 select SCOPE_IDENTITY()

 end

GO
/****** Object:  StoredProcedure [People].[SP_DeleteByIDPerson]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [People].[SP_DeleteByIDPerson]
@PersonID int
as begin

delete from People 
where PersonID=@PersonID

end




GO
/****** Object:  StoredProcedure [People].[SP_ExistByIDPersonIs]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

 create procedure [People].[SP_ExistByIDPersonIs]
 @PersonID int
 as begin
 if exists (select 1 from People where PersonID=@PersonID)
 begin 
 return 1;
 end
 else
 begin
 return 0;
 end




 end






GO
/****** Object:  StoredProcedure [People].[SP_GetAllPeople]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [People].[SP_GetAllPeople] 
as
begin

select * from People
order by PersonID
 


end






GO
/****** Object:  StoredProcedure [People].[SP_GetImagePathByPersonID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





create Procedure [People].[SP_GetImagePathByPersonID] @PersonID int
as begin


select ImagePath from People where PersonID=@PersonID

end
GO
/****** Object:  StoredProcedure [People].[SP_GetPersonByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [People].[SP_GetPersonByID] 
@PersonID int
as begin
 SELECT PersonID, FirstName, SecondName, LastName, Phone, CreateDate, ModifyDate, Address,ImagePath
FROM     People
where PersonID=@PersonID
end



GO
/****** Object:  StoredProcedure [People].[SP_GetPersonByPhone]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [People].[SP_GetPersonByPhone] 
@Phone int
as begin
 SELECT PersonID, FirstName, SecondName, LastName, Phone, CreateDate, ModifyDate, Address,ImagePath
FROM     People
where Phone=@Phone
end



GO
/****** Object:  StoredProcedure [People].[SP_UpdatePersonByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE procedure [People].[SP_UpdatePersonByID]
@PersonID int,@FirstName nvarchar(100),@SecondName nvarchar(100),@LastName nvarchar(100),
@Phone nvarchar(100),@Address nvarchar(500),@ImagePath nvarchar(300)
as begin

Update People 
set FirstName=@FirstName,SecondName=@SecondName,LastName=@LastName,Phone=@Phone,
Address=@Address,ImagePath=@ImagePath
where PersonID=@PersonID;


end









GO
/****** Object:  StoredProcedure [Products].[SP_AddNewCategory]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






-- 1. Add New Category
CREATE PROCEDURE [Products].[SP_AddNewCategory]
    @CategoryName NVARCHAR(100),
    @Description NVARCHAR(500)
AS
BEGIN
    INSERT INTO dbo.ProductCategories (CategoryName, [Description], CreatedDate)
    VALUES (@CategoryName, @Description, SYSDATETIME());
    SELECT SCOPE_IDENTITY() AS NewCategoryID;
END;
GO
/****** Object:  StoredProcedure [Products].[SP_AddNewProduct]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



----------------------------------------------------------




-- 2. Add New Product
CREATE PROCEDURE [Products].[SP_AddNewProduct]
    @ProductCategoryID INT,
    @CostPrice DECIMAL(18,2),
    @SellingPrice DECIMAL(18,2),
    @UnitOfSale NVARCHAR(50),
    @ProductName NVARCHAR(200),
    @Description NVARCHAR(MAX),
    @ImagePath NVARCHAR(500),
    @BarCode NVARCHAR(100),
    @QuantityInStock INT,
    @MinimumQuantityForWarning INT
AS
BEGIN
    INSERT INTO dbo.Products (
        ProductCategoryID, CostPrice, SellingPrice, UnitOfSale, ProductName, 
        [Description], ImagePath, BarCode, QuantityInStock, 
        MinimumQuantityForWarning, CreateDate, ModifyDate, IsActive
    )
    VALUES (
        @ProductCategoryID, @CostPrice, @SellingPrice, @UnitOfSale, @ProductName, 
        @Description, @ImagePath, @BarCode, @QuantityInStock, 
        @MinimumQuantityForWarning, SYSDATETIME(), SYSDATETIME(), 1
    );
    SELECT SCOPE_IDENTITY() AS NewProductID;
END;
GO
/****** Object:  StoredProcedure [Products].[SP_DeleteProductByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 6. Delete Product By ID (Soft Delete Recommended)
CREATE PROCEDURE [Products].[SP_DeleteProductByID]
    @ProductID INT
AS
BEGIN
    -- Using a hard delete as requested, but usually "IsActive = 0" is safer
    DELETE FROM dbo.Products WHERE ProductID = @ProductID;
END;
GO
/****** Object:  StoredProcedure [Products].[SP_DeleteProductCategoryByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 6. Delete Product By ID (Soft Delete Recommended)
create PROCEDURE [Products].[SP_DeleteProductCategoryByID]
    @CategoryID INT
AS
BEGIN
    -- Using a hard delete as requested, but usually "IsActive = 0" is safer
    DELETE FROM dbo.ProductCategories WHERE CategoryID = @CategoryID;
END;
GO
/****** Object:  StoredProcedure [Products].[SP_GetAllProducts]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

-------------------------------------


-- 5. Get All Products
CREATE PROCEDURE [Products].[SP_GetAllProducts] 
@PageNumber int,@PageSize int
AS
BEGIN
    
	if(@PageNumber<=0 or @PageSize<=0)
	begin 
	
SELECT   Products.ProductID, Products.ProductName, Products.UnitOfSale, ProductCategories.CategoryName,FORMAT(Products.SellingPrice, '0.##') as SellingPrice ,
FORMAT(Products.CostPrice, '0.##') as CostPrice,Products.ImagePath, 
                         Products.QuantityInStock, Products.MinimumQuantityForWarning, Products.CreateDate,Products.BarCode,Products.ProductCategoryID
FROM         Products INNER JOIN
                         ProductCategories ON Products.ProductCategoryID = ProductCategories.CategoryID
						 order by ProductID 
	end
	else
	begin

SELECT   Products.ProductID, Products.ProductName, Products.UnitOfSale, ProductCategories.CategoryName,FORMAT(Products.SellingPrice, '0.##') as SellingPrice ,
FORMAT(Products.CostPrice, '0.##') as CostPrice,Products.ImagePath, 
                         Products.QuantityInStock, Products.MinimumQuantityForWarning, Products.CreateDate,Products.BarCode,Products.ProductCategoryID
FROM         Products INNER JOIN
                         ProductCategories ON Products.ProductCategoryID = ProductCategories.CategoryID
						 order by ProductID 

offset(@PageNumber - 1) * @PageSize rows
 fetch next @PageSize rows only;
 end

	END;

	 
GO
/****** Object:  StoredProcedure [Products].[SP_GetAllProductsCategory]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [Products].[SP_GetAllProductsCategory]
AS
BEGIN
    SELECT *
    FROM
    ProductCategories ;
END;
GO
/****** Object:  StoredProcedure [Products].[SP_GetLowStockProducts]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------

CREATE PROCEDURE [Products].[SP_GetLowStockProducts]

AS
BEGIN
   SELECT ProductName,QuantityInStock,MinimumQuantityForWarning FROM Products WHERE QuantityInStock <= MinimumQuantityForWarning
END;


GO
/****** Object:  StoredProcedure [Products].[SP_GetProductByBarCode]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 9. Get Product By BarCode
CREATE PROCEDURE [Products].[SP_GetProductByBarCode]
    @BarCode NVARCHAR(100)
AS
BEGIN
    SELECT * FROM dbo.Products WHERE BarCode = @BarCode;
END;
GO
/****** Object:  StoredProcedure [Products].[SP_GetProductByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 8. Get Product By ID
CREATE PROCEDURE [Products].[SP_GetProductByID]
    @ProductID INT
AS
BEGIN
    SELECT * FROM dbo.Products WHERE ProductID = @ProductID;
END;
GO
/****** Object:  StoredProcedure [Products].[SP_GetProductByName]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 7. Get Product By Name
CREATE PROCEDURE [Products].[SP_GetProductByName]
    @ProductName NVARCHAR(200)
AS
BEGIN
    SELECT * FROM dbo.Products  p
    WHERE p.ProductName LIKE '%' + @ProductName + '%';
END;
GO
/****** Object:  StoredProcedure [Products].[SP_GetProductCategoryByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 8. Get Product By ID
create PROCEDURE [Products].[SP_GetProductCategoryByID]
    @CategoryID INT
AS
BEGIN
    SELECT * FROM dbo.ProductCategories WHERE CategoryID = @CategoryID;
END;
GO
/****** Object:  StoredProcedure [Products].[SP_IsProductCategoryExistByName]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [Products].[SP_IsProductCategoryExistByName]
    @CategoryName NVARCHAR(200)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM dbo.ProductCategories WHERE CategoryName = @CategoryName)
        SELECT CAST(1 AS BIT);
    ELSE
        SELECT CAST(0 AS BIT);
END;
GO
/****** Object:  StoredProcedure [Products].[SP_IsProductExistByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 11. Is Product Exist By ID
CREATE PROCEDURE [Products].[SP_IsProductExistByID]
    @ProductID INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM dbo.Products WHERE ProductID = @ProductID)
        SELECT CAST(1 AS BIT);
    ELSE
        SELECT CAST(0 AS BIT);
END;
GO
/****** Object:  StoredProcedure [Products].[SP_IsProductExistByName]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-------------------------

-- 10. Is Product Exist By Name
CREATE PROCEDURE [Products].[SP_IsProductExistByName]
    @ProductName NVARCHAR(200)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM dbo.Products WHERE ProductName = @ProductName)
        SELECT CAST(1 AS BIT);
    ELSE
        SELECT CAST(0 AS BIT);
END;
GO
/****** Object:  StoredProcedure [Products].[SP_UpdateCategoryByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 3. Update Category
CREATE PROCEDURE [Products].[SP_UpdateCategoryByID]
    @CategoryID INT,
    @CategoryName NVARCHAR(100),
    @Description NVARCHAR(500)
AS
BEGIN
    UPDATE dbo.ProductCategories
    SET CategoryName = @CategoryName,
        [Description] = @Description
    WHERE  CategoryID = @CategoryID;
END;
GO
/****** Object:  StoredProcedure [Products].[SP_UpdateProductByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 4. Update Product
CREATE PROCEDURE [Products].[SP_UpdateProductByID]
    @ProductID INT,
    @ProductCategoryID INT,
    @CostPrice DECIMAL(18,2),
    @SellingPrice DECIMAL(18,2),
    @UnitOfSale NVARCHAR(50),
    @ProductName NVARCHAR(200),
    @Description NVARCHAR(MAX),
    @ImagePath NVARCHAR(500),
    @BarCode NVARCHAR(100),
    @QuantityInStock INT,
    @MinimumQuantityForWarning INT,
    @IsActive BIT
AS
BEGIN
    UPDATE dbo.Products
    SET ProductCategoryID = @ProductCategoryID,
        CostPrice = @CostPrice,
        SellingPrice = @SellingPrice,
        UnitOfSale = @UnitOfSale,
        ProductName = @ProductName,
        [Description] = @Description,
        ImagePath = @ImagePath,
        BarCode = @BarCode,
        QuantityInStock = @QuantityInStock,
        MinimumQuantityForWarning = @MinimumQuantityForWarning,
        ModifyDate = SYSDATETIME(),
        IsActive = @IsActive
    WHERE ProductID = @ProductID;
END;
GO
/****** Object:  StoredProcedure [Purchases].[SP_SavePurchase]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
    

 CREATE procedure [Purchases].[SP_SavePurchase]
 @UserID int,@SupplierID int,@PaymentMethodID int,@TotalAmount decimal (18,2),@PaidAmount decimal(18,2)
 ,@DiscountAmount decimal(18,2),@RemainingAmountDebt decimal(18,2),@Notes nvarchar(300),
 @PurchaseDetailsTVP PurchaseDetailsTVP readonly,@PurchaseID int output
 as begin
  SET NOCOUNT ON

   BEGIN TRANSACTION
   BEGIN TRY
     

 --1 insert to the purchase

INSERT INTO [dbo].[Purchases]
           ([UserID]
           ,[SupplierID]
           ,[PaymentMethodID]
           ,[TotalAmount]
           ,[PaidAmount]
           ,[DiscountAmount]
           ,[CreateDate]
           ,[Notes])
     VALUES
           (@UserID  
           ,@SupplierID
           ,@PaymentMethodID 
           ,@TotalAmount 
           ,@PaidAmount
           ,@DiscountAmount ,
		   SYSDATETIME()
           ,@Notes );

  set @PurchaseID=SCOPE_IDENTITY();
--2 Insert to PurchaseDetails

INSERT INTO [dbo].[PurchaseDetails]
           ([PurchaseID]
           ,[ProductID]
           ,[ProductName]
           ,[CostPrice]
           ,[SellingPrice]
           ,[Quantity]
           ,[ReturnedQuantity])
		   select @PurchaseID,d.ProductID,d.ProductName,d.CostPrice,p.SellingPrice,
		   d.Quantity,d.ReturnedQuantity  from @PurchaseDetailsTVP d join Products  p on 
		   d.ProductID=p.ProductID;

		   --3 Add to Product Stock

update p
set p.QuantityInStock=p.QuantityInStock+(d.Quantity-d.ReturnedQuantity)
from Products p join @PurchaseDetailsTVP d on p.ProductID=d.ProductID

--4 Update Supplier RemainginDept

if(@PaidAmount<(@TotalAmount-@DiscountAmount))
begin
Update Suppliers  
set TotalRemainingDebt=TotalRemainingDebt+(@TotalAmount-@DiscountAmount-@PaidAmount)
where SupplierID=@SupplierID
end

  COMMIT TRANSACTION

    END TRY
    BEGIN CATCH

        ROLLBACK TRANSACTION;

            -- Raise the error back to C# Data Access Layer
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
   

    END CATCH


 end

  
GO
/****** Object:  StoredProcedure [Purchases].[SP_UpdatePurchase]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
    

 CREATE procedure [Purchases].[SP_UpdatePurchase]
 @UserID int,@SupplierID int,@PaymentMethodID int,@TotalAmount decimal (18,2),@PaidAmount decimal(18,2)
 ,@DiscountAmount decimal(18,2),@RemainingAmountDebt decimal(18,2),@Notes nvarchar(300),
 @Details PurchaseDetailsTVP readonly,@PurchaseID int 
 as begin
  SET NOCOUNT ON

   BEGIN TRANSACTION
   BEGIN TRY
     
		Declare @OldTotal decimal(18,2),@OldDiscount decimal(18,2),@OldPaid decimal(18,2),@OldSupplierID int

		select @OldDiscount=s.DiscountAmount,@OldTotal=s.TotalAmount,@OldPaid=s.PaidAmount,@OldSupplierID=SupplierID
		from Purchases s
		where PurchaseID=@PurchaseID

 --1 Update the purchase
 
UPDATE [dbo].[Purchases]
   SET [UserID] = @UserID
      ,[SupplierID] = @SupplierID
      ,[PaymentMethodID] = @PaymentMethodID 
      ,[TotalAmount] = @TotalAmount 
      ,[PaidAmount] = @PaidAmount 
      ,[DiscountAmount] = @DiscountAmount
      ,[Notes] = @Notes
	  ,ModifyDate=SYSDATETIME()
	  WHERE PurchaseID=@PurchaseID
--         ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        -- 2. Update Sale Details
        -- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
       -- 1. تعريف الجدول المؤقت لالتقاط التغييرات بدقة متناهية
DECLARE @ChangesTable TABLE (
    ActionType VARCHAR(10),
    ProductID INT,
    OldQty INT,
    NewQty INT,
    OldReturnQ INT,
    NewReturnQ INT,
    OldPrice DECIMAL(18,2),
    NewPrice DECIMAL(18,2)
);

-- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
-- 2. Update Purchase Details USING MERGE
-- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
 select * from PurchaseDetails

MERGE PurchaseDetails AS Target
USING (
    -- جلب قائمة المواد القادمة مع دمجها بجدول المنتجات لجلب الاسم والتكلفة
    SELECT d.ProductID,  p.ProductName ,  p.CostPrice,p.SellingPrice,d.Quantity, d.ReturnedQuantity  
         
    FROM @Details d
    INNER JOIN Products p ON d.ProductID = p.ProductID
) AS Source

-- المطابقة برقم الفاتورة ورقم المنتج معاً
ON (Target.PurchaseID = @PurchaseID AND Target.ProductID = Source.ProductID)

-- في حال المادة موجودة مسبقاً (تعديل الأسطر الحالية)
WHEN MATCHED THEN
    UPDATE SET 
        Target.Quantity = Source.Quantity, 
        Target.SellingPrice = Source.SellingPrice,
        Target.ReturnedQuantity = Source.ReturnedQuantity

-- في حال المادة جديدة تماماً على الفاتورة (إضافة سطر جديد)
WHEN NOT MATCHED BY TARGET THEN
    INSERT (PurchaseID, ProductID, ProductName,CostPrice, SellingPrice, Quantity, ReturnedQuantity)
    VALUES (@PurchaseID, Source.ProductID,Source.ProductName, Source.CostPrice, Source.SellingPrice, Source.Quantity, Source.ReturnedQuantity)

-- في حال المادة حذفت من الـ DataGridView (حذف من الفاتورة)
WHEN NOT MATCHED BY SOURCE AND Target.PurchaseID = @PurchaseID THEN
    DELETE

-- هنا تم إصلاح أسماء الحقول لتطابق جدولك (SellingPrice بدلاً من Price)
OUTPUT 
    $action, 
    COALESCE(inserted.ProductID, deleted.ProductID),
    deleted.Quantity,          
    inserted.Quantity,         
    deleted.ReturnedQuantity,  
    inserted.ReturnedQuantity, 

    deleted.SellingPrice,      -- تم التعديل هنا لتطابق جدولك 🌟
    inserted.SellingPrice      -- تم التعديل هنا لتطابق جدولك 🌟
INTO @ChangesTable;	

		
        -- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        -- 3. Update  Products Stock
        -- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━                   
        UPDATE P                                              
            SET P.QuantityInStock = P.QuantityInStock +(ISNULL( D.NewQty,0)-ISNULL( D.NewReturnQ,0)-(ISNULL( D.OldQty,0)-ISNULL( D.OldReturnQ,0)))
        FROM Products P
        INNER JOIN @ChangesTable D ON P.ProductID = D.ProductID

		--4--
		--Update Total Remaining Debt


		if(@OldSupplierID=@SupplierID)
		begin
		Update Suppliers 
		set TotalRemainingDebt=TotalRemainingDebt+(@TotalAmount-@DiscountAmount)-@PaidAmount-((@OldTotal-@OldDiscount)-@OldPaid)
		 where SupplierID=@SupplierID
		 end
		 else
		 begin
		 --OldSupplier change
		 Update Suppliers 
		set TotalRemainingDebt=TotalRemainingDebt-((@OldTotal-@OldDiscount)-@OldPaid)
		 where SupplierID=@OldSupplierID;

		 --New Supplier

		 Update Suppliers 
		set TotalRemainingDebt=TotalRemainingDebt+(@TotalAmount-@DiscountAmount)-@PaidAmount
		 where SupplierID=@SupplierID                                                                    

		 end
		 


 

  COMMIT TRANSACTION

    END TRY
    BEGIN CATCH

        ROLLBACK TRANSACTION;

            -- Raise the error back to C# Data Access Layer
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
   

    END CATCH


 end

  
GO
/****** Object:  StoredProcedure [Sales].[SP_AddNewSale]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

  
CREATE PROCEDURE [Sales].[SP_AddNewSale]
    @UserID INT,
    @CustomerID INT = 6,     
    @PaymentMethodID INT=1,
    @Status TINYINT =1,
    @TotalAmount DECIMAL(18, 2)=0,
    @PaidAmount DECIMAL(18, 2)=0,
    @DiscountAmount DECIMAL(18, 2) = 0.00,
    @Notes NVARCHAR(400) = NULL,
    @NewSaleID INT OUTPUT            -- Output parameter to pass the ID back to C#
AS
BEGIN
   SET NOCOUNT ON;

    BEGIN TRY

	if exists (select 1 from Sales where Status=1) 
	begin
	
	select @NewSaleID=SaleID from  Sales where Status=1;
	
	update Sales set UserID=@UserID where SaleID=@NewSaleID
	
	end
	else
	begin

	  -- Single Insert Operation
        INSERT INTO [dbo].[Sales]
        (
            [UserID],
            [CustomerID],
            [PaymentMethodID],
            [Status],
            [TotalAmount],
            [PaidAmount],
            [DiscountAmount],
            [CreateDate],
            [Notes]
        )
        VALUES
        (
            @UserID,
            @CustomerID,
            @PaymentMethodID,
            @Status,
            @TotalAmount,
            @PaidAmount,
            @DiscountAmount,
            GETDATE(), 
            @Notes
        );

        -- Immediately capture the new ID for C# to use
        SET @NewSaleID = SCOPE_IDENTITY();

	end
      

    END TRY
    BEGIN CATCH
        -- Raise the error back to C# Data Access Layer
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
GO
/****** Object:  StoredProcedure [Sales].[SP_SaveSale]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Sales].[SP_SaveSale]
   @UserID int,
    @CustomerID INT,
	@PaymentMethodID int,
	@TotalAmount decimal(18,2),
	@PaidAmount decimal(18,2),
	@DiscountAmount decimal(18,2),
   @Notes nvarchar(1000),
    @Details    SaleDetailType readonly , @SaleId int output
AS
BEGIN
    SET NOCOUNT ON
    BEGIN TRANSACTION

    BEGIN TRY

	 

        -- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        -- 1. Insert Sale Header
        -- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        
		insert into Sales(UserID,CustomerID,PaymentMethodID,TotalAmount,PaidAmount,DiscountAmount,CreateDate,Notes)
		values(@UserID,@CustomerID,@PaymentMethodID,@TotalAmount,@PaidAmount,@DiscountAmount,SYSDATETIME(),@Notes)
		set @SaleId=SCOPE_IDENTITY();
         
      

        -- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        -- 2. Insert Sale Details
        -- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        INSERT INTO SaleDetails (SaleID, ProductID,CostPrice,
		SellingPrice,Quantity,ReturnedQuantity,ProductName, DiscountAmount)
        SELECT @SaleID,
		
		p.ProductID,p.CostPrice,
		d.SellingPrice,Quantity,ReturnedQuantity,p.ProductName, DiscountAmount
        FROM @Details d join Products p on d.ProductID=p.ProductID


        -- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        -- 3. Subtract from Products Stock
        -- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        UPDATE P
            SET P.QuantityInStock = P.QuantityInStock - D.Quantity+D.ReturnedQuantity
        FROM Products P
        INNER JOIN @Details D ON P.ProductID = D.ProductID


        ---- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        ---- 4. Calculate Profit per Product
        ----    Profit = (SalePrice - CostPrice) * Quantity
        ---- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        DECLARE @TotalCost DECIMAL(18,2), @TotalSelling DEcimal(18,2);

        SELECT @TotalCost = SUM( P.CostPrice * (D.Quantity-D.ReturnedQuantity)),
		@TotalSelling= SUM( D.SellingPrice * (D.Quantity-D.ReturnedQuantity))
        FROM @Details D
        INNER JOIN Products P ON P.ProductID = D.ProductID

		set @TotalSelling=@TotalSelling-@DiscountAmount;
		declare  @ProfitRunID int;

		 


        INSERT INTO ProfitRuns(UserID,SaleID, TotalCost, TotalSelling,CreatedDate)
        VALUES (@UserID,@SaleID, @TotalCost,@TotalSelling,SYSDATETIME())

		set @ProfitRunID=SCOPE_IDENTITY();

        ---- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        ---- 5. Distribute Profit to Partners
        ----    Each partner has a SharePercent in Partners table
        ---- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
       
	   Declare @PartnerID int,@MaxID int,@Percentage decimal(5,2),@TransactionID int,@ProfitAmount decimal(18,2);
	  
	  select  @PartnerID=min(PartnerID),@MaxID=max(PartnerID) from Partners
	   
	   while @PartnerID is not null and @PartnerID<=@MaxID
	   begin
	   
	   select @Percentage=ProfitPercentage from Partners where PartnerID=@PartnerID
	   
	   set @ProfitAmount=((@TotalSelling-@TotalCost)*@Percentage)/100;
	   exec PartnerTransactions.SP_AddPartnerTransaction @PartnerID,3,@ProfitAmount,null,@TransactionID output; 
	   
	   --Add ProfitTransaction Record
	   insert into ProfitTransactions values
	   (@TransactionID,@ProfitRunID);


	   select @PartnerID=min(PartnerID) from Partners where PartnerID>@PartnerID

	   end



		--6--
		--Update Total Remaining Debt

		Update Customers 
		set TotalRemainingDebt=TotalRemainingDebt+(@TotalAmount-@DiscountAmount)-@PaidAmount
		 where CustomerID=@CustomerID

        COMMIT TRANSACTION

    END TRY
    BEGIN CATCH

        ROLLBACK TRANSACTION;

            -- Raise the error back to C# Data Access Layer
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
   

    END CATCH
END




GO
/****** Object:  StoredProcedure [Sales].[SP_UpdateSale]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [Sales].[SP_UpdateSale]
    @SaleId int,
	@UserID int,
    @CustomerID INT,
	@PaymentMethodID int,
	@TotalAmount decimal(18,2),
	@PaidAmount decimal(18,2),
	@DiscountAmount decimal(18,2),
   @Notes nvarchar(1000),
    @Details    SaleDetailType readonly 
AS
BEGIN
    SET NOCOUNT ON
    BEGIN TRANSACTION

    BEGIN TRY


	
		Declare @OldTotal decimal(18,2),@OldDiscount decimal(18,2),@OldPaid decimal(18,2),@OldCustomerID int

		select @OldCustomerID=CustomerID, @OldDiscount=s.DiscountAmount,@OldTotal=s.TotalAmount,@OldPaid=s.PaidAmount from Sales s
		where SaleID=@SaleId


        -- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        -- 1. Update Sale Header
        -- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        

        Update Sales set CustomerID=@CustomerID,
PaymentMethodID=@PaymentMethodID,UserID=@UserID,
TotalAmount=@TotalAmount,PaidAmount=@PaidAmount,
DiscountAmount=@DiscountAmount,Notes=@Notes,ModifyDate=GETDATE()
where SaleID=@SaleId
      

        -- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        -- 2. Update Sale Details
        -- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
       -- 1. تعريف الجدول المؤقت لالتقاط التغييرات بدقة متناهية
DECLARE @ChangesTable TABLE (
    ActionType VARCHAR(10),
    ProductID INT,
    OldQty INT,
    NewQty INT,
    OldReturnQ INT,
    NewReturnQ INT,
    OldDiscount DECIMAL(18,2),
    NewDiscount DECIMAL(18,2),
    OldPrice DECIMAL(18,2),
    NewPrice DECIMAL(18,2)
);

-- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
-- 2. Update Sale Details USING MERGE
-- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━

MERGE SaleDetails AS Target
USING (
    -- جلب قائمة المواد القادمة مع دمجها بجدول المنتجات لجلب الاسم والتكلفة
    SELECT d.ProductID, d.Quantity, d.ReturnedQuantity, d.SellingPrice, d.DiscountAmount,
           p.ProductName, p.CostPrice
    FROM @Details d
    INNER JOIN Products p ON d.ProductID = p.ProductID
) AS Source

-- المطابقة برقم الفاتورة ورقم المنتج معاً
ON (Target.SaleID = @SaleID AND Target.ProductID = Source.ProductID)

-- في حال المادة موجودة مسبقاً (تعديل الأسطر الحالية)
WHEN MATCHED THEN
    UPDATE SET 
        Target.Quantity = Source.Quantity, 
        Target.SellingPrice = Source.SellingPrice,
        Target.ReturnedQuantity = Source.ReturnedQuantity,
        Target.DiscountAmount = Source.DiscountAmount

-- في حال المادة جديدة تماماً على الفاتورة (إضافة سطر جديد)
WHEN NOT MATCHED BY TARGET THEN
    INSERT (SaleID, ProductID, CostPrice, SellingPrice, Quantity, ReturnedQuantity, ProductName, DiscountAmount)
    VALUES (@SaleID, Source.ProductID, Source.CostPrice, Source.SellingPrice, Source.Quantity, Source.ReturnedQuantity, Source.ProductName, Source.DiscountAmount)

-- في حال المادة حذفت من الـ DataGridView (حذف من الفاتورة)
WHEN NOT MATCHED BY SOURCE AND Target.SaleID = @SaleID THEN
    DELETE

-- هنا تم إصلاح أسماء الحقول لتطابق جدولك (SellingPrice بدلاً من Price)
OUTPUT 
    $action, 
    COALESCE(inserted.ProductID, deleted.ProductID),
    deleted.Quantity,          
    inserted.Quantity,         
    deleted.ReturnedQuantity,  
    inserted.ReturnedQuantity, 
    deleted.DiscountAmount,    
    inserted.DiscountAmount,   
    deleted.SellingPrice,      -- تم التعديل هنا لتطابق جدولك 🌟
    inserted.SellingPrice      -- تم التعديل هنا لتطابق جدولك 🌟
INTO @ChangesTable;	


        -- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        -- 3. Update  Products Stock
        -- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━   
 
        UPDATE P                                              
            SET P.QuantityInStock = P.QuantityInStock -(ISNULL( D.NewQty,0)-ISNULL( D.NewReturnQ,0)-(ISNULL( D.OldQty,0)-ISNULL( D.OldReturnQ,0)))
        FROM Products P
        INNER JOIN @ChangesTable D ON P.ProductID = D.ProductID



        ---- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        ---- 4. Calculate Profit per Product
        ----    Profit = (SalePrice - CostPrice) * Quantity
        ---- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
			declare @ProfitRunID int;

		select  @ProfitRunID=ProfitRunID from ProfitRuns where SaleID=@SaleId;


        DECLARE @NewTotalCost DECIMAL(18,2), @NewTotalSelling DEcimal(18,2);
     DECLARE @OldTotalCost DECIMAL(18,2), @OldTotalSelling DEcimal(18,2);
	
	select @OldTotalCost=TotalCost,@OldTotalSelling=TotalSelling from ProfitRuns where ProfitRunID=@ProfitRunID

        SELECT @NewTotalCost = SUM( P.CostPrice * (D.Quantity-D.ReturnedQuantity)),
		@NewTotalSelling= SUM( D.SellingPrice * (D.Quantity-D.ReturnedQuantity))
        FROM @Details D
        INNER JOIN Products P ON P.ProductID = D.ProductID

		set @NewTotalSelling=@NewTotalSelling-@DiscountAmount;
	
		 


        update   ProfitRuns 
       set TotalCost=@NewTotalCost,TotalSelling=@NewTotalSelling
	   where SaleID=@SaleId
		

        ---- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
        ---- 5. Distribute Profit to Partners
        ----    Each partner has a SharePercent in Partners table
        ---- ━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
       
	   Declare @PartnerID int,@MaxID int,@Percentage decimal(5,2),@TransactionID int,@NewProfitAmount decimal(18,2);
	    declare @PartnerTransactionID int

	  select  @PartnerID=min(PartnerID),@MaxID=max(PartnerID) from Partners
	   
	   while @PartnerID is not null and @PartnerID<=@MaxID
	   begin

	   SELECT @PartnerTransactionID =d.[PartnerTransactionID]
  FROM [AccountantDB].[dbo].[PartnerTransactions] p
  join ProfitTransactions d
  on p.PartnerTransactionID=d.PartnerTransactionID 
  where PartnerID=1 and d.ProfitRunID=5

	   
	   select @Percentage=ProfitPercentage from Partners where PartnerID=@PartnerID
	   
	   set @NewProfitAmount=((@NewTotalSelling-@NewTotalCost)*@Percentage)/100;
	   exec PartnerTransactions.SP_UpdatePartnerTransaction @PartnerID,@NewProfitAmount,@PartnerTransactionID,3
	   
	   


	   select @PartnerID=min(PartnerID) from Partners where PartnerID>@PartnerID

	   end



		--6--
		--Update Total Remaining Debt

		if(@OldCustomerID=@CustomerID)
		begin
		Update Customers 
		set TotalRemainingDebt=TotalRemainingDebt+(@TotalAmount-@DiscountAmount)-@PaidAmount-((@OldTotal-@OldDiscount)-@OldPaid)
		 where CustomerID=@CustomerID
		 end
		 else
		 begin
		 --OldCustomer change
		 Update Customers 
		set TotalRemainingDebt=TotalRemainingDebt-((@OldTotal-@OldDiscount)-@OldPaid)
		 where CustomerID=@OldCustomerID;

		 --New Customer

		 Update Customers 
		set TotalRemainingDebt=TotalRemainingDebt+(@TotalAmount-@DiscountAmount)-@PaidAmount
		 where CustomerID=@CustomerID                                                                    

		 end

        COMMIT TRANSACTION

    END TRY
    BEGIN CATCH

        ROLLBACK TRANSACTION
		 
            -- Raise the error back to C# Data Access Layer
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();

        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);

    END CATCH
END


GO
/****** Object:  StoredProcedure [Suppliers].[SP_AddNewSupplier]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO








CREATE PROCEDURE [Suppliers].[SP_AddNewSupplier]
    @PersonID INT,
    @TotalRemainingDebt DECIMAL(18,2) = 0.00,
    @Notes NVARCHAR(MAX) = NULL,
    @IsActive BIT = 1
AS
BEGIN
    
    INSERT INTO [dbo].[Suppliers] ([PersonID], [TotalRemainingDebt], [Notes], [IsActive], [CreatedDate], [ModifiedDate])
    VALUES (@PersonID, @TotalRemainingDebt, @Notes, @IsActive, GETDATE(), GETDATE());

    SELECT SCOPE_IDENTITY() AS NewSupplierID;
END;
GO
/****** Object:  StoredProcedure [Suppliers].[SP_DeleteSupplierByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Suppliers].[SP_DeleteSupplierByID]
    @SupplierID INT
AS
BEGIN

    DELETE FROM [dbo].[Suppliers]
    WHERE SupplierID = @SupplierID;

END;
GO
/****** Object:  StoredProcedure [Suppliers].[SP_GetAllSuppliers]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Suppliers].[SP_GetAllSuppliers]
@PageNumber int,@PageSize int,    @OnlyActive BIT = 0
AS
BEGIN


    SELECT [SupplierID], FullName=CONCAT_WS(' ',p.FirstName,p.SecondName,p.LastName),case when p.Phone is null then 'لا يوجد' else p.Phone end as Phone ,
	case when p.Address is null then 'لا يوجد' else p.Address end as Address,
	
	[IsActive],FORMAT( [TotalRemainingDebt],'0.##') as [TotalRemainingDebt]
    FROM [dbo].[Suppliers] s join People p on s.PersonID=p.PersonID
    
    WHERE (@OnlyActive = 0 OR [IsActive] = 1)
    ORDER BY SupplierID asc
	offset(@PageNumber - 1) * @PageSize rows
fetch next @PageSize rows only
END;
GO
/****** Object:  StoredProcedure [Suppliers].[SP_GetSupplierByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Suppliers].[SP_GetSupplierByID]
    @SupplierID INT
AS
BEGIN

    SELECT SupplierID, [PersonID], [TotalRemainingDebt], [Notes], [CreatedDate], [ModifiedDate], [IsActive]
    FROM [dbo].[Suppliers]
    WHERE SupplierID = @SupplierID;
END;
GO
/****** Object:  StoredProcedure [Suppliers].[SP_GetSupplierByPersonID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [Suppliers].[SP_GetSupplierByPersonID]
    @PersonID INT
AS
BEGIN

    SELECT SupplierID, [PersonID], [TotalRemainingDebt], [Notes], [CreatedDate], [ModifiedDate], [IsActive]
    FROM [dbo].[Suppliers]
    WHERE SupplierID = @PersonID;
END;
GO
/****** Object:  StoredProcedure [Suppliers].[SP_IsPersonSupplier]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [Suppliers].[SP_IsPersonSupplier] @PersonID int
as begin

if exists(select 1 from Suppliers where PersonID=@PersonID)
select 1 ;
ELSE
SELECT 0;


end
GO
/****** Object:  StoredProcedure [Suppliers].[SP_UpdateSupplierByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROCEDURE [Suppliers].[SP_UpdateSupplierByID]
    @SupplierID INT,
    @PersonID INT,
    @TotalRemainingDebt DECIMAL(18,2),
    @Notes NVARCHAR(MAX),
    @IsActive BIT
AS
BEGIN

    UPDATE [dbo].[Suppliers]
    SET [PersonID] = @PersonID,
        [TotalRemainingDebt] = @TotalRemainingDebt,
        [Notes] = @Notes,
        [IsActive] = @IsActive,
        [ModifiedDate] = GETDATE()
    WHERE [SupplierID] = @SupplierID;
    
END;
GO
/****** Object:  StoredProcedure [Users].[SP_AddNewUser]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE procedure [Users].[SP_AddNewUser] (@PersonID int,@UserName nvarchar(40),
                               @HashPassword nvarchar(409),@Notes nvarchar(300),
							    @PermissionInBinary int,@PasswordSalt nvarchar(400))
as begin



INSERT INTO [dbo].[Users]
           ([PersonID]
           ,[UserName]
           ,[HashPassword]
           ,[Notes]
           ,[PermissionInBinary]
           ,[IsActive]
		   ,[PasswordSalt])
     VALUES
           (@PersonID
           ,@UserName 
           ,@HashPassword 
           ,@Notes 
           ,@PermissionInBinary  
            ,1
			,@PasswordSalt)

			select SCOPE_IDENTITY();

end



GO
/****** Object:  StoredProcedure [Users].[SP_DeleteUserByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 


 create procedure [Users].[SP_DeleteUserByID] (@UserID int)
 as begin

 Delete from Users
 WHERE UserID=@UserID

 end



 
GO
/****** Object:  StoredProcedure [Users].[SP_GetAllUsers]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 


CREATE procedure [Users].[SP_GetAllUsers]  
as
begin

SELECT UserID, u.PersonID, UserName,FullName=CONCAT_WS(' ',p.FirstName,p.SecondName,p.LastName) ,Notes, CreatedDate, IsActive 
FROM     Users u join People p on u.PersonID=p.PersonID
order by UserID
  
end






GO
/****** Object:  StoredProcedure [Users].[SP_GetUserByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [Users].[SP_GetUserByID]
@UserID int
as begin
 SELECT UserID, PersonID, UserName, HashPassword, Notes, PermissionInBinary, CreatedDate, IsActive,PasswordSalt
FROM     Users where UserID=@UserID

end



GO
/****** Object:  StoredProcedure [Users].[SP_GetUserByUserName]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
 


Create procedure [Users].[SP_GetUserByUserName]
@UserName nvarchar(399)
as begin
 SELECT UserID, PersonID, UserName, HashPassword, Notes, PermissionInBinary, CreatedDate, IsActive,PasswordSalt
FROM     Users where UserName=@UserName

end



GO
/****** Object:  StoredProcedure [Users].[SP_IsUserExistByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
 
 

 CREATE procedure [Users].[SP_IsUserExistByID]
 @UserID int
 as begin
 if exists (select 1 from Users where UserID=@UserID)
 begin 
 select  1;
 end
 else
 begin
 select 0;
 end


 end






GO
/****** Object:  StoredProcedure [Users].[SP_IsUserExistByUserName]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
 
 

 CREATE procedure [Users].[SP_IsUserExistByUserName]
 @UserName nvarchar(200)
 as begin
 if exists (select 1 from Users where UserName=@UserName )
 begin 
 select 1;
 end
 else
 begin
 select 0;
 end


 end






GO
/****** Object:  StoredProcedure [Users].[SP_UpdateUserByID]    Script Date: 15/10/2026 03:17:50 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 


 CREATE procedure [Users].[SP_UpdateUserByID] (@UserID int,@PersonID int,@UserName nvarchar(40),
                               @HashPassword nvarchar(300),@Notes nvarchar(300),
							    @PermissionInBinary int,@IsActive bit)
 as begin

 

UPDATE  Users 
   SET [PersonID] = @PersonID
      ,[UserName] = @UserName
      ,[HashPassword] = @HashPassword
      ,[Notes] = @Notes
      ,[PermissionInBinary] = @PermissionInBinary
      ,[IsActive] = @IsActive 
 WHERE UserID=@UserID


 end



 
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1-cash 2-not chash 3-vip' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Customers', @level2type=N'COLUMN',@level2name=N'CustomerType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1-Withdraw 2-Deposite  3-Profit  4-Expense' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PartnerTransactions', @level2type=N'COLUMN',@level2name=N'TransactionType'
GO
USE [master]
GO
ALTER DATABASE [AccountantDB] SET  READ_WRITE 
GO
