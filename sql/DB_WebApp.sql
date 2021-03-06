USE [DBTest]
GO
/****** Object:  Table [dbo].[DBO_TestTable]     Script Date: 3.06.2022 16:41:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DBO_TestTable](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [varchar](16) NOT NULL,
	[Password] [varchar](16) NOT NULL,
	[EMail] [varchar](128) NOT NULL,
	[Name] [varchar](64) NOT NULL,
	[Surname] [varchar](64) NOT NULL,
	[Sex] [nvarchar](1) NOT NULL,
	[Phone] [decimal](9, 0) NOT NULL,
 CONSTRAINT [PK_Test_Table] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
