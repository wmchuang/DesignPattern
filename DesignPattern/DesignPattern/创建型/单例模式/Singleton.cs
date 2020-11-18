using System;

namespace DesignPattern.创建型.单例模式
{
    //饿汉式（推荐）
    //由于在定义静态变量的时候实例化单例类，因此在类加载时单例对象就已创建，所以称之为饿汉式
    //优点： 无需考虑线程同时访问问题
    //缺点： 系统运行时就会创建对象，所以会占用资源
    public class Singleton
    {
        // private static readonly Singleton Instance = new Singleton();
        //
        private Singleton()
        {
            Console.WriteLine("饿汉式被创建");
        }
        //
        // public static Singleton GetInstance()
        // {
        //     return Instance;
        // }

        public void Print()
        {
            Console.WriteLine("测试");
        }

        //这里的 new Singleton() 等同于在静态构造函数中实例化。在 C# 7 中还可以进一步简写如下：
        public static Singleton Instance { get; } = new Singleton();
        
    }
}