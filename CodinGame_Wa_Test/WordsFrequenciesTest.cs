using CodinGame_WA;

namespace CodinGame_Wa_Test
{
    public class WordsFrequenciesTest
    {
        const string MYPATH = "C:/Projects/My_Projects/CodingGame_C_Sharp/CodinGame_WA_Test/WordsFrenquencies_Input";
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
        public void Test1()
        {

            //Arrange
            // Out
            int[] dataOut = [1, 1, 1, 2];

            // In
            string[] dataIn = ["the", "dog", "got", "the", "bone"];

            // Target
            int[] target;

            // Act
            WordsFrequencies computer = new();
            var testedValue = computer.CountFrequencies(dataIn);

            // Assert
            Assert.Equal(dataOut, testedValue);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void ShouldDisplayWithValuesInFiles(int test)
        {
            // Arrange

            // Out
            var pathOut = $"{MYPATH}/Test_{test}_output.txt";
            var resultTextData = File.ReadAllLines(pathOut);
            var resInInt = StringsToInts(resultTextData);

            // In
            var pathIn = $"{MYPATH}/Test_{test}_input.txt";
            var dataIn = File.ReadAllLines(pathIn);
            var strings = dataIn.Skip(2).ToArray();

            // Act
            WordsFrequencies computer = new();
            var testedValue = computer.CountFrequencies(strings);

            // Assert
            Assert.Equal(resInInt, testedValue);
        }
    }
}
