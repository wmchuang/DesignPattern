using System;

namespace DesignPattern.创建型.单例模式
{
    public class TestInstance
    {
        private static TestInstance instance;

        private TestInstance()
        {
            Console.WriteLine("TestInstance懒汉式被创建");
        }

        public static TestInstance Instance = new TestInstance();
        // public static TestInstance Instance
        // {
        //     get
        //     {
        //         if (instance == null)
        //         {
        //             instance = new TestInstance();
        //         }
        //
        //         return instance;
        //     }
        // }
        
        public void Print()
        {
            Console.WriteLine("测试");
        }
    }
}