using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RomanNumeralConverter.Models;

namespace RomanNumeralConverter.Data
{
    public interface IRomanNumeralGeneratorDbContext
    {
        DbSet<T> Set<T>() where T : class;
        EntityEntry<T> Entry<T>(T entity) where T : class;
        DbSet<HistoryLog> History { get; set; }
        int SaveChanges();
    }
}