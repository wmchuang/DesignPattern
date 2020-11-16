using System;

namespace DesignPattern.创建型.工厂模式.发奖
{
    public interface ICommodity
    {
        void SendCommodity(string uId, string commodityId);
    }

    public class CouponCommodityService : ICommodity
    {
        public void SendCommodity(string uId, string commodityId)
        {
            Console.WriteLine("优惠券发奖");
        }
    }
    
    public class GoodsCommodityService: ICommodity
    {
        public void SendCommodity(string uId, string commodityId)
        {
            Console.WriteLine("实物发奖");
        }
    }
}