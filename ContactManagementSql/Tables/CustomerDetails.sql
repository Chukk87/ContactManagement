CREATE TABLE [dbo].[CustomerDetails]
(
	[Id] UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
	[ReferenceId] NVARCHAR(20) NULL,
	[CompanyName] NVARCHAR(160) NULL,
    [BusinessAccount] BIT NOT NULL,
    [BusinessEmail] NVARCHAR(160) NULL
)