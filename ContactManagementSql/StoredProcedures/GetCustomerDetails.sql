CREATE PROCEDURE GetCustomerDetails
	@Id INT
AS
BEGIN
    SELECT [Id] 
          ,[ReferenceId]
          ,[CompanyName]
          ,[BusinessAccount]
          ,[BusinessEmail]
    FROM [dbo].[CustomerDetails]
    WHERE ReferenceId = @Id
END;