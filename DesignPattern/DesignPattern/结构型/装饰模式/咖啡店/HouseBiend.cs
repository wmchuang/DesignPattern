namespace DesignPattern.结构型.装饰模式.咖啡店
{
    public class HouseBiend : Beverage
    {

        public HouseBiend(string description) : base(description)
        {
        }
       
        public override double Cost()
        {
            return 4.5;
        }

     
    }
}