using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Soy : CondimentDecorator
    {
        public Soy(Beverage coffee) : base(coffee.Name + " с соей ", coffee) { }
        public override double Cost()
        {
            return beverage.Cost() + 4;
        }
    }
}
