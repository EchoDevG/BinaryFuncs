using System;
using System.IO;
using BinaryFuncs;

namespace BinaryFuncsTesting
{
    public class Program
    {
        static void Main()
        {
            TwosComplimentBinary bin = new TwosComplimentBinary();
            bin.setBinaryWithDenary(-47);

            Console.WriteLine(bin.getBinary());

            bin.changeSign();

            Console.WriteLine(bin.getBinary());

            Console.ReadKey();
        }
    }
}