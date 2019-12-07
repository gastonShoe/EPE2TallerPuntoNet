USE [persona2]
GO
/****** Object:  Table [dbo].[persona]    Script Date: 07/12/2019 1:57:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[persona](
	[codigo] [int] NOT NULL,
	[nombre] [nchar](200) NOT NULL,
	[apellidoPaterno] [nchar](200) NOT NULL,
	[apellidoMaterno] [nchar](200) NOT NULL,
	[sexo] [nchar](200) NOT NULL
) ON [PRIMARY]

GO
