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
            while(T34.Count > 0 || Pantera.Count > 0)
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

                //
                Console.WriteLine("BATTLE " + countBattle++);


                Console.WriteLine("Tap Enter to next Battle");
                Console.ReadLine();
            }
        }
    }
}
