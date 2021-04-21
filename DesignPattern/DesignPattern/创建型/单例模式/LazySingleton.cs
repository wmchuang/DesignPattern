using System;

namespace DesignPattern.创建型.单例模式
{
    public sealed class LazySingleton
    {
        private static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton());

        private LazySingleton()
        {
            Console.WriteLine("Lazy<T>");
        }

        public static LazySingleton Instance => _instance.Value;

        public void Print()
        {
            Console.WriteLine("测试");
        }
    }
}