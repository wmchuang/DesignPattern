using System;

namespace DesignPattern.行为型.观察者模式.自带的接口
{
    public sealed class Person : IObserver<int>
    {
        private IDisposable _unsubscribe;

        /// <summary>
        /// 结束订阅
        /// </summary>
        public void OnCompleted()
        {
            _unsubscribe.Dispose();
        }
        
        /// <summary>
        /// 订阅主题
        /// </summary>
        /// <param name="provider"></param>
        public void Subscribe(IObservable<int> provider)
        {
            if (provider != null)
                _unsubscribe = provider.Subscribe(this);
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("The location cannot be determined.");
        }

        /// <summary>
        /// 主题变化时执行的方法
        /// </summary>
        /// <param name="value"></param>
        public void OnNext(int value)
        {
            Console.WriteLine(value);
            Console.WriteLine("人醒");
        }
    }
}