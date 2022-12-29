using System.ComponentModel.DataAnnotations;

namespace RomanNumeralConverter.Models
{
    public class HistoryLog : Entity
    {
            [Display(Name = "Number to Convert")]
            [Range(1, 3999)]
            public int Input { get; set; }

            [Display(Name = "Roman Numeral")]   
            public string Output { get; set; }
            public string Time { get; set; }
    }
}