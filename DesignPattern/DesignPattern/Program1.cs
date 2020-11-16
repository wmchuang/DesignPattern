using System;
using DesignPattern.结构型.适配器模式.对象适配器模式.电源插头;
using DesignPattern.结构型.适配器模式.类适配器模式.电源插头;
using PowerAdapter = DesignPattern.结构型.适配器模式.类适配器模式.电源插头.PowerAdapter;

namespace DesignPattern
{
    public class Program1
    {
        static void Main(string[] args)
        {
            #region 适配器模式

            {
                IThreeHole threehole = new PowerAdapter();
                threehole.Request();
            }

            {
                // 现在客户端可以通过电适配要使用2个孔的插头了
                ThreeHole threehole = new PowerAdapter1();
                threehole.Request();
                Console.ReadLine();
            }

            #endregion

            Console.ReadLine();
        }
    }
}