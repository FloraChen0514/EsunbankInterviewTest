CREATE PROCEDURE [dbo].[InsertCompanyRevenue]
    @ReportDate VARCHAR(10),
    @DataYearMonth VARCHAR(6),
    @CompanyCode VARCHAR(10),
    @CompanyName NVARCHAR(100),
    @IndustryType NVARCHAR(50),
    @MonthlyRevenue DECIMAL(18, 2),
    @LastMonthRevenue DECIMAL(18, 2),
    @LastYearSameMonthRevenue DECIMAL(18, 2),
    @LastMonthComparison DECIMAL(5, 2),
    @LastYearComparison DECIMAL(5, 2),
    @CumulativeRevenue DECIMAL(18, 2),
    @LastYearCumulativeRevenue DECIMAL(18, 2),
    @LastPeriodComparison DECIMAL(5, 2),
    @REMARK NVARCHAR(500)
AS
BEGIN
    INSERT INTO CompanyRevenue (ReportDate, DataYearMonth, CompanyCode, CompanyName, IndustryType, 
                                 MonthlyRevenue, LastMonthRevenue, LastYearSameMonthRevenue, 
                                 LastMonthComparison, LastYearComparison, CumulativeRevenue, 
                                 LastYearCumulativeRevenue, LastPeriodComparison)
    VALUES (@ReportDate, @DataYearMonth, @CompanyCode, @CompanyName, @IndustryType, 
            @MonthlyRevenue, @LastMonthRevenue, @LastYearSameMonthRevenue, 
            @LastMonthComparison, @LastYearComparison, @CumulativeRevenue, 
            @LastYearCumulativeRevenue, @LastPeriodComparison);
END
