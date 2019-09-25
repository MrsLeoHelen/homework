using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL
{
    public class TankPantera:Tank
    {
        static int count = 1;
        public TankPantera() : base()
        {
            Random random = new Random();
            Maskirovca = random.Next(1, 10);
            Yroven_Manevrenosti = random.Next(20, 100);
            Tank_Name = "Pantera-" + count;
            count++;
        }
    }
}
