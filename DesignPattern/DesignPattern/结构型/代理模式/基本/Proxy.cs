using System;

namespace DesignPattern.结构型.代理模式.基本
{
    /// <summary>
    /// 代理类
    /// 编译阶段就初始化了包装类
    /// </summary>
    public class Proxy : ISubject
    {
        private readonly RealSubject _realSubject = new RealSubject();
        public void Request()
        {
            Console.WriteLine("我是代理类，我可以做一些控制");
            _realSubject.Request();
        }
    }
}