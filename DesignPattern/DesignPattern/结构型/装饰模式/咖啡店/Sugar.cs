namespace DesignPattern.结构型.装饰模式.咖啡店
{
    /// <summary>
    /// 装饰类-加糖
    /// </summary>
    public class Sugar : CondimentDecorator
    {
        public Sugar(string description, Beverage beverage) : base(description, beverage)
        {
        }

        public override double Cost()
        {
            return 30 + base.Cost();
        }

        public override string GetDescription()
        {
            return Description + base.GetDescription();
        }
    }
}