namespace CodinGame_WA
{
    public class ResistorValue
    {
        enum resistorValue
        {
            Black,
            Brown,
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Purple,
            Grey,
            White
        }

        //Given three colors of resistor, you have to find its value in ohm.

        //Resistor value equals to the first color multiplied by 10 added to the second color and this sum is multiplied by 10 to the power of the third color.
        //In input we have Red Black Brown, so in output we have (2*10 + 0)*(10**1). Thus the value is 200 ohm.
        public long Main(string args)
        {
            string[] inputs = args.Split(' ');
            string color1 = inputs[0];
            string color2 = inputs[1];
            string color3 = inputs[2];

            var r1 = checkValue(color1);
            var r2 = checkValue(color2);
            var r3 = checkValue(color3);


            return (long)((r1 * 10 + r2) * (Math.Pow(10, r3)));
        }

        public int checkValue(string color) => color switch
        {
            "Black" => 0,
            "Brown" => 1,
            "Red" => 2,
            "Orange" => 3,
            "Yellow" => 4,
            "Green" => 5,
            "Blue" => 6,
            "Purple" => 7,
            "Grey" => 8,
            "White" => 9,
            _ => throw new ArgumentOutOfRangeException(nameof(color), $"Color with unexpected value : {color}")

        };
    }
}