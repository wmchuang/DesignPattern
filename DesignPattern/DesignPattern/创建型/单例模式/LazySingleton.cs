using System;

namespace DesignPattern.创建型.单例模式
{
    public class LazySingleton
    {
        private static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton());

        public static LazySingleton Instance => _instance.Value;

        private LazySingleton(){
            Console.WriteLine("Lazy<T>");
        }
        

        public void Print()
        {
            Console.WriteLine("测试");
        }

    }
}