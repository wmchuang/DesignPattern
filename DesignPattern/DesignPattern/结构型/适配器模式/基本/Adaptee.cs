using System;

namespace DesignPattern.结构型.适配器模式.基本
{
    /// <summary>
    /// 需要适配的类
    /// 该类的逻辑和数据绝大部分都满足，但是接口不兼容
    /// </summary>
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("我是需要适配的类，我可以做很多事情");
        }
    }
}