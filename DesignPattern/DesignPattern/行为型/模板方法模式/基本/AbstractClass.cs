using System;

namespace DesignPattern.行为型.模板方法模式.基本
{
    public abstract class AbstractClass
    {
        public virtual void TemplateMethod()
        {
            Method1();
            Method2();
        }

        protected virtual void Method1()
        {
            Console.WriteLine("方法1");   
        }

        protected abstract void Method2();
    }
}