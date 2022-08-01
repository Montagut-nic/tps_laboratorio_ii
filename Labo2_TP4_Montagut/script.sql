CREATE DATABASE [CLIENTES_DB]
GO
USE [CLIENTES_DB]
GO
/****** Object:  Table [dbo].[Clientes_Data]    Script Date: 31/7/2022 21:57:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes_Data](
	[ID] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Email] [varchar](50) NULL,
	[activo] [bit] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (1, N'Saraann', N'Adolf', N'sadolf0@webeden.co.uk', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (2, N'Maurice', N'Jarret', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (3, N'Merla', N'Trussler', N'mtrussler2@mail.ru', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (4, N'Lucho', N'Greeve', N'lgreeve3@tmall.com', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (5, N'Nicko', N'Pawlick', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (6, N'Merill', N'Ciciura', N'mciciura5@wikimedia.org', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (7, N'Saunderson', N'Brandel', N'sbrandel6@usatoday.com', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (8, N'Janeczka', N'Ceaser', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (9, N'Dani', N'Stallan', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (10, N'Dolores', N'Duckitt', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (11, N'Suzy', N'Mennell', N'smennella@networksolutions.com', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (12, N'Mirelle', N'Assender', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (13, N'Verene', N'Lakeland', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (14, N'Wallie', N'Kurdani', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (15, N'Quinn', N'Bunker', N'qbunkere@hubpages.com', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (16, N'Marlena', N'Plett', N'mplettf@jigsy.com', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (17, N'Sutherlan', N'Tongs', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (18, N'Guss', N'Broadway', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (19, N'Ethan', N'Dowell', N'edowelli@is.gd', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (20, N'Octavia', N'Ince', N'oincej@squidoo.com', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (21, N'Terencio', N'Ardern', N'tardernk@goo.gl', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (22, N'Andrea', N'Nelligan', N'anelliganl@lulu.com', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (23, N'Sergei', N'Byway', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (24, N'Kiersten', N'Strase', N'kstrasen@pcworld.com', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (25, N'Gui', N'Dyshart', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (26, N'Deana', N'Diegan', N'ddieganp@blogger.com', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (27, N'Flossie', N'Saturley', N'fsaturleyq@bbb.org', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (28, N'Candie', N'Martinello', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (29, N'Dex', N'Jenoure', N'djenoures@biblegateway.com', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (30, N'Kimball', N'Emerine', N'kemerinet@theatlantic.com', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (31, N'Lynea', N'Pargetter', N'lpargetteru@cpanel.net', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (32, N'Melvin', N'Aitcheson', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (33, N'Walton', N'Moncreiff', N'wmoncreiffw@amazon.de', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (34, N'Sheri', N'Eller', N'sellerx@theglobeandmail.com', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (35, N'Ameline', N'Bails', N'abailsy@phpbb.com', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (36, N'Hayes', N'Lindner', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (37, N'Hymie', N'Negro', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (38, N'Carlee', N'McIlenna', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (39, N'Virgilio', N'McGahern', N'vmcgahern12@unc.edu', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (40, N'Zebedee', N'Cathcart', N'zcathcart13@list-manage.com', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (41, N'Deny', N'Kubiczek', N'dkubiczek14@nasa.gov', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (42, N'Caralie', N'Rabbitt', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (43, N'Gilles', N'Wenman', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (44, N'Luce', N'Hugenin', N'lhugenin17@google.com', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (45, N'Devonne', N'Broyd', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (46, N'Danella', N'Rodson', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (47, N'Domenic', N'Harwick', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (48, N'Raine', N'Bartolomieu', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (49, N'Kristi', N'Pickthorne', N'kpickthorne1c@mozilla.com', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (50, N'Burk', N'Hutchins', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (51, N'Shirley', N'Maplethorp', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (52, N'Jaquenette', N'Iacomini', N'jiacomini1f@weather.com', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (53, N'Hinze', N'Colomb', N'hcolomb1g@accuweather.com', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (54, N'Issiah', N'Simnor', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (55, N'Carmel', N'Ysson', N'cysson1i@github.io', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (56, N'Alvy', N'Rodders', N'arodders1j@dedecms.com', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (57, N'Shawn', N'Seegar', N'sseegar1k@merriam-webster.com', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (58, N'Dale', N'Hamlington', N'dhamlington1l@stumbleupon.com', 1)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (59, N'Nani', N'Blanchette', NULL, 0)
GO
INSERT [dbo].[Clientes_Data] ([ID], [Nombre], [Apellido], [Email], [activo]) VALUES (60, N'Walker', N'Selesnick', N'wselesnick1n@senate.gov', 1)
GO
/****** Object:  Index [ID_Clientes_Data]    Script Date: 31/7/2022 21:57:09 ******/
ALTER TABLE [dbo].[Clientes_Data] ADD  CONSTRAINT [ID_Clientes_Data] UNIQUE NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
