using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using WebAPI.Data;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyRevenueController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public CompanyRevenueController(AppDbContext context, IMapper mapper, IMediator mediator)
        {
            _context = context;
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet("{companyCode}")]
        public async Task<ActionResult<CompanyRevenue>> GetRevenue(string companyCode)
        {
            var revenue = await _context.CompanyRevenues
                .FirstOrDefaultAsync(r => r.CompanyCode == companyCode);

            if (revenue == null) return NotFound();

            return Ok(revenue);
        }

        [HttpGet("GetAllCompany")]
        public async Task<ActionResult<IEnumerable<CompanyRevenue>>> GetAll()
        {
            var companyData = await _context.CompanyRevenues.ToListAsync();
            return Ok(companyData);
        }

        [HttpPost("CreateCompany")]
        public async Task<ActionResult<CompanyRevenue>> CreateRevenue(CompanyRevenue revenue)
        {
            _context.CompanyRevenues.Add(revenue);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRevenue), new { companyCode = revenue.CompanyCode }, revenue);
        }

    }
}