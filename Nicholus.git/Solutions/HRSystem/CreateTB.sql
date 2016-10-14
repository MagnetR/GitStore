USE [HRSystem]
GO

/****** Object:  Table [dbo].[UserInfo]    Script Date: 2016/07/27 2:04:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[UserInfo](
	[ID_number] [varchar](25) NOT NULL,
	[FirstName] [varchar](25) NULL,
	[SecondName] [varchar](25) NULL,
	[LastName] [varchar](25) NULL,
	[Gender] [char](6) NULL,
	[PhoneNumber] [varchar](10) NULL,
	[Nationality] [varchar](25) NULL,
	[ResidentialAddress] [varchar](100) NULL,
	[EmailAddress] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


