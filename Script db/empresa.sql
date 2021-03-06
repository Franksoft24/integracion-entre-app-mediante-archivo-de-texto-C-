USE [Empresa]
GO
/****** Object:  Table [dbo].[Nomina]    Script Date: 5/22/2015 2:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Nomina](
	[Cedula] [varchar](11) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Cuenta] [varchar](16) NOT NULL,
	[Monto] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Nomina] PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Nomina] ([Cedula], [Nombre], [Cuenta], [Monto]) VALUES (N'00115162678', N'Radhames', N'4879296154', CAST(120000.00 AS Decimal(18, 2)))
INSERT [dbo].[Nomina] ([Cedula], [Nombre], [Cuenta], [Monto]) VALUES (N'00115643155', N'Gerard', N'7849562346', CAST(100000.00 AS Decimal(18, 2)))
INSERT [dbo].[Nomina] ([Cedula], [Nombre], [Cuenta], [Monto]) VALUES (N'01215478795', N'Yaneris', N'7879541667', CAST(130000.00 AS Decimal(18, 2)))
INSERT [dbo].[Nomina] ([Cedula], [Nombre], [Cuenta], [Monto]) VALUES (N'40294784561', N'Frankmer', N'4581846262', CAST(150000.00 AS Decimal(18, 2)))
