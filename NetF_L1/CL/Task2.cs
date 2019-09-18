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
            string str = Console.ReadLine();
            while (!int.TryParse(str, out Size_M))
            {
                Console.WriteLine("Try again:");
                str = Console.ReadLine();
            }
            Console.Write("Enter size of N: ");
            str = Console.ReadLine();
            while(!int.TryParse(str, out Size_N))
            {
                Console.WriteLine("Try again:");
                str = Console.ReadLine();
            }
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
            List<int> List_MN = new List<int>();
            for (int i = 0; i < Size_M; i++)
            {
                if (List_MN.Exists(element => element == Array_M[i]) == false)
                {
                    for (int j = 0; j < Size_N; j++)
                    {
                        if (Array_M[i] == Array_N[j])
                        {
                            List_MN.Add(Array_M[i]);
                            break;
                        }
                    }
                }
            }
            int[] Array_MN = List_MN.ToArray();
            Console.WriteLine("Array_MN");
            foreach (int el in Array_MN)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
    }
}
