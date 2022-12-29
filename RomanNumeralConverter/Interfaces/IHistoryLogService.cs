using RomanNumeralConverter.Models;

namespace RomanNumeralConverter.Interfaces
{
    public interface IHistoryLogService : IEntityService<HistoryLog>
    {
        HistoryLog AddLog(HistoryLog log);
    }
}