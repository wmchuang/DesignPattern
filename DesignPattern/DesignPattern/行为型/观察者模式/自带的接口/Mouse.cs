using System;

namespace DesignPattern.行为型.观察者模式.自带的接口
{
    public class Mouse: IObserver<int>
    {
        private IDisposable unsubscriber;
        private string instName;

        public void OnCompleted()
        {
            unsubscriber.Dispose();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("The location cannot be determined.");
        }

        public void OnNext(int value)
        {
            Console.WriteLine(value);
            Console.WriteLine("老鼠逃");
        }
        
     
    }
}