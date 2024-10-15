using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class CompanyRevenue
    {
        [Key]
        public int Id { get; set; }
        public string? ReportDate { get; set; } // 出表日期
        public string? DataYearMonth { get; set; } // 資料年月
        
        public string CompanyCode { get; set; } // 公司代號
        public string? CompanyName { get; set; } // 公司名稱
        public string? IndustryType { get; set; } // 產業別
        public decimal? MonthlyRevenue { get; set; } // 營業收入-當月營收
        public decimal? LastMonthRevenue { get; set; } // 營業收入-上月營收
        public decimal? LastYearSameMonthRevenue { get; set; } // 營業收入-去年當月營收
        public decimal? LastMonthComparison { get; set; } // 營業收入-上月比較增減(%)
        public decimal? LastYearComparison { get; set; } // 營業收入-去年同月增減(%)
        public decimal? CumulativeRevenue { get; set; } // 累計營業收入-當月累計營收
        public decimal? LastYearCumulativeRevenue { get; set; } // 累計營業收入-去年累計營收
        public decimal? LastPeriodComparison { get; set; } // 累計營業收入-前期比較增減(%)
        public string? Remark { get; set; }
    }

}
