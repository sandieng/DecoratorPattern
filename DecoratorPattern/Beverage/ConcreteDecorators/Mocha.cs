using Beverage.Decorators;

namespace Beverage.ConcreteDecorators
{
    public class Mocha : CondimentDecorator
    {
        private Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;            
        }
     
        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Mocha";
        }

        public override double Cost()
        {
            return 0.20 + _beverage.Cost();
        }
    }
}
