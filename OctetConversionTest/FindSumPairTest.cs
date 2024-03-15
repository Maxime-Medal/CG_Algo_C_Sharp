using CodinGame_Wa;
using CodinGame_WA;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame_Wa_Test
{
    public class FindSumPairTest
    {
        const string MYPATH = "C:/Users/Eltanin/Projects/Learn/CodingGame_C_Sharp/OctetConversionTest/FindSumPair_Input";
        internal List<int> StringsToInts(string[] strings)
        {
            List<int> nums = new ();
            foreach (var item in strings)
            {
                int n;
                int.TryParse(item, out n);
                nums.Add(n);
            }
            return nums;
        }

        [Fact]
        public void ShouldDisplayWithValuesInFile1()
        {

            // Arrange

            // Out
            var pathOut = $"{MYPATH}/Test_1_output.txt";
            var resultTextData = File.ReadAllLines(pathOut);
            var resultInArrayOfString = resultTextData[0][1..^1].Split(',');
            var outResult = StringsToInts(resultInArrayOfString);

            // In
            var pathIn = $"{MYPATH}/Test_1_input.txt";
            var dataIn = File.ReadAllLines(pathIn);
            var strings = dataIn[0][1..^1].Split(',');
            List<int> nums = StringsToInts(strings);

            // Target
            int target;
            int.TryParse(dataIn[1], out target);

            // Act
            FindSumPair computer = new();
            var testedValue = computer.FindPair(nums, target);

            // Assert
            Assert.Equal(outResult, testedValue);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        public void ShouldDisplayWithValuesInFile(int test)
        {

            // Arrange

            // Out
            var pathOut = $"{MYPATH}/Test_{test}_output.txt";
            var resultTextData = File.ReadAllLines(pathOut);
            var resultInArrayOfString = resultTextData[0][1..^1].Split(',');
            var outResult = StringsToInts(resultInArrayOfString);

            // In
            var pathIn = $"{MYPATH}/Test_{test}_input.txt";
            var dataIn = File.ReadAllLines(pathIn);
            var strings = dataIn[0][1..^1].Split(',');
            List<int> nums = StringsToInts(strings);

            // Target
            int target;
            int.TryParse(dataIn[1], out target);

            // Act
            FindSumPair computer = new();
            var testedValue = computer.FindPair(nums, target);

            // Assert
            Assert.Equal(outResult, testedValue);
        }


    }
}
