namespace CodeWars
{
    public class CodeWarsGame
    {
        public int Multiply(int number)
        {
            var posNum = number;
            var isNegative = number < 0;
            if (isNegative)
            {
                posNum = -number;
            }
            var length = Math.Abs(posNum).ToString().Length;

            return (int)(number * Math.Pow(5, length));
        }

    }
}
