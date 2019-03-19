USE [StokTakip]
GO
/****** Object:  Table [dbo].[tblStokTakip]    Script Date: 8.9.2018 16:27:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStokTakip](
	[Adi] [nchar](10) NULL,
	[Grubu] [nchar](10) NULL,
	[MevcutStok] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tblStokTakip] PRIMARY KEY CLUSTERED 
(
	[MevcutStok] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[tblStokTakip] ([Adi], [Grubu], [MevcutStok]) VALUES (N'eren      ', N'eren      ', N'2         ')
INSERT [dbo].[tblStokTakip] ([Adi], [Grubu], [MevcutStok]) VALUES (N'eren      ', N'eren      ', N'3         ')
