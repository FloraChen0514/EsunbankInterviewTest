CREATE TABLE [dbo].[CompanyRevenue]
(
	 Id INT PRIMARY KEY IDENTITY(1,1),
    ReportDate VARCHAR(10) NOT NULL,                     -- 出表日期
    DataYearMonth VARCHAR(6) NOT NULL,           -- 資料年月
    CompanyCode VARCHAR(10) NOT NULL,             -- 公司代號
    CompanyName NVARCHAR(100) NOT NULL,           -- 公司名稱
    IndustryType NVARCHAR(50) NOT NULL,           -- 產業別
    MonthlyRevenue DECIMAL(18, 2) NULL,      -- 營業收入-當月營收
    LastMonthRevenue DECIMAL(18, 2) NULL,    -- 營業收入-上月營收
    LastYearSameMonthRevenue DECIMAL(18, 2) NULL, -- 營業收入-去年當月營收
    LastMonthComparison DECIMAL(5, 2) NULL,  -- 營業收入-上月比較增減(%)
    LastYearComparison DECIMAL(5, 2) NULL,   -- 營業收入-去年同月增減(%)
    CumulativeRevenue DECIMAL(18, 2) NULL,    -- 累計營業收入-當月累計營收
    LastYearCumulativeRevenue DECIMAL(18, 2) NULL, -- 累計營業收入-去年累計營收
    LastPeriodComparison DECIMAL(5, 2) NULL,   -- 累計營業收入-前期比較增減(%), 
    [Remark] NVARCHAR(500) NULL);


GO

CREATE INDEX [IX_CompanyRevenue_IndustryType] ON [dbo].[CompanyRevenue] ([IndustryType])
