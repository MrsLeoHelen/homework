using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL
{
    public static class Task1
    {
        public static void DoIt()
        {
            //объявление одномерного и двумерного массивов соответсвенно
            int[] A = new int[5];
            double[,] B = new double[3, 4];
            int Size_A = A.GetLength(0), Size_Bi = B.GetLength(0), Size_Bj = B.GetLength(1);

            //ввод с клавиатуры одномерного массива
            Console.WriteLine("Enter Array of integer (5 elements):");
            string str;
            int num;
            for (int i = 0; i < Size_A; i++)
            {
                str = Console.ReadLine();
                while (!int.TryParse(str, out num))
                {
                    Console.WriteLine("Try again:");
                    str = Console.ReadLine();
                }
                A[i] = num;
            }
            Console.WriteLine();
            //вывод одномерного массива
            foreach (int el in A)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();

            //рандомный ввод двумерного массива дабл
            Random rnd = new Random();
            for (int i = 0; i < Size_Bi; i++)
            {
                for (int j = 0; j < Size_Bj; j++)
                {
                    B[i, j] = Math.Round(rnd.NextDouble() * 10, 2);
                }
            }
            Console.WriteLine();

            //вывод двумерного массива
            for (int i = 0; i < Size_Bi; i++)
            {
                for (int j = 0; j < Size_Bj; j++)
                {
                    Console.Write($"{B[i, j]} ");
                }
            }
            Console.WriteLine();

            //выполнение действий над одномерным массивом
            List<int> List_A = A.ToList();
            List<double> List_B = B.Cast<double>().ToList();
            //максимальное значение
            if (List_A.Max() > List_B.Max())
            {
                Console.WriteLine($"max element = {List_A.Max()}");
            }
            else
            {
                Console.WriteLine($"max element = {List_B.Max()}");
            }
            double Max = A[0];
            for (int i = 1; i < Size_A; i++)
            {
                if (Max < A[i])
                    Max = A[i];
            }
            for (int i = 0; i < Size_Bi; i++)
            {
                for (int j = 0; j < Size_Bj; j++)
                {
                    if (Max < B[i, j])
                        Max = B[i, j];
                }
            }
            Console.WriteLine($"max element = {Max}");
            Console.WriteLine();
            //минимальное значение
            if (List_A.Min() < List_B.Min())
            {
                Console.WriteLine($"min element = {List_A.Min()}");
            }
            else
            {
                Console.WriteLine($"min element = {List_B.Min()}");
            }
            double Min = A[0];
            for (int i = 1; i < Size_A; i++)
            {
                if (Min > A[i])
                    Min = A[i];
            }
            for (int i = 0; i < Size_Bi; i++)
            {
                for (int j = 0; j < Size_Bj; j++)
                {
                    if (Min > B[i, j])
                        Min = B[i, j];
                }
            }
            Console.WriteLine($"min element = {Min}");
            Console.WriteLine();
            //сумма элементов
            Console.WriteLine($"sum elements = {(List_A.Sum() + List_B.Sum())}");
            double Sum = 0;
            for (int i = 0; i < Size_A; i++)
            {
                Sum += A[i];
            }
            for(int i = 0; i < Size_Bi; i++)
            {
                for (int j = 0; j < Size_Bj; j++)
                {
                    Sum += B[i, j];
                }
            }
            Console.WriteLine($"sum elements = {Sum}");
            Console.WriteLine();
            //произведение
            double Mult = 1;
            List_A.ForEach(value => Mult *= value);
            List_B.ForEach(value => Mult *= value);
            Mult = Math.Round(Mult, 2);
            Console.WriteLine($"multiplication elements = {Mult}");
            Mult = 1;
            for (int i = 0; i < Size_A; i++)
            {
                Mult *= A[i];
            }
            for (int i = 0; i < Size_Bi; i++)
            {
                for(int j = 0; j < Size_Bj; j++)
                {
                    Mult *= B[i, j];
                }
            }
            Console.WriteLine($"multiplication elements = {Math.Round(Mult, 2)}");
            Console.WriteLine();
            //
            List_A.Clear();
            for (int i = 0; i < Size_A && (i % 2) == 0; i++)
            {
                List_A.Add(A[i]);
            }
            List_B.Clear();
            for (int i = 0; i < Size_Bi; i++)
            {
                if (i % 2 == 0) continue;
                for (int j = 0; j < Size_Bj; j++)
                {
                    List_B.Add(B[i, j]);
                }
            }
            Console.WriteLine($"sum even elemets and odd elements of B = {(List_A.Sum() + List_B.Sum())}");
            Console.WriteLine();
        }
    }
}
