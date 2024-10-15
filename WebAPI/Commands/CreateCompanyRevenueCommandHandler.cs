using MediatR;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Commands
{
    public class CreateCompanyRevenueCommandHandler : IRequestHandler<CreateCompanyRevenueCommand>
    {
        private readonly AppDbContext _context;

        public CreateCompanyRevenueCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateCompanyRevenueCommand request, CancellationToken cancellationToken)
        {
            var revenue = new CompanyRevenue
            {
                CompanyCode = request.CompanyCode,
                MonthlyRevenue = request.MonthlyRevenue,
                DataYearMonth = request.DataYearMonth
            };

            _context.CompanyRevenues.Add(revenue);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }

        Task IRequestHandler<CreateCompanyRevenueCommand>.Handle(CreateCompanyRevenueCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
