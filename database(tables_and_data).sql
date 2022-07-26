USE [AccountManagerDb]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 26.07.2022 20:50:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[PasswordHash] [varbinary](500) NULL,
	[PasswordSalt] [varbinary](500) NULL,
	[Name] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[LastActivity] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persons]    Script Date: 26.07.2022 20:50:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[AccountId] [int] NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Description] [nvarchar](250) NULL,
	[Phone] [nvarchar](11) NULL,
	[DateOfBirth] [datetime2](7) NULL,
	[DeletedDate] [datetime2](7) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Accounts] ON 

INSERT [dbo].[Accounts] ([Id], [UserName], [PasswordHash], [PasswordSalt], [Name], [Email], [LastActivity], [DeletedDate]) VALUES (1, N'emir', 0xF208DABC5DD4993998AF440CDB1581335CA34CC7CA47E4995E4708B81621FB93, 0x81E9C289B646A06A81A8F8D8D63F7776BF090F300798E2E27BA2ECCA851F3D18259208748C44CE3A7B7B516197AC80764826282E91B4B763CDEC1166EA0D73D3, N'Emir Gürbüz', N'emir@hotmail.com', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Accounts] ([Id], [UserName], [PasswordHash], [PasswordSalt], [Name], [Email], [LastActivity], [DeletedDate]) VALUES (2, N'emir2', 0x0BDDCF043CB3F1C70739DCCB66D3DC2D8F1EF3DABDD4FC6C027E99979383B823, 0x3A1948BCD09157B159F1AA12B0C8D95EBD5AC7F6E9FE1A4D959DA1DA0D6264221308D5CFA122B08472DB7B8D8A44382254994825EB02F80057A14C6AEB3863AD, N'Emir Gürbüz 2', N'emir2@hotmail.com', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL)
SET IDENTITY_INSERT [dbo].[Accounts] OFF
GO
INSERT [dbo].[Persons] ([AccountId], [FirstName], [LastName], [Email], [Description], [Phone], [DateOfBirth], [DeletedDate]) VALUES (1, N'Yasin', N'Uçan', N'yasin@hotmail.com', NULL, N'0000000000', CAST(N'2002-09-04T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Persons] ([AccountId], [FirstName], [LastName], [Email], [Description], [Phone], [DateOfBirth], [DeletedDate]) VALUES (1, N'Enes', N'Muratoğlu', N'enes@hotmail.com', NULL, N'0000000000', CAST(N'2002-08-12T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Persons] ([AccountId], [FirstName], [LastName], [Email], [Description], [Phone], [DateOfBirth], [DeletedDate]) VALUES (2, N'Oğuzhan', N'Gülsün', N'oguzhan@hotmail.com', NULL, N'000', CAST(N'2002-04-18T00:00:00.0000000' AS DateTime2), NULL)
GO
