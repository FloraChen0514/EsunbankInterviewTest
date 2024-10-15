using MediatR;

namespace WebAPI.Commands
{
    public class CreateCompanyRevenueCommand : IRequest
    {
        public string CompanyCode { get; set; }
        public decimal MonthlyRevenue { get; set; }
        public string DataYearMonth { get; set; }
    }

}
