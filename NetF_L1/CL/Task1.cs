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

            //ввод с клавиатуры одномерного массива
            Console.WriteLine("Enter Array of integer (5 elements):");
            for (int el = 0; el < A.Length; el++)
            {
                var a = Console.ReadLine();
                A[el] = Int32.Parse(a);
            }
            Console.WriteLine();

            //вывод одномерного массива
            foreach (int el in A)
            {
                Console.Write("{0} ", el);
            }
            Console.WriteLine();

            //рандомный ввод двумерного массива дабл
            Random rnd = new Random();
            for (int el1 = 0; el1 < B.GetLength(0); el1++)
            {
                for (int el2 = 0; el2 < B.GetLength(1); el2++)
                {
                    B[el1, el2] = rnd.NextDouble() * 10;
                }
            }
            Console.WriteLine();

            //вывод двумерного массива
            for (int el1 = 0; el1 < B.GetLength(0); el1++)
            {
                for (int el2 = 0; el2 < B.GetLength(1); el2++)
                {
                    Console.Write("{0:#.##} ", B[el1, el2]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //выполнение действий над одномерным массивом
            List<int> List_A = A.ToList();
            List<double> List_B = B.Cast<double>().ToList();
            if (List_A.Max() > List_B.Max())
            {
                Console.WriteLine("max element = {0}", List_A.Max());
            }
            else
            {
                Console.WriteLine("max element = {0:#.##}", List_B.Max());
            }
            if (List_A.Min() < List_B.Min())
            {
                Console.WriteLine("min element = {0}", List_A.Min());
            }
            else
            {
                Console.WriteLine("min element = {0:#.##}", List_B.Min());
            }
            Console.WriteLine("sum elements = {0:#.##}", (List_A.Sum() + List_B.Sum()));
            double Mult = 1;
            List_A.ForEach(value => Mult *= value);
            List_B.ForEach(value => Mult *= value);
            Console.WriteLine("multiplication elements = {0:#.##}", Mult);
            List_A.Clear();
            for (int i = 0; i < A.GetLength(0) && (i % 2) == 0; i++)
            {
                List_A.Add(A[i]);
            }
            List_B.Clear();
            for (int i = 0; i < B.GetLength(0); i++)
            {
                if (i % 2 == 0) continue;
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    List_B.Add(B[i, j]);
                }
            }
            Console.WriteLine("sum even elemets and odd elements of B = {0:#.##}", (List_A.Sum() + List_B.Sum()));
            Console.WriteLine();
        }
    }
}
