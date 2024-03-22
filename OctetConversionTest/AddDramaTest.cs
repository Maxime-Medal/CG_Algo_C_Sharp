using CodinGame_WA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_Wa_Test
{
    public class AddDramaTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            AddDrama addDrama = new();
            var StringTest = "Roses are red. Oranges are orange! Yeah!!!";
            var waitingResult = "Roses are red! Oranges are orange!! Yeah!!!!";


            // Act
            var value = addDrama.AddDramaChar(StringTest);

            // Assert
            Assert.Equal(waitingResult, value);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            AddDrama addDrama = new();
            var StringTest = "We want a shrubbery ! !!! !! ! (Monthy Python)";
            var waitingResult = "We want a shrubbery !! !!!! !!! !! (Monthy Python)";


            // Act
            var value = addDrama.AddDramaChar(StringTest);

            // Assert
            Assert.Equal(waitingResult, value);
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            AddDrama addDrama = new();
            var StringTest = "... both what we mean to do, and what s untimely done (Hamlet) ...";
            var waitingResult = "!!! both what we mean to do, and what s untimely done (Hamlet) !!!";


            // Act
            var value = addDrama.AddDramaChar(StringTest);

            // Assert
            Assert.Equal(waitingResult, value);
        }

        [Fact]
        public void Test4()
        {
            // Arrange
            AddDrama addDrama = new();
            var StringTest = "Yipi-kaii **#]/(-+?*%%*";
            var waitingResult = "Yipi-kaii **#]/(-+?*%%*";


            // Act
            var value = addDrama.AddDramaChar(StringTest);

            // Assert
            Assert.Equal(waitingResult, value);
        }

        [Fact]
        public void Test5Empty()
        {
            // Arrange
            AddDrama addDrama = new();
            var StringTest = "";
            var waitingResult = "";


            // Act
            var value = addDrama.AddDramaChar(StringTest);

            // Assert
            Assert.Equal(waitingResult, value);
        }

        [Fact]
        public void Test6()
        {
            // Arrange
            AddDrama addDrama = new();
            var StringTest = "!";
            var waitingResult = "!!";


            // Act
            var value = addDrama.AddDramaChar(StringTest);

            // Assert
            Assert.Equal(waitingResult, value);
        }

        [Fact]
        public void Test7()
        {
            // Arrange
            AddDrama addDrama = new();
            var StringTest = "!!.!.!...!!!!";
            var waitingResult = "!!!!!!!!!!!!!!!!!";


            // Act
            var value = addDrama.AddDramaChar(StringTest);

            // Assert
            Assert.Equal(waitingResult, value);
        }

    }
}