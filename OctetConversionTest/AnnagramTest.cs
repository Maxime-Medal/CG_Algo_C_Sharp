using CodinGame_Wa;
using CodinGame_WA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_Wa_Test
{
    public class AnnagramTest
    {
        const string PATH = @"C:\Users\Eltanin\Projects\Learn\CodingGame_C_Sharp\OctetConversionTest\Anagramm_Input";

        [Fact]
        public void Test1()
        {
            // Arrange
            var pathOut = $"{PATH}/Test_1_output.txt";
            var resultTextData = File.ReadAllLines(pathOut)[0] == "true";
            Annagram compute = new();

            // Act
            var pathIn = $"{PATH}/Test_1_input.txt";
            var test = File.ReadAllLines(pathIn);

            var testedValue = compute.IsAnagram(test[0], test[1]);

            // Assert
            Assert.Equal(testedValue, resultTextData);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            var pathOut = $"{PATH}/Test_2_output.txt";
            var resultTextData = File.ReadAllLines(pathOut)[0] == "true";
            Annagram compute = new();

            // Act
            var pathIn = $"{PATH}/Test_2_input.txt";
            var test = File.ReadAllLines(pathIn);

            var testedValue = compute.IsAnagram(test[0], test[1]);

            // Assert
            Assert.Equal(testedValue, resultTextData);
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            var pathOut = $"{PATH}/Test_3_output.txt";
            var resultTextData = File.ReadAllLines(pathOut)[0] == "true";
            Annagram compute = new();

            // Act
            var pathIn = $"{PATH}/Test_3_input.txt";
            var test = File.ReadAllLines(pathIn);

            var testedValue = compute.IsAnagram(test[0], test[1]);

            // Assert
            Assert.Equal(testedValue, resultTextData);
        }

        [Fact]
        public void Test4()
        {
            // Arrange
            var pathOut = $"{PATH}/Test_5_output.txt";
            var resultTextData = File.ReadAllLines(pathOut)[0] == "true";
            Annagram compute = new();

            // Act
            var pathIn = $"{PATH}/Test_5_input.txt";
            var test = File.ReadAllLines(pathIn);

            var testedValue = compute.IsAnagram(test[0], test[1]);

            // Assert
            Assert.Equal(testedValue, resultTextData);
        }

        [Fact]
        public void Test5()
        {
            // Arrange
            var pathOut = $"{PATH}/Test_9_output.txt";
            var resultTextData = File.ReadAllLines(pathOut)[0] == "true";
            Annagram compute = new();

            // Act
            var pathIn = $"{PATH}/Test_9_input.txt";
            var test = File.ReadAllLines(pathIn);

            var testedValue = compute.IsAnagram(test[0], test[1]);

            // Assert
            Assert.Equal(testedValue, resultTextData);
        }

    }
}
