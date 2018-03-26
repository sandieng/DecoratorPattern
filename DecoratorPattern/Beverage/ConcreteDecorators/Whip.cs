using Beverage.Decorators;

namespace Beverage.ConcreteDecorators
{
    public class Whip : CondimentDecorator
    {
        private Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()}, Whip";
        }

        public override double Cost()
        {
            return 0.20 + _beverage.Cost();
        }
    }
}
