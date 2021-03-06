using System;

namespace DesignPattern.结构型.装饰模式.基本
{
    /// <summary>
    /// 装饰基类
    /// 不考虑扩展性和福哦那个，可以在这里直接添加修饰，类需要取消abstract
    /// </summary>
    public abstract class Decorator : Component
    {
        private readonly Component _innerComponent;

        protected Decorator(Component innerComponent)
        {
            _innerComponent = innerComponent;
        }

        public override void Work()
        {
            _innerComponent.Work();
        }
    }
}