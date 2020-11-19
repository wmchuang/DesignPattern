using System;

namespace DesignPattern.结构型.适配器模式.基本
{
    /// <summary>
    /// 适配器类
    /// </summary>
    public class Adapter : ITarget
    {
        private Adaptee _adaptee = new Adaptee();

        public  void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}