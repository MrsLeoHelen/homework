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
            Random Rnd = new Random();
            List<int> List_Arr = new List<int>();
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Arr[i, j] = Rnd.Next(-100, 100);
                    Console.Write(Arr[i, j] + "\t");
                    List_Arr.Add(Arr[i, j]);
                }
                Console.WriteLine();
            }

            //нахождение индексов минимального и максимального значений
            int Min_i = 0, Min_j = 0, Max_i = 0, Max_j = 0;
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for(int j = 0; j < Arr.GetLength(1); j++)
                {
                    if(Arr[i,j] == List_Arr.Min())
                    {
                        Min_i = i;
                        Min_j = j;
                    }
                    else
                        if (Arr[i,j] == List_Arr.Max())
                    {
                        Max_i = i;
                        Max_j = j;
                    }
                }
            }
            Console.WriteLine("Min - {0}", List_Arr.Min());
            Console.WriteLine("Max - {0}", List_Arr.Max());

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
            foreach(int el in List_Arr)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sum - {0}", List_Arr.Sum());
        }
        
    }
}
