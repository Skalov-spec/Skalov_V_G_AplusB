using System;
using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger a, b;
            a = BigInteger.Parse(Console.ReadLine());
            b = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(a+b);       
        }
    }
}
