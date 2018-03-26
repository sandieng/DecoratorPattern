namespace Beverage.ConcreteComponents
{
    public class Espresso : Beverage
    {      
        public override string GetDescription()
        {
            return "Espresso";
        }

        public override double Cost()
        {
            return 2.00;
        }
    }
}
