using System;

namespace DesignPattern.创建型.工厂模式.基本
{
    public class ProductB : IProduct
    {
        public void Show()
        {
            Console.WriteLine("我是产品B");
        }
    }
}