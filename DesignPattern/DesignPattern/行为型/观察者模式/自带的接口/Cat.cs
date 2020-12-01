using System;
using System.Collections.Generic;

namespace DesignPattern.行为型.观察者模式.自带的接口
{
    /// <summary>
    /// 主题
    /// </summary>
    public class Cat : IObservable<int>
    {
        /// <summary>
        /// 被订阅的观察者集合
        /// </summary>
        private List<IObserver<int>> observers;

        public Cat(List<IObserver<int>> observers)
        {
            this.observers = observers;
        }

        /// <summary>
        /// 被订阅
        /// </summary>
        /// <param name="observer"></param>
        /// <returns></returns>
        public IDisposable Subscribe(IObserver<int> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new UnSubscriber(observers, observer);
        }
        
        // TrackLocation 方法传递了一个包含纬度和经度数据的Location对象。 
        // 如果Location值不为null，则 TrackLocation 方法会调用每个观察程序的 OnNext 方法，
        // 否则调用OnError方法
        public void Cry(Nullable<int> value)
        {
            Console.WriteLine("猫叫");
            foreach (var observer in observers)
            {
                if (!value.HasValue)
                    observer.OnError(new Exception());
                else
                    observer.OnNext(value.Value);
            }
        }
        
        
        /// <summary>
        /// 内部类
        /// 用于取消订阅通知的IDisposable对象的实现
        /// </summary>
        private class UnSubscriber : IDisposable
        {
            private readonly List<IObserver<int>> _observers;
            private readonly IObserver<int> _observer;

            public UnSubscriber(List<IObserver<int>> observers, IObserver<int> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
    }
}