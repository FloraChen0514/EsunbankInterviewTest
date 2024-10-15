using CsvHelper;
using System.Globalization;
using WebAPI.Models;
using System.Formats.Asn1;
using System;
using WebAPI.Data;

namespace WebAPI.Services
{
        public class CsvDataService
        {
            private readonly AppDbContext _context;

            public CsvDataService(AppDbContext context)
            {
                _context = context;

            }

            public async Task ImportCsvData(string filePath)
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<CompanyRevenue>().ToList();
                    await _context.CompanyRevenues.AddRangeAsync(records);
                    await _context.SaveChangesAsync();
                }
            }
        }

}
