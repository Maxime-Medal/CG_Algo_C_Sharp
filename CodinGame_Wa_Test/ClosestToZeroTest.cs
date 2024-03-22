using CodinGame_WA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodinGame_Wa_Test
{
    public class ClosestToZeroTest
    {
        [Fact]
        public void shouldReturn2()
        {
            // Arrange
            ClosestToZero closest = new();
            int[] ints = { -9, 8, 2, -5, 7 };


            // Act
            int value = closest.Compute(ints);

            // Assert
            Assert.Equal(2, value);
        }

        [Fact]
        public void shouldReturn1()
        {
            // Arrange
            ClosestToZero closest = new();
            int[] ints = { 7, 5, 9, 1, 4 };


            // Act
            int value = closest.Compute(ints);

            // Assert
            Assert.Equal(1, value);
        }

        [Fact]
        public void shouldReturn3()
        {
            // Arrange
            ClosestToZero closest = new();
            int[] ints = { -9, 8, 3, -5, 7, -3 };


            // Act
            int value = closest.Compute(ints);

            // Assert
            Assert.Equal(3, value);
        }

        [Fact]
        public void shouldReturn0()
        {
            // Arrange
            ClosestToZero closest = new();
            int[] ints = { };


            // Act
            int value = closest.Compute(ints);

            // Assert
            Assert.Equal(0, value);
        }

        [Fact]
        public void shouldReturn0Bis()
        {
            // Arrange
            ClosestToZero closest = new();
            int[]? ints = null;


            // Act
            int value = closest.Compute(ints);

            // Assert
            Assert.Equal(0, value);
        }

        [Fact]
        public void shouldReturn214()
        {
            // Arrange
            ClosestToZero closest = new();
            int[]? ints = { -2147483647, 2147483647 };


            // Act
            int value = closest.Compute(ints);

            // Assert
            Assert.Equal(2147483647, value);
        }

        [Fact]
        public void shouldReturn4()
        {
            // Arrange
            ClosestToZero closest = new();
            int[]? ints = { -4, -4 };


            // Act
            int value = closest.Compute(ints);

            // Assert
            Assert.Equal(-4, value);
        }

    }
}