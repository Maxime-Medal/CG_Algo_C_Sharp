using CodinGame_Wa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

const string PATH = @"C:\Projects\My_Projects\CodingGame_C_Sharp\OctetConversionTest\FindSumPair_Input";
namespace CodinGame_Wa_Test
{
    public class FindSumPairTest
    {
        [Fact]
        public void ShouldDisplayWithValuesInFile2()
        {
            //var currentDirectory = Directory.GetCurrentDirectory();
            //var testDirectory = Path.Combine(currentDirectory, "test");
            var pathOut = $"{this.} "; //TODO mettre en place le chemin

            // Arrange
            var resultTextData = File.ReadAllText(pathOut).Trim('\"');
            ComputeBytes computer = new();

            // Act
            var pathIn = @"C:\Projects\My_Projects\CodingGame_C_Sharp\OctetConversionTest\octet_Test\Test_2_input.txt";
            int test;
            int.TryParse(File.ReadAllText(pathIn), out test);
            var testedValue = computer.Compute(test);

            // Assert
            Assert.Equal(testedValue, resultTextData);
        }


    }
}
