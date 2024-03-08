namespace CodinGame_Wa
{
    public class ComputeBytes
    {
        public string Compute(int bytesQuantity)
        {
            string res;

            if (bytesQuantity < 1024)
            {
                res = bytesQuantity.ToString();
            }
            else if (bytesQuantity < 1048576)
            {
                var value = Math.Floor((double)bytesQuantity / 1024);
                res = $"{value} KiB";
            }
            else
            {
                var value = Math.Floor((double)bytesQuantity / 1048576);
                res = $"{value} MiB";

            }
            return res;

        }

        public  int calculForTest(int first, int second)
        {
            if (first == 0 || second == 0) throw  new DivideByZeroException();
            return first / second;
        }

    }
}
