USE [master]
GO
/****** Object:  Database [Soccer]    Script Date: 25.10.2023 02:42:43 ******/
CREATE DATABASE [Soccer]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Soccer', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLKODLAB\MSSQL\DATA\Soccer.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Soccer_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLKODLAB\MSSQL\DATA\Soccer_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Soccer] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Soccer].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Soccer] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Soccer] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Soccer] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Soccer] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Soccer] SET ARITHABORT OFF 
GO
ALTER DATABASE [Soccer] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Soccer] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Soccer] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Soccer] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Soccer] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Soccer] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Soccer] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Soccer] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Soccer] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Soccer] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Soccer] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Soccer] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Soccer] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Soccer] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Soccer] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Soccer] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Soccer] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Soccer] SET RECOVERY FULL 
GO
ALTER DATABASE [Soccer] SET  MULTI_USER 
GO
ALTER DATABASE [Soccer] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Soccer] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Soccer] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Soccer] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Soccer] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Soccer] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Soccer', N'ON'
GO
ALTER DATABASE [Soccer] SET QUERY_STORE = ON
GO
ALTER DATABASE [Soccer] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Soccer]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 25.10.2023 02:42:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Leaguess]    Script Date: 25.10.2023 02:42:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Leaguess](
	[LeaguesId] [int] IDENTITY(1,1) NOT NULL,
	[LeagueName] [nvarchar](max) NULL,
	[LeagueCountry] [nvarchar](max) NULL,
	[MostChampTeam] [nvarchar](max) NULL,
	[NumbofTeams] [int] NOT NULL,
 CONSTRAINT [PK_Leaguess] PRIMARY KEY CLUSTERED 
(
	[LeaguesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Managerss]    Script Date: 25.10.2023 02:42:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Managerss](
	[ManagersId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Age] [int] NOT NULL,
	[Salary] [int] NOT NULL,
	[TeamsId] [int] NOT NULL,
 CONSTRAINT [PK_Managerss] PRIMARY KEY CLUSTERED 
(
	[ManagersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Playerss]    Script Date: 25.10.2023 02:42:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Playerss](
	[PlayerId] [int] IDENTITY(1,1) NOT NULL,
	[PlayerName] [nvarchar](max) NULL,
	[PlayerSalary] [decimal](18, 2) NOT NULL,
	[MarketValue] [decimal](18, 2) NOT NULL,
	[DateofBirth] [datetime2](7) NOT NULL,
	[Nationality] [nvarchar](max) NULL,
	[TeamsId] [int] NOT NULL,
 CONSTRAINT [PK_Playerss] PRIMARY KEY CLUSTERED 
(
	[PlayerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teamss]    Script Date: 25.10.2023 02:42:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teamss](
	[TeamId] [int] IDENTITY(1,1) NOT NULL,
	[TeamName] [nvarchar](max) NULL,
	[TeamCountry] [nvarchar](max) NULL,
	[TotalValue] [decimal](18, 2) NOT NULL,
	[LeaguesId] [int] NOT NULL,
 CONSTRAINT [PK_Teamss] PRIMARY KEY CLUSTERED 
(
	[TeamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231019170520_init', N'5.0.17')
GO
SET IDENTITY_INSERT [dbo].[Leaguess] ON 

INSERT [dbo].[Leaguess] ([LeaguesId], [LeagueName], [LeagueCountry], [MostChampTeam], [NumbofTeams]) VALUES (1, N'sdfaasd', N'afdsfdas', N'adfsafd', 23)
INSERT [dbo].[Leaguess] ([LeaguesId], [LeagueName], [LeagueCountry], [MostChampTeam], [NumbofTeams]) VALUES (2, N'sdfaasd', N'afdsfdas', N'adfsafd', 233)
INSERT [dbo].[Leaguess] ([LeaguesId], [LeagueName], [LeagueCountry], [MostChampTeam], [NumbofTeams]) VALUES (3, N'asdfads', N'fsadfdas', N'sadf', 23)
INSERT [dbo].[Leaguess] ([LeaguesId], [LeagueName], [LeagueCountry], [MostChampTeam], [NumbofTeams]) VALUES (4, N'asdfads', N'fsadfdas', N'sadf', 2333)
INSERT [dbo].[Leaguess] ([LeaguesId], [LeagueName], [LeagueCountry], [MostChampTeam], [NumbofTeams]) VALUES (5, N'asdfa', N'afdafds', N'fasddas', 433)
SET IDENTITY_INSERT [dbo].[Leaguess] OFF
GO
SET IDENTITY_INSERT [dbo].[Teamss] ON 

INSERT [dbo].[Teamss] ([TeamId], [TeamName], [TeamCountry], [TotalValue], [LeaguesId]) VALUES (2, N'asdfas', N'klfdsagadks', CAST(3432423.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Teamss] ([TeamId], [TeamName], [TeamCountry], [TotalValue], [LeaguesId]) VALUES (3, N'sdfaasfd', N'fdsakjgasdf', CAST(322343.00 AS Decimal(18, 2)), 2)
SET IDENTITY_INSERT [dbo].[Teamss] OFF
GO
/****** Object:  Index [IX_Managerss_TeamsId]    Script Date: 25.10.2023 02:42:44 ******/
CREATE NONCLUSTERED INDEX [IX_Managerss_TeamsId] ON [dbo].[Managerss]
(
	[TeamsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Playerss_TeamsId]    Script Date: 25.10.2023 02:42:44 ******/
CREATE NONCLUSTERED INDEX [IX_Playerss_TeamsId] ON [dbo].[Playerss]
(
	[TeamsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Teamss_LeaguesId]    Script Date: 25.10.2023 02:42:44 ******/
CREATE NONCLUSTERED INDEX [IX_Teamss_LeaguesId] ON [dbo].[Teamss]
(
	[LeaguesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Managerss]  WITH CHECK ADD  CONSTRAINT [FK_Managerss_Teamss_TeamsId] FOREIGN KEY([TeamsId])
REFERENCES [dbo].[Teamss] ([TeamId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Managerss] CHECK CONSTRAINT [FK_Managerss_Teamss_TeamsId]
GO
ALTER TABLE [dbo].[Playerss]  WITH CHECK ADD  CONSTRAINT [FK_Playerss_Teamss_TeamsId] FOREIGN KEY([TeamsId])
REFERENCES [dbo].[Teamss] ([TeamId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Playerss] CHECK CONSTRAINT [FK_Playerss_Teamss_TeamsId]
GO
ALTER TABLE [dbo].[Teamss]  WITH CHECK ADD  CONSTRAINT [FK_Teamss_Leaguess_LeaguesId] FOREIGN KEY([LeaguesId])
REFERENCES [dbo].[Leaguess] ([LeaguesId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Teamss] CHECK CONSTRAINT [FK_Teamss_Leaguess_LeaguesId]
GO
USE [master]
GO
ALTER DATABASE [Soccer] SET  READ_WRITE 
GO
