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
        public Tank()
        {
            Random random = new Random();
            Boekomplect = random.Next(5, 10);
            Yroven_Broni = random.Next(80, 110);
            Opit_Ecipasha = random.Next(1, 10);
        }
        public static bool operator *(Tank tank1, Tank tank2)
        {


            return true;
        }
        public override string ToString()
        {
            return ("\n" + Tank_Name + ":\n Boekomplect - " + Boekomplect + "\n Yroven_Broni - " + Yroven_Broni 
                + "\n Yroven_Manevrenosti - " + Yroven_Manevrenosti + "\n Opit_Ecipasha - " + Opit_Ecipasha 
                + "\n Maskirovca - " + Maskirovca);
        }
    }
}
