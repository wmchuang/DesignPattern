using System;

namespace DesignPattern.行为型.观察者模式.自带的接口
{
    public class Person : IObserver<int>
    {
        private IDisposable unsubscriber;
        private string instName;

        public void OnCompleted()
        {
            this.Unsubscribe();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("The location cannot be determined.");
        }

        public void OnNext(int value)
        {
            Console.WriteLine(value);
            Console.WriteLine("人醒");
        }
        
        // 取消订阅
        protected virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}