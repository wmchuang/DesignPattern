using System;

namespace DesignPattern.结构型.代理模式.基本
{

    /// <summary>
    /// 被代理的真正的对象
    /// </summary>
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("我是真正的对象");
        }
    }
}