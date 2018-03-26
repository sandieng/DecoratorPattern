using Beverage.Decorators;

namespace Beverage.ConcreteDecorators
{
    public class Soy : CondimentDecorator
    {
        private Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Soy";
        }

        public override double Cost()
        {
            return 0.50 + _beverage.Cost();
        }
    }
}
