using CodeWars;
using CodinGame_Wa;


internal class Program
{
    private static void Main(string[] args)
    {
        //var computer = new ComputeBytes();
        //var computedOctet = computer.Compute(1048575);

        //Console.WriteLine("Démarage de l'App");
        //Console.WriteLine(computedOctet);

        var codeWars = new CodeWarsGame();
        var multiply = codeWars.Multiply(-2);

        Console.WriteLine(multiply);
    }
}