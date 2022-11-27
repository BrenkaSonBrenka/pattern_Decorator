using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HouseBlend : Beverage
    {
        public HouseBlend() : base("Домашняя смесь") { }
        public override double Cost()
        {
            return 15;
        }
    }
}
