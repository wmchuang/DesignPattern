using System;

namespace DesignPattern.结构型.适配器模式.对象适配器模式.电压
{
    public class Phone
    {
        public void Charging(对象适配器模式.电压.IVoltage5V iVoltage5V) {
            if(iVoltage5V.Output5V() == 5) {
                Console.WriteLine("电压是5v，可以充电");
            } else if (iVoltage5V.Output5V() > 5) {
                Console.WriteLine("电压大于5v，不可充电");
            }
        }
    }
}