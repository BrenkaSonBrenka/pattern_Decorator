using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Whip : CondimentDecorator
    {
        public Whip(Beverage coffee) : base(coffee.Name + " со взбитыми сливками ", coffee) { }
        public override double Cost()
        {
            return beverage.Cost() + 2.5;
        }
    }
}
