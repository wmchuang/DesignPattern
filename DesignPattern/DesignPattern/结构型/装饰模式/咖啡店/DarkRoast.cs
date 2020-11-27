namespace DesignPattern.结构型.装饰模式.咖啡店
{
    public class DarkRoast : Beverage
    {

        public DarkRoast(string description) : base(description)
        {
        }

        public override double Cost()
        {
            return 10;
        }
    }
}