using CL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetF_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //создание армий танков
            List<Tank> T34 = new List<Tank>();
            List<Tank> Pantera = new List<Tank>();
            for (int i = 0; i < 2; i++)
            {
                T34.Add(new TankT34());
                Pantera.Add(new TankPantera());
            }

            //ведение войны
            int countBattle = 1;
            int indexT34, indexPantera;
            while(true)
            {
                //вывод состояния армий
                Console.Clear();
                Console.WriteLine("ARMY T34:");
                foreach (Tank el in T34)
                {
                    Console.WriteLine(el);
                }
                Console.WriteLine("\nARMY Pantera:");
                foreach (Tank el in Pantera)
                {
                    Console.WriteLine(el);
                }
                Console.WriteLine();

                //проведение битвы
                Console.WriteLine("BATTLE " + countBattle++);
                indexT34 = Tank.random.Next(1, TankT34.countT34) - 1;
                indexPantera = Tank.random.Next(1, TankPantera.countPantera) - 1;
                if (T34[indexT34] * Pantera[indexPantera])
                {
                    if (checkOnDead(T34[indexT34]))
                    {
                        Console.WriteLine($"{T34[indexT34].Tank_Name} DIED");
                        T34.RemoveAt(indexT34);
                        TankT34.countT34--;
                    }
                    else if (checkOnDead(Pantera[indexPantera]))
                    {
                        Console.WriteLine($"{Pantera[indexPantera].Tank_Name} DIED");
                        Pantera.RemoveAt(indexPantera);
                        TankPantera.countPantera--;
                    }
                }
                //проверка будет ли ничья в войне
                else if (T34.Count() == 1 && Pantera.Count == 1)
                {
                    Console.WriteLine("STANDOFF OF WAR");
                    break;
                }
                //проверка на завершкние войны
                if (T34.Count() == 0)
                {
                    Console.WriteLine("Pantera ARMY WIN");
                    break;
                }
                if (Pantera.Count() == 0)
                {
                    Console.WriteLine("T34 ARMY WIN");
                    break;
                }
                Console.WriteLine("Tap Enter to next Battle");
                Console.ReadLine();
            }
        }
        public static bool checkOnDead(Tank tank)
        {
            if (tank.Yroven_Broni < 0)
                return true;
            else return false;
        }
    }
}
