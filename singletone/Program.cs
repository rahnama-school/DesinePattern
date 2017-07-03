using System;

namespace singletone
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (var i = 0; i < 10; i++)
            {
                Single getSingle = Single.GetSingle;
            }
            Console.ReadLine();
        }
    }
}