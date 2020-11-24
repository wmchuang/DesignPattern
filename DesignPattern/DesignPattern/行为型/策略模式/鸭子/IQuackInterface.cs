using System;

namespace DesignPattern.行为型.策略模式.鸭子
{
    /// <summary>
    /// 呱呱叫行为
    /// </summary>
    public interface IQuackInterface
    {
        public void Quack();
    }
    
    public class GaGaQuack : IQuackInterface
    {
        public void Quack()
        {
            Console.WriteLine("嘎嘎叫");
        }
    }
    
    public class Squeak : IQuackInterface
    {
        public void Quack()
        {
            Console.WriteLine("吱吱叫");
        }
    }
    
    public class MuteQuack : IQuackInterface
    {
        public void Quack()
        {
            Console.WriteLine("不叫");
        }
    }
}