using FluentAssertions;
using RomanNumeralConverter.Models;

namespace RomanNumeralTests
{
    [TestClass]
    public class GeneratorTests
    {
        private Generator _generator;

        [TestInitialize]
        public void Setup()
        {
            _generator = new Generator();
        }

        [TestMethod]
        public void Generate_ProvideValidInput_ReturnsResult()
        {
            var output1 = _generator.Generate(1);
            var output4 = _generator.Generate(4);
            var output5 = _generator.Generate(5);
            var output9 = _generator.Generate(9);
            var output10 = _generator.Generate(10);
            var output40 = _generator.Generate(40);
            var output50 = _generator.Generate(50);
            var output90 = _generator.Generate(90);
            var output100 = _generator.Generate(100);
            var output400 = _generator.Generate(400);
            var output500 = _generator.Generate(500);
            var output900 = _generator.Generate(900);
            var output1000 = _generator.Generate(1000);

            output1.Should().Be("I");
            output4.Should().Be("IV");
            output5.Should().Be("V");
            output9.Should().Be("IX");
            output10.Should().Be("X");
            output40.Should().Be("XL");
            output50.Should().Be("L");
            output90.Should().Be("XC");
            output100.Should().Be("C");
            output400.Should().Be("CD");
            output500.Should().Be("D");
            output900.Should().Be("CM");
            output1000.Should().Be("M");
        }
        [TestMethod]
        public void Generate_ProvideValidInputRandom_ReturnsResult()
        {
            var output1 = _generator.Generate(11);
            var output4 = _generator.Generate(42);
            var output9 = _generator.Generate(99);
            var output176 = _generator.Generate(176);
            var output828 = _generator.Generate(828);
            var output3888 = _generator.Generate(3888);

            output1.Should().Be("XI");
            output4.Should().Be("XLII");
            output9.Should().Be("XCIX");
            output176.Should().Be("CLXXVI");
            output828.Should().Be("DCCCXXVIII");
            output3888.Should().Be("MMMDCCCLXXXVIII");
        }
        [TestMethod]
        public void Generate_ProvideInvalidInput_ReturnsResult()
        {
            var negative = _generator.Generate(-3);
            var zero = _generator.Generate(0);
            var big = _generator.Generate(4999);

            negative.Should().Be("Invalid value entered, must be a number between 1 and 3999");
            zero.Should().Be("Invalid value entered, must be a number between 1 and 3999");
            big.Should().Be("Invalid value entered, must be a number between 1 and 3999");
        }
    }
}