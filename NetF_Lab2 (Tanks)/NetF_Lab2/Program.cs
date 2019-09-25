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
            List<Tank> T32 = new List<Tank>();
            List<Tank> Pantera = new List<Tank>();
            for (int i = 0; i < 2; i++)
            {
                T32.Add(new TankT34());
            }

        }
    }
}
