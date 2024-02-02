using System;
using System.Collections.Generic;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namn = new List<string>();
            Console.WriteLine("Skriv hur många namn som helst, avsluta med tom rad");
            string nynamn = " ";
            while (nynamn != "")
            {
                Console.WriteLine("Skriv nytt namn:");
                nynamn = Console.ReadLine();
                if (nynamn != "")
                {
                    namn.Add(nynamn);
                }
            }
            Console.WriteLine("Här är alla namn du skrev in:");
            namn.Sort();
            namn.Reverse();
            foreach (string element in namn)
            {
                Console.WriteLine(element);
            }
        }
    }
}