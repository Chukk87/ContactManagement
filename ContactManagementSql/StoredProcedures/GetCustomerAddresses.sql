CREATE PROCEDURE GetCustomerAddresses
	@Id UNIQUEIDENTIFIER
AS
BEGIN
    SELECT [FullName]
          ,[Address1]
          ,[Address2]
          ,[Address3]
          ,[Address4]
          ,[Address5]
          ,[PostCode]
          ,[EmailAddress]
    FROM [dbo].[CustomersAddresses]
    WHERE DetailId = @Id
END;