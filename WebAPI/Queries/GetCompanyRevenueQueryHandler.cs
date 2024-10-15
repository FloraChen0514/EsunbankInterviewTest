using MediatR;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Queries
{
    public class GetCompanyRevenueQueryHandler : IRequestHandler<GetCompanyRevenueQuery, CompanyRevenue>
    {
        private readonly AppDbContext _context;

        public GetCompanyRevenueQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<CompanyRevenue> Handle(GetCompanyRevenueQuery request, CancellationToken cancellationToken)
        {
            return await _context.CompanyRevenues
                .FirstOrDefaultAsync(r => r.CompanyCode == request.CompanyCode, cancellationToken);
        }
    }
}
