using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Decaf : Beverage
    {
        public Decaf() : base("Кофе без кофеина") { }
        public override double Cost()
        {
            return 25;
        }
    }
}
