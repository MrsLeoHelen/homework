using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL
{
    public static class Task2
    {
        public static void DoIt()
        {
            //создание массивов
            int Size_M, Size_N;
            Console.Write("Enter size of M: ");
            Size_M = Int32.Parse(Console.ReadLine());
            Console.Write("Enter size of N: ");
            Size_N = Int32.Parse(Console.ReadLine());
            int[] Array_M = new int[Size_M], Array_N = new int[Size_N];

            //заполнение массивов рандомными значениями
            Random rnd = new Random();
            for (int i = 0; i < Size_M; i++)
            {
                Array_M[i] = rnd.Next(10);
            }
            for (int i = 0; i < Size_N; i++)
            {
                Array_N[i] = rnd.Next(10);
            }
            Console.WriteLine();

            //вывод массивов на консоль
            Console.WriteLine("Array_M:");
            foreach (int el in Array_M)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Array_N:");
            foreach (int el in Array_N)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine("\n");

            //создание третьего массива и вывод его
            int[] Array_MN = Array_M.Intersect(Array_N).ToArray();
            Console.WriteLine("Array_MN");
            foreach (int el in Array_MN)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
    }
}
