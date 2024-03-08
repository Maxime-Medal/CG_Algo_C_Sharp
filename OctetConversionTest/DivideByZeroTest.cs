using CodinGame_Wa;

namespace CodinGame_Wa_Test
{
    public class DivideByZeroTest
    {

        [Theory]
        [InlineData(2,0)]
        [InlineData(0,5)]
        public void mustBeInErrorDivideByZero(int a, int b)
        {

            ComputeBytes computer = new ();
            Assert.Throws<DivideByZeroException>(() => computer.calculForTest(a, b));
        }

    }
}