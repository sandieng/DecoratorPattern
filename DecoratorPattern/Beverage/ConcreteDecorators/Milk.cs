using Beverage.Decorators;

namespace Beverage.ConcreteDecorators
{
    public class Milk : CondimentDecorator
    {
        private Beverage _beverage;

        public Milk(Beverage beverage)
        {
            _beverage = beverage;
        }
        
        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Milk";
        }

        public override double Cost()
        {
            return 0.30 + _beverage.Cost();
        }
    }
}
