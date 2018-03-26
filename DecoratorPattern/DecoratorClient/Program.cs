using Beverage.ConcreteComponents;
using Beverage.ConcreteDecorators;
using System;

namespace DecoratorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage.Beverage espresso = new Espresso();
            Console.WriteLine($"{espresso.GetDescription()}, ${espresso.Cost()}");

            Beverage.Beverage soyHouseBlend = new HouseBlend();
            soyHouseBlend = new Soy(soyHouseBlend);
            Console.WriteLine($"{soyHouseBlend.GetDescription()}, ${soyHouseBlend.Cost()}");

            Beverage.Beverage doubleMochaWithWhipInDarkRoast = new DarkRoast();
            doubleMochaWithWhipInDarkRoast = new Mocha(doubleMochaWithWhipInDarkRoast);
            doubleMochaWithWhipInDarkRoast = new Mocha(doubleMochaWithWhipInDarkRoast);
            doubleMochaWithWhipInDarkRoast = new Whip(doubleMochaWithWhipInDarkRoast);

            Console.WriteLine($"{doubleMochaWithWhipInDarkRoast.GetDescription()}, ${doubleMochaWithWhipInDarkRoast.Cost()}");
            Console.ReadKey();
        }
    }
}
