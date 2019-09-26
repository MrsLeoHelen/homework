using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL
{
    public class TankT34:Tank
    {
        public static int countT34 = 1;
        public TankT34() : base()
        {
            Maskirovca = random.Next(5, 10);
            Yroven_Manevrenosti = random.Next(1, 100);
            Tank_Name = "T34-" + countT34;
            countT34++;
        }
    }
}
