using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL
{
    public class TankT34:Tank
    {
        public static int count;
        TankT34() : base()
        {
            Random random = new Random();
            Maskirovca = random.Next(5, 10);
            Yroven_Manevrenosti = random.Next(1, 100);
            Tank_Name = "T34-" + count;
            count++;
        }
    }
}
