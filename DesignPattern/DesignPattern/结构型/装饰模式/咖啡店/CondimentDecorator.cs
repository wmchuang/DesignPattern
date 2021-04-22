namespace DesignPattern.结构型.装饰模式.咖啡店
{
    /// <summary>
    /// 装饰基类
    /// </summary>
    public class CondimentDecorator : Beverage
    {
        private readonly Beverage _beverage;

        protected CondimentDecorator(string description, Beverage beverage) : base(description)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return _beverage.Cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription();
        }
    }
}