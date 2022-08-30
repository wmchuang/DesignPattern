using System;

namespace DesignPattern.创建型.单例模式
{
    //懒汉式
    //优点： 在第一次使用时才被创建，无需一直占用系统资源，实现了延迟加载
    //缺点： 必须加锁 synchronized 才能保证单例，但加锁会影响效率。
    public sealed class Singleton1
    {
        private static Singleton1 _instance;
        private static readonly object Locker = new object();

        private Singleton1()
        {
            Console.WriteLine("懒汉式被创建");
        }

        public static Singleton1 GetInstance()
        {
            //双重检查锁定
            if (_instance != null) return _instance;
            lock (Locker)
            {
                if (_instance == null)
                {
                    // ReSharper disable once PossibleMultipleWriteAccessInDoubleCheckLocking
                    _instance = new Singleton1();
                    return _instance;
                }

                // _instance ??= new Singleton1();
            }

            return _instance;
        }

        public void Print()
        {
            Console.WriteLine("测试");
        }
    }
}