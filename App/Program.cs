using CodeWars;
using CodinGame_Wa;
using CodinGame_WA;
using static System.Reflection.Metadata.BlobBuilder;
using System;


internal class Program
{
    private static void Main(string[] args)
    {
        //var myClass = new ClosestToZero();

        Console.WriteLine("Démarage de l'App");

        string[] dataIn = ["the", "dog", "got", "the", "bone"];
        int[] dataOut = [1, 1, 1, 2];

        var test = new WordsFrequencies();
        var res = test.CountFrequencies(dataIn);

    }
}