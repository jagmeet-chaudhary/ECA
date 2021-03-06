USE [master]
GO
/****** Object:  Database [ECA]    Script Date: 02/18/2014 13:51:56 ******/
CREATE DATABASE [ECA] ON  PRIMARY 
( NAME = N'ECA', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.LOCALSQLSERVER\MSSQL\DATA\ECA.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ECA_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.LOCALSQLSERVER\MSSQL\DATA\ECA_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ECA] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ECA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ECA] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [ECA] SET ANSI_NULLS OFF
GO
ALTER DATABASE [ECA] SET ANSI_PADDING OFF
GO
ALTER DATABASE [ECA] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [ECA] SET ARITHABORT OFF
GO
ALTER DATABASE [ECA] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [ECA] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [ECA] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [ECA] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [ECA] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [ECA] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [ECA] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [ECA] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [ECA] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [ECA] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [ECA] SET  DISABLE_BROKER
GO
ALTER DATABASE [ECA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [ECA] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [ECA] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [ECA] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [ECA] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [ECA] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [ECA] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [ECA] SET  READ_WRITE
GO
ALTER DATABASE [ECA] SET RECOVERY SIMPLE
GO
ALTER DATABASE [ECA] SET  MULTI_USER
GO
ALTER DATABASE [ECA] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [ECA] SET DB_CHAINING OFF
GO
USE [ECA]
GO
/****** Object:  User [eca]    Script Date: 02/18/2014 13:51:56 ******/
CREATE USER [eca] FOR LOGIN [eca] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[webpages_Roles]    Script Date: 02/18/2014 13:51:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](256) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[RoleName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[webpages_OAuthMembership]    Script Date: 02/18/2014 13:51:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_OAuthMembership](
	[Provider] [nvarchar](30) NOT NULL,
	[ProviderUserId] [nvarchar](100) NOT NULL,
	[UserId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Provider] ASC,
	[ProviderUserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[webpages_Membership]    Script Date: 02/18/2014 13:51:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_Membership](
	[UserId] [int] NOT NULL,
	[CreateDate] [datetime] NULL,
	[ConfirmationToken] [nvarchar](128) NULL,
	[IsConfirmed] [bit] NULL,
	[LastPasswordFailureDate] [datetime] NULL,
	[PasswordFailuresSinceLastSuccess] [int] NOT NULL,
	[Password] [nvarchar](128) NOT NULL,
	[PasswordChangedDate] [datetime] NULL,
	[PasswordSalt] [nvarchar](128) NOT NULL,
	[PasswordVerificationToken] [nvarchar](128) NULL,
	[PasswordVerificationTokenExpirationDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 02/18/2014 13:51:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](56) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__Users__1788CC4C3E52440B] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Users__C9F28456412EB0B6] UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genre]    Script Date: 02/18/2014 13:51:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Genre](
	[GenreId] [varchar](10) NOT NULL,
	[GenreName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Genre] PRIMARY KEY CLUSTERED 
(
	[GenreId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BookCategory]    Script Date: 02/18/2014 13:51:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BookCategory](
	[CategoryId] [varchar](10) NOT NULL,
	[CategoryName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_BookCategory] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Author]    Script Date: 02/18/2014 13:51:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Author](
	[AuthorId] [varchar](10) NOT NULL,
	[AuthorName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[AuthorId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[webpages_UsersInRoles]    Script Date: 02/18/2014 13:51:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_UsersInRoles](
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 02/18/2014 13:51:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Book](
	[ID] [nchar](10) NOT NULL,
	[Title] [varchar](100) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[AuthorId] [varchar](10) NULL,
	[GenreId] [varchar](10) NULL,
	[CategoryId] [varchar](10) NOT NULL,
	[ISBN] [varchar](20) NOT NULL,
	[ImageUrl] [nvarchar](50) NULL,
	[Price] [money] NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cart]    Script Date: 02/18/2014 13:51:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cart](
	[ItemCode] [nchar](10) NOT NULL,
	[Quantity] [int] NOT NULL,
	[UserId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Default [DF__webpages___IsCon__4AB81AF0]    Script Date: 02/18/2014 13:51:57 ******/
ALTER TABLE [dbo].[webpages_Membership] ADD  DEFAULT ((0)) FOR [IsConfirmed]
GO
/****** Object:  Default [DF__webpages___Passw__4BAC3F29]    Script Date: 02/18/2014 13:51:57 ******/
ALTER TABLE [dbo].[webpages_Membership] ADD  DEFAULT ((0)) FOR [PasswordFailuresSinceLastSuccess]
GO
/****** Object:  Default [DF_Book_Price]    Script Date: 02/18/2014 13:51:57 ******/
ALTER TABLE [dbo].[Book] ADD  CONSTRAINT [DF_Book_Price]  DEFAULT ((0)) FOR [Price]
GO
/****** Object:  ForeignKey [fk_RoleId]    Script Date: 02/18/2014 13:51:57 ******/
ALTER TABLE [dbo].[webpages_UsersInRoles]  WITH CHECK ADD  CONSTRAINT [fk_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[webpages_Roles] ([RoleId])
GO
ALTER TABLE [dbo].[webpages_UsersInRoles] CHECK CONSTRAINT [fk_RoleId]
GO
/****** Object:  ForeignKey [fk_UserId]    Script Date: 02/18/2014 13:51:57 ******/
ALTER TABLE [dbo].[webpages_UsersInRoles]  WITH CHECK ADD  CONSTRAINT [fk_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[webpages_UsersInRoles] CHECK CONSTRAINT [fk_UserId]
GO
/****** Object:  ForeignKey [FK_Book_Author]    Script Date: 02/18/2014 13:51:57 ******/
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Author] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[Author] ([AuthorId])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Author]
GO
/****** Object:  ForeignKey [FK_Book_BookCategory]    Script Date: 02/18/2014 13:51:57 ******/
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_BookCategory] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[BookCategory] ([CategoryId])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_BookCategory]
GO
/****** Object:  ForeignKey [FK_Book_Genre]    Script Date: 02/18/2014 13:51:57 ******/
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Genre] FOREIGN KEY([GenreId])
REFERENCES [dbo].[Genre] ([GenreId])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Genre]
GO
/****** Object:  ForeignKey [FK_Cart_Book]    Script Date: 02/18/2014 13:51:57 ******/
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD  CONSTRAINT [FK_Cart_Book] FOREIGN KEY([ItemCode])
REFERENCES [dbo].[Book] ([ID])
GO
ALTER TABLE [dbo].[Cart] CHECK CONSTRAINT [FK_Cart_Book]
GO
/****** Object:  ForeignKey [FK_Cart_Users]    Script Date: 02/18/2014 13:51:57 ******/
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD  CONSTRAINT [FK_Cart_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Cart] CHECK CONSTRAINT [FK_Cart_Users]
GO
