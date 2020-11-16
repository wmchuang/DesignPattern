namespace DesignPattern.创建型.工厂模式.发奖
{
    public class StoreFactory
    {
        public ICommodity GetCommodity(int type)
        {
            return type switch
            {
                1 => new CouponCommodityService(),
                2 => new GoodsCommodityService(),
                _ => null
            };
        }
    }
}