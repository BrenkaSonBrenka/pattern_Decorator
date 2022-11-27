using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DarkRoast : Beverage
    {
        public DarkRoast() : base("Обжарка кофе медиум и дарк") { }
        public override double Cost()
        {
            return 20.5;
        }
    }
}
