namespace DesignPattern.结构型.装饰模式.咖啡店
{
    /// <summary>
    /// 抽象的咖啡
    /// </summary>
    public abstract class Beverage
    {
        protected Beverage(string description)
        {
            Description = description;
        }

        protected string Description { get; }

        public string GetDescription() => Description;

        public abstract double Cost();
    }
}