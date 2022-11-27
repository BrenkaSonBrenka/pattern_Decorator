using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Milk : CondimentDecorator
    {
        public Milk(Beverage coffee) : base(coffee.Name + " с молоком ", coffee) { }
        public override double Cost()
        {
            return beverage.Cost() + 5;
        }
    }
}
