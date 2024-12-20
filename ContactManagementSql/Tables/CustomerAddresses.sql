CREATE TABLE [dbo].[CustomersAddresses]
(
	[DetailId] UNIQUEIDENTIFIER NOT NULL,
    [FullName] NVARCHAR(100) NOT NULL,
    [Address1] NVARCHAR(100) NOT NULL,
    [Address2] NVARCHAR(100) NULL,
    [Address3] NVARCHAR(100) NULL,
    [Address4] NVARCHAR(100) NULL,
    [Address5] NVARCHAR(100) NULL,
    [PostCode] NVARCHAR(10) NOT NULL,
    [EmailAddress] NVARCHAR(160) NULL
)