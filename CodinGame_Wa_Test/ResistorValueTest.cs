using CodinGame_WA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_Wa_Test
{
    public class ResistorValueTest
    {
        [Fact]
        public void ShouldDisplay200()
        {
            // Arange
            ResistorValue compute = new();
            var input = "Red Black Brown";


            // Act
            var colorResult = compute.Main(input);

            //Assert
            Assert.Equal(200, colorResult);
        }

        [Fact]
        public void ShouldDisplay100()
        {
            // Arange
            ResistorValue compute = new();
            var input = "Brown Black Brown";


            // Act
            var colorResult = compute.Main(input);

            //Assert
            Assert.Equal(100, colorResult);
        }

        [Fact]
        public void ShouldDisplay350()
        {
            // Arange
            ResistorValue compute = new();
            var input = "Orange Green Brown";


            // Act
            var colorResult = compute.Main(input);

            //Assert
            Assert.Equal(350, colorResult);
        }

        [Fact]
        public void ShouldDisplay4600()
        {
            // Arange
            ResistorValue compute = new();
            var input = "Yellow Blue Red";


            // Act
            var colorResult = compute.Main(input);

            //Assert
            Assert.Equal(4600, colorResult);
        }

        [Fact]
        public void ShouldDisplay78000000000()
        {
            // Arange
            ResistorValue compute = new();
            var input = "Purple Grey White";


            // Act
            var colorResult = compute.Main(input);

            //Assert
            Assert.Equal(78000000000, colorResult);
        }
    }
}

// test
//Red Black Brown => 200
//    Brown Black Brown => 100
//    Orange Green Brown => 350
//Yellow Blue Red => 4600
//    Purple Grey White => 78000000000