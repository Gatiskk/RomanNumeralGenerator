using System.Text;
using RomanNumeralConverter.Interfaces;

namespace RomanNumeralConverter.Models
{
    public class Generator : IRomanNumeralGenerator
    {
        Dictionary<int, string> RomanNumeralsDictionary = new Dictionary<int, string>()
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 90, "XC" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" },
            };

            public string Generate(int number)
            {
                if (number <= 0 || number > 3999)
                    return "Invalid value entered, must be a number between 1 and 3999";

                var romanNumerals = new StringBuilder();

                foreach (var item in RomanNumeralsDictionary)
                {
                    while (number >= item.Key)
                    {
                        romanNumerals.Append(item.Value);
                        number -= item.Key;
                    }
                }
                return romanNumerals.ToString();
            }

        }
    }