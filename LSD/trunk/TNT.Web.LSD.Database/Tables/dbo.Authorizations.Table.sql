CREATE TABLE [dbo].[Authorizations](
	[AuthorizationKey] [varchar](256) NOT NULL,
	[LicenseKey] [varchar](256) NOT NULL,
	[HardwareID] [varchar](256) NOT NULL,
	[AuthorizedOn] [datetime] NOT NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Authorizations]  WITH CHECK ADD  CONSTRAINT [FK_Authorizations_Licenses] FOREIGN KEY([LicenseKey])
REFERENCES [dbo].[Licenses] ([LicenseKey])
GO
ALTER TABLE [dbo].[Authorizations] CHECK CONSTRAINT [FK_Authorizations_Licenses]
GO
