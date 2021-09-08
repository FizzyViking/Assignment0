using System;
using Xunit;

namespace Console.Tests
{
    public class UnitTest1
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
            Assert.Equal(true, result1);
            Assert.Equal(false, result2);
            Assert.Equal(true, result3);
            Assert.Equal(false, result4);
        }
    }
}
