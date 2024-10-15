CREATE PROCEDURE [dbo].[GetCompanyRevenue]
    @CompanyCode VARCHAR(10)
AS
BEGIN
    SELECT * FROM CompanyRevenue
    WHERE CompanyCode = @CompanyCode;
END
