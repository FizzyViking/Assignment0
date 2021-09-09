using System;
using System.IO;
using Xunit;

namespace Console.Tests
{
    public class Console_UnitTest
    {
        [Fact]
        public void IsLeapYear()
        {
            // Arrange
            Program program = new Program();

            // Act
            bool result1 = program.IsLeapYear(440);
            bool result2 = program.IsLeapYear(53);
            bool result3 = program.IsLeapYear(1200);
            bool result4 = program.IsLeapYear(1700);

            // Assert
            // Minor error - Should use Assert.True();
            Assert.Equal(true, result1);
            Assert.Equal(false, result2);
            Assert.Equal(true, result3);
            Assert.Equal(false, result4);
        }

        [Fact]
        public void Console_Gets_UserInput() {
            var writer = new StringWriter();
            System.Console.SetOut(writer);
            var input = new StringReader("1600");
            System.Console.SetIn(input);

            Program.Main(new string[0]);

            string actual = writer.ToString().Trim();
            Assert.EndsWith("yay", actual);
        }

        [Fact]
        public void Main_Throws_Error() {
            var writer = new StringWriter();
            System.Console.SetOut(writer);
            var input = new StringReader("Try me");
            System.Console.SetIn(input);

            Program.Main(new string[0]);

            var actual = writer.ToString().Trim();
            Assert.EndsWith("Please enter a number from 1582 and up", actual);
        }
    }
}
