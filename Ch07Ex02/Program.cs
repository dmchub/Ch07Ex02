using System;
using static System.Console;


namespace Ch07Ex02
{
    class Program
    {
        static string[] eTypes = { "none", "simple", "index", "nested index", "filter" };
        static void Main(string[] args)
        {
            foreach(string eType in eTypes)
            {
                try
                {
                    WriteLine("Main() try block reached. "); // Line 21
                    WriteLine($"ThrowException(\"{eType}\") called.");
                    ThrowException(eType);
                }
            }
        }
    }
}
