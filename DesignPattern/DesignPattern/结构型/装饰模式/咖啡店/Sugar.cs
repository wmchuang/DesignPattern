namespace DesignPattern.结构型.装饰模式.咖啡店
{
    public class Sugar : CondimentDecorator
    {

        public Sugar(string description, Beverage beverage) : base(description, beverage)
        {
        }

        public override double Cost()
        {
            return 30 + base.Cost();
        }

        public new string GetDescription()
        {
            return Description + base.GetDescription();
        }
    }
}