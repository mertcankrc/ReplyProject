USE [mertcanDb]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 24.11.2021 20:42:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Model] [varchar](100) NULL,
	[Engine] [varchar](100) NULL,
	[Infotainment] [varchar](100) NULL,
	[Design] [varchar](100) NULL,
	[Coordination] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Demands]    Script Date: 24.11.2021 20:42:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Demands](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CheckOutPlace] [int] NULL,
	[CheckOutTime] [datetime] NULL,
	[CheckInPlace] [int] NULL,
	[CheckInTime] [datetime] NULL,
	[DesiredModel] [varchar](100) NULL,
	[DesiredEngine] [varchar](100) NULL,
	[DesiredInfotainmentSystem] [varchar](100) NULL,
	[DesiredDesign] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 24.11.2021 20:42:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Gender] [varchar](10) NULL,
	[Age] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([Id], [Model], [Engine], [Infotainment], [Design], [Coordination]) VALUES (1, N'test', N'string', N'string', N'string', 0)
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[Demands] ON 

INSERT [dbo].[Demands] ([Id], [CheckOutPlace], [CheckOutTime], [CheckInPlace], [CheckInTime], [DesiredModel], [DesiredEngine], [DesiredInfotainmentSystem], [DesiredDesign]) VALUES (1, 1231, CAST(N'2021-12-10T00:00:00.000' AS DateTime), 4, CAST(N'2021-12-10T00:00:00.000' AS DateTime), N'asd', N'ads', N'dasfsa', N'asdasdasd')
SET IDENTITY_INSERT [dbo].[Demands] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Name], [Gender], [Age]) VALUES (1, N'string', N'string', 0)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT ('') FOR [Model]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT ('') FOR [Engine]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT ('') FOR [Infotainment]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT ('') FOR [Design]
GO
ALTER TABLE [dbo].[Cars] ADD  DEFAULT ((0)) FOR [Coordination]
GO
ALTER TABLE [dbo].[Demands] ADD  CONSTRAINT [DF__Demands__CheckOu__6B24EA82]  DEFAULT ((0)) FOR [CheckOutPlace]
GO
ALTER TABLE [dbo].[Demands] ADD  CONSTRAINT [DF__Demands__CheckIn__6C190EBB]  DEFAULT ((0)) FOR [CheckInPlace]
GO
ALTER TABLE [dbo].[Demands] ADD  CONSTRAINT [DF__Demands__Desired__6D0D32F4]  DEFAULT ((0)) FOR [DesiredModel]
GO
ALTER TABLE [dbo].[Demands] ADD  CONSTRAINT [DF__Demands__Desired__6E01572D]  DEFAULT ((0)) FOR [DesiredEngine]
GO
ALTER TABLE [dbo].[Demands] ADD  CONSTRAINT [DF__Demands__Desired__6EF57B66]  DEFAULT ((0)) FOR [DesiredInfotainmentSystem]
GO
ALTER TABLE [dbo].[Demands] ADD  CONSTRAINT [DF__Demands__Desired__6FE99F9F]  DEFAULT ((0)) FOR [DesiredDesign]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF__Users__Name__4AB81AF0]  DEFAULT ('') FOR [Name]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF__Users__Gender__4BAC3F29]  DEFAULT ('') FOR [Gender]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF__Users__Age__4CA06362]  DEFAULT ((0)) FOR [Age]
GO
