using CodinGame_Wa;
using CodinGame_WA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_Wa_Test
{
    public class RangeSumTest
    {
        int[] ARRAY = { 0, 1, 2, 3, 4, 5, 3 };

        [Fact]
        public void shouldReturn1()
        {
            // Arrange
            RangeSum range = new();

            // Act
            int value = range.Calc(ARRAY, 0, 1);

            // Assert
            Assert.Equal(1, value);
        }

        [Fact]
        public void shouldReturn15()
        {
            // Arrange
            RangeSum range = new();

            // Act
            int value = range.Calc(ARRAY, 0, 5);

            // Assert
            Assert.Equal(15, value);
        }

        [Fact]
        public void shouldReturn0()
        {
            // Arrange
            RangeSum range = new();

            // Act
            int value = range.Calc(ARRAY, 0, 0);

            // Assert
            Assert.Equal(0, value);
        }

        [Fact]
        public void shouldReturn18()
        {
            // Arrange
            RangeSum range = new();

            // Act
            int value = range.Calc(ARRAY, 0, 6);

            // Assert
            Assert.Equal(18, value);
        }
    }
}
