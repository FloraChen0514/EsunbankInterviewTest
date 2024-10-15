using MediatR;
using WebAPI.Models;

namespace WebAPI.Queries
{
    public class GetCompanyRevenueQuery : IRequest<CompanyRevenue>
    {
        public string CompanyCode { get; }

        public GetCompanyRevenueQuery(string companyCode)
        {
            CompanyCode = companyCode;
        }
    }

}
