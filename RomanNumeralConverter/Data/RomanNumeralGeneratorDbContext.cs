using Microsoft.EntityFrameworkCore;
using RomanNumeralConverter.Models;

namespace RomanNumeralConverter.Data
{
    public class RomanNumeralGeneratorDbContext : DbContext, IRomanNumeralGeneratorDbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<HistoryLog> History { get; set; }

        public RomanNumeralGeneratorDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_configuration.GetConnectionString("roman-numerals"));
        }
    }
}
