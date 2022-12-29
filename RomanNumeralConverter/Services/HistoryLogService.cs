using System.Globalization;
using RomanNumeralConverter.Data;
using RomanNumeralConverter.Interfaces;
using RomanNumeralConverter.Models;

namespace RomanNumeralConverter.Services
{
    public class LogHistoryService : EntityService<HistoryLog>, IHistoryLogService
    {
        private readonly IRomanNumeralGenerator _generator;

        public LogHistoryService(IRomanNumeralGeneratorDbContext context, IRomanNumeralGenerator generator) : base(context)
        {
            _generator = generator;
        }

        public HistoryLog AddLog(HistoryLog log)
        {
            log.Time = DateTime.Now.ToString(CultureInfo.InvariantCulture);
            log.Output = _generator.Generate(log.Input);
            Create(log);

            return log;
        }
    }
}
