using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL
{
    public static class Task3
    {
        public static void DoIt()
        {
            string Str;
            Console.WriteLine("Enter your string:");
            Str = Console.ReadLine();
            if(Enumerable.SequenceEqual(Str.ToArray(), Str.Reverse().ToArray()))
            {
                Console.WriteLine("U string is PALINDROM");
            }
            else
            {
                Console.WriteLine("U string is NOT PALINDROM");
            }
            Console.WriteLine();
        }
    }
}
