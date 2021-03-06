CREATE TABLE [dbo].[Applications](
	[ApplicationID] [uniqueidentifier] NOT NULL,
	[Name] [varchar](256) NOT NULL,
	[Version] [varchar](256) NOT NULL,
	[URL] [varchar](256) NULL,
 CONSTRAINT [PK_Applications] PRIMARY KEY CLUSTERED 
(
	[ApplicationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)

GO
ALTER TABLE [dbo].[Applications] ADD  CONSTRAINT [DF__Applicati__Versi__00551192]  DEFAULT ('0.0.0.0') FOR [Version]
GO
