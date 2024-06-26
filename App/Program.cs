﻿using CodeWars;
using CodinGame_Wa;
using CodinGame_WA;
using static System.Reflection.Metadata.BlobBuilder;
using System;


public class Program
{
    private static void Main(string[] args)
    {
        //var myClass = new ClosestToZero();

        Console.WriteLine("Démarage de l'App");

        //string[] dataIn = ["the", "dog", "got", "the", "bone"];
        //int[] dataOut = [1, 1, 1, 2];

        //var test = new WordsFrequencies();
        //var res = test.CountFrequencies(dataIn);

        // Top Stocks
        //string[] stocks = { "AMZN", "CACC", "EQIX", "GOOG", "ORLY", "ULTA"};
        //float[,] prices = {
        //    {12.81f, 11.09f, 12.11f, 10.93f, 9.83f, 8.14f},
        //    {10.34f, 10.56f, 10.14f, 12.17f, 13.1f, 11.22f},
        //    {11.53f, 10.67f, 10.42f, 11.88f, 11.77f, 10.21f}
        //};

        //var topStocks = new TopStocks();
        //var test = topStocks.GetTopStocks2(stocks, prices);

        // change Money
        long s = 10; // Change this value to perform other tests
        Change m = ChangeCoin.OptimalChange(s);

        Console.WriteLine("Coin(s)  2€: " + m.coin2);
        Console.WriteLine("Bill(s)  5€: " + m.bill5);
        Console.WriteLine("Bill(s) 10€: " + m.bill10);

        long result = m.coin2 * 2 + m.bill5 * 5 + m.bill10 * 10;
        Console.WriteLine("\nChange given = " + result);

    }
}