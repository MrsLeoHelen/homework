using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL
{
    public static class Task5
    {
        public static void DoIt()
        {
            //создание и наполнение массива
            int[,] Arr = new int[5, 5];
            int Size_Arri = 5, Size_Arrj = 5;
            Random Rnd = new Random();
            List<int> List_Arr = new List<int>();
            for (int i = 0; i < Size_Arri; i++)
            {
                for (int j = 0; j < Size_Arrj; j++)
                {
                    Arr[i, j] = Rnd.Next(-100, 100);
                    Console.Write(Arr[i, j] + "\t");
                    List_Arr.Add(Arr[i, j]);
                }
                Console.WriteLine();
            }

            //нахождение индексов минимального и максимального значений
            int Min_i = 0, Min_j = 0, Max_i = 0, Max_j = 0;
            int Min = List_Arr.Min(), Max = List_Arr.Max();
            for (int i = 0; i < Size_Arri; i++)
            {
                for(int j = 0; j < Size_Arrj; j++)
                {
                    if(Arr[i,j] == Min)
                    {
                        Min_i = i;
                        Min_j = j;
                    }
                    else
                        if (Arr[i,j] == Max)
                    {
                        Max_i = i;
                        Max_j = j;
                    }
                }
            }
            Console.WriteLine($"Min - {List_Arr.Min()}");
            Console.WriteLine($"Max - {List_Arr.Max()}");

            //замена местами индексов
            int Temp;
            if (Min_j > Max_j)
            {
                Temp = Min_j;
                Min_j = Max_j;
                Max_j = Temp;
            }
            if(Min_i > Max_i)
            {
                Temp = Min_i;
                Min_i = Max_i;
                Max_i = Temp;
            }

            //подсчет суммы
            List_Arr.Clear();
            for (int i = Min_i; i <= Max_i; i++)
            {
                for (int j = Min_j; j <= Max_j; j++)
                {
                    List_Arr.Add(Arr[i, j]);
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Sum - {List_Arr.Sum()}");
        }
        
    }
}
