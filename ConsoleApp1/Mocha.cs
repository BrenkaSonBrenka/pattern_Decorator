using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Mocha : CondimentDecorator
    {
        public Mocha(Beverage coffee) : base(coffee.Name + " с мокко ", coffee) { }
        public override double Cost()
        {
            return beverage.Cost() + 3;
        }
    }
}
