using Microsoft.AspNetCore.Mvc;
using RomanNumeralConverter.Models;
using RomanNumeralConverter.Interfaces;

namespace RomanNumeralConverter.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHistoryLogService _history;
        private object _logsServices;

        public HomeController(IHistoryLogService history)
            {
                _history = history;
            }
            public IActionResult About()
            {
                return View();
            }

            public IActionResult Index()
            {
                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Index(HistoryLog log)
            {
                if (log.Input is > 0 and < 4000)
                {
                    _history.AddLog(log);
                    TempData["converted"] = $"Number {log.Input} in Roman numerals is {log.Output}";
                }
                return View();
            }

            public IActionResult History()
            {
                IEnumerable<HistoryLog> history = _history.GetAll();
                return View(history.Reverse());
            }
    }
}