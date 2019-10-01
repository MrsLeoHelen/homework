using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL
{
    public abstract class Tank
    {
        public string Tank_Name { get; set; }
        public int Boekomplect { get; set; }
        public int Yroven_Broni { get; set; }
        public int Yroven_Manevrenosti { get; set; }
        public int Opit_Ecipasha { get; set; }
        public int Maskirovca { get; set; }
        public static Random random = new Random();
        public Tank()
        {
            Boekomplect = random.Next(5, 10);
            Yroven_Broni = random.Next(80, 110);
            Opit_Ecipasha = random.Next(1, 10);
        }
        public static bool operator *(Tank tank1, Tank tank2)
        {
            int countTank1 = 0, countTank2 = 0;
            //проверка маневренности
            if (tank1.Yroven_Manevrenosti > tank2.Yroven_Manevrenosti)
                countTank1++;
            else if (tank1.Yroven_Manevrenosti < tank2.Yroven_Manevrenosti)
                countTank2++;
            //проверка опыта
            if (tank1.Opit_Ecipasha > tank2.Opit_Ecipasha)
                countTank1++;
            else if (tank1.Opit_Ecipasha < tank2.Opit_Ecipasha)
                countTank2++;
            //првоерка маскировки
            if (tank1.Maskirovca > tank2.Maskirovca)
                countTank1++;
            else if (tank1.Maskirovca < tank2.Maskirovca)
                countTank2++;
            //проверка на победу и изменения танков
            if (countTank1 == countTank2)
            {
                Console.WriteLine("Standoff");
                return false;
            }
            else if (countTank1 > countTank2)
            {
                Console.WriteLine($"{tank1.Tank_Name} is WIN");
                tank1.change(tank2);
            }
            else if (countTank1 < countTank2)
            {
                Console.WriteLine($"{tank2.Tank_Name} is WIN");
                tank2.change(tank1);
            }
            return true;
        }
        private Tank change(Tank tank)
        {
            tank.Yroven_Broni -= this.Boekomplect;
            this.Yroven_Broni -= tank.Boekomplect / 2;
            tank.Opit_Ecipasha++;
            this.Opit_Ecipasha++;
            tank.Maskirovca++;
            return this;
        }
        public override string ToString()
        {
            return (Tank_Name + ":\n Boekomplect - " + Boekomplect + "\n Yroven_Broni - " + Yroven_Broni 
                + "\n Yroven_Manevrenosti - " + Yroven_Manevrenosti + "\n Opit_Ecipasha - " + Opit_Ecipasha 
                + "\n Maskirovca - " + Maskirovca);
        }
    }
}
