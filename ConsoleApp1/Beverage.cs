using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Beverage
    {
        public string Name { get; set; }
        public abstract double Cost();
        public Beverage(string name)
        {
            this.Name = name;
        }
    }
}
