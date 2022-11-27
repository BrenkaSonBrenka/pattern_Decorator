using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;

        public CondimentDecorator(string name, Beverage beverage) : base(name)
        {
            this.beverage = beverage;
        }
    }
}
