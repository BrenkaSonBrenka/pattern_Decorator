using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Beverage coffee1 = new Espresso();
            coffee1 = new Soy(coffee1);
            Console.WriteLine("{0}\nЦена - {1}\n", coffee1.Name, coffee1.Cost());
            Beverage coffee2 = new HouseBlend();
            coffee2 = new Milk(coffee2);
            coffee2 = new Whip(coffee2);
            Console.WriteLine("{0}\nЦена - {1}\n", coffee2.Name, coffee2.Cost());
            Beverage coffee3 = new DarkRoast();
            coffee3 = new Milk(coffee3);
            coffee3 = new Whip(coffee3);
            coffee3 = new Mocha(coffee3);
            coffee3 = new Soy(coffee3);
            Console.WriteLine("{0}\nЦена - {1}\n", coffee3.Name, coffee3.Cost());
            Console.ReadLine();
        }
    }
}