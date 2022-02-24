// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using HomeWork1;


class Program
{
    public static void Main()
    {
        Console.WriteLine(RomanNumber.Add(new RomanNumber(20), new RomanNumber(10)));
        Console.WriteLine(RomanNumber.Sub(new RomanNumber(20), new RomanNumber(10)));
        Console.WriteLine(RomanNumber.Mul(new RomanNumber(20), new RomanNumber(10)));
        Console.WriteLine(RomanNumber.Div(new RomanNumber(20), new RomanNumber(10)));

        RomanNumber[] nums =
        {
            new RomanNumber(1000),
            new RomanNumber(500),
            new RomanNumber(69)
        };
        

        Array.Sort(nums);
        Console.WriteLine(string.Join<RomanNumber>(',',nums));

    }
}