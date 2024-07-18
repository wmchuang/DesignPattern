using System;

namespace DesignPattern.结构型.适配器模式.类适配器模式.电压
{
    public class Voltage220V
    {
        public int Output220V() {
            int src = 220;
            Console.WriteLine("电压220V");
            return src;
        }
    }
}