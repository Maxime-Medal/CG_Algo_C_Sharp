using CodinGame_Wa;

namespace CodinGame_Wa_Test
{
    public class OctetConversionUnitTest
    {

        [Fact]
        public void ShouldDisplay488()
        {
            // Arrange
            string result = "488 KiB";
            ComputeBytes computer = new ();

            // Act
            var test = 500000;
            var testedValue = computer.Compute(test);

            // Assert
            Assert.Equal(testedValue, result);
        }

        [Fact]
        public void ShouldDisplayWithValuesInFile2()
        {
        //var currentDirectory = Directory.GetCurrentDirectory();
        //var testDirectory = Path.Combine(currentDirectory, "test");

            // Arrange
            var pathOut = @"C:\Projects\My_Projects\CodingGame_C_Sharp\CodinGame_WA_Test\Octet_Input\Test_2_output.txt";
            var resultTextData = File.ReadAllText(pathOut).Trim('\"');
            ComputeBytes computer = new ();

            // Act
            var pathIn = @"C:\Projects\My_Projects\CodingGame_C_Sharp\CodinGame_WA_Test\Octet_Input\Test_2_input.txt";
            int test;
            int.TryParse(File.ReadAllText(pathIn), out test);
            var testedValue = computer.Compute(test);

            // Assert
            Assert.Equal(testedValue, resultTextData);
        }

        [Fact]
        public void ShouldDisplayWithValuesInFile3()
        {
            // Arrange
            var pathOut = @"C:\Projects\My_Projects\CodingGame_C_Sharp\CodinGame_WA_Test\Octet_Input\Test_3_output.txt";
            var resultTextData = File.ReadAllText(pathOut).Trim('\"');
            ComputeBytes computer = new ();

            // Act
            var pathIn = @"C:\Projects\My_Projects\CodingGame_C_Sharp\CodinGame_WA_Test\Octet_Input\Test_3_input.txt";
            int test;
            int.TryParse(File.ReadAllText(pathIn), out test);
            var testedValue = computer.Compute(test);

            // Assert
            Assert.Equal(testedValue, resultTextData);
        }

        [Fact]
        public void ShouldDisplayWithValuesInFile4()
        {
            // Arrange
            var pathOut = @"C:\Projects\My_Projects\CodingGame_C_Sharp\CodinGame_WA_Test\Octet_Input\Test_4_output.txt";
            var resultTextData = File.ReadAllText(pathOut).Trim('\"');
            ComputeBytes computer = new ();

            // Act
            var pathIn = @"C:\Projects\My_Projects\CodingGame_C_Sharp\CodinGame_WA_Test\Octet_Input\Test_4_input.txt";
            int test;
            int.TryParse(File.ReadAllText(pathIn), out test);
            var testedValue = computer.Compute(test);

            // Assert
            Assert.Equal(testedValue, resultTextData);
        }

        [Fact]
        public void ShouldDisplayWithValuesInFile5()
        {
            // Arrange
            var pathOut = @"C:\Projects\My_Projects\CodingGame_C_Sharp\CodinGame_WA_Test\Octet_Input\Test_5_output.txt";
            var resultTextData = File.ReadAllText(pathOut).Trim('\"');
            ComputeBytes computer = new ();

            // Act
            var pathIn = @"C:\Projects\My_Projects\CodingGame_C_Sharp\CodinGame_WA_Test\Octet_Input\Test_5_input.txt";
            int test;
            int.TryParse(File.ReadAllText(pathIn), out test);
            var testedValue = computer.Compute(test);

            // Assert
            Assert.Equal(testedValue, resultTextData);
        }

        [Fact]
        public void ShouldDisplayWithValuesInFile6()
        {
            // Arrange
            var pathOut = @"C:\Projects\My_Projects\CodingGame_C_Sharp\CodinGame_WA_Test\Octet_Input\Test_6_output.txt";
            var resultTextData = File.ReadAllText(pathOut).Trim('\"');
            ComputeBytes computer = new ();

            // Act
            var pathIn = @"C:\Projects\My_Projects\CodingGame_C_Sharp\CodinGame_WA_Test\Octet_Input\Test_6_input.txt";
            int test;
            int.TryParse(File.ReadAllText(pathIn), out test);
            var testedValue = computer.Compute(test);

            // Assert
            Assert.Equal(testedValue, resultTextData);
        }

        [Fact]
        public void ShouldDisplayWithValuesInFile7()
        {
            // Arrange
            var pathOut = @"C:\Projects\My_Projects\CodingGame_C_Sharp\CodinGame_WA_Test\Octet_Input\Test_7_output.txt";
            var resultTextData = File.ReadAllText(pathOut).Trim('\"');
            ComputeBytes computer = new ();

            // Act
            var pathIn = @"C:\Projects\My_Projects\CodingGame_C_Sharp\CodinGame_WA_Test\Octet_Input\Test_7_input.txt";
            int test;
            int.TryParse(File.ReadAllText(pathIn), out test);
            var testedValue = computer.Compute(test);

            // Assert
            Assert.Equal(testedValue, resultTextData);
        }
    }
}