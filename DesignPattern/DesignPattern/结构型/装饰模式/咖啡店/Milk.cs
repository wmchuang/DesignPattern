namespace DesignPattern.结构型.装饰模式.咖啡店
{
    /// <summary>
    /// 装饰类-加奶
    /// </summary>
    public class Milk : CondimentDecorator
    {
        public Milk(string description, Beverage beverage) : base(description, beverage)
        {
        }

        public override double Cost()
        {
            return 5 + base.Cost();
        }
        
        public override string GetDescription()
        {
            return Description + base.GetDescription();
        }
    }
}