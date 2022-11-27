using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Espresso : Beverage
    {
        public Espresso() : base("Эспрессо") { }
        public override double Cost()
        {
            return 32.5;
        }
    }
}
