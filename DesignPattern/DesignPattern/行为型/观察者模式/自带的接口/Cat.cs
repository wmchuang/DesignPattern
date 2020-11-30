using System;
using System.Collections.Generic;

namespace DesignPattern.行为型.观察者模式.自带的接口
{
    /// <summary>
    /// 主题
    /// </summary>
    public class Cat : IObservable<int>
    {
        private List<IObserver<int>> observers;

        public Cat(List<IObserver<int>> observers)
        {
            this.observers = observers;
        }

        public IDisposable Subscribe(IObserver<int> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }
        
        // TrackLocation 方法传递了一个包含纬度和经度数据的Location对象。 
        // 如果Location值不为null，则 TrackLocation 方法会调用每个观察程序的 OnNext 方法，
        // 否则调用OnError方法
        public void Cry(Nullable<int> loc)
        {
            Console.WriteLine("猫叫");
            foreach (var observer in observers)
            {
                if (!loc.HasValue)
                    observer.OnError(new Exception());
                else
                    observer.OnNext(loc.Value);
            }
        }
        
        // 用于取消订阅通知的IDisposable对象的实现
        private class Unsubscriber : IDisposable
        {
            private readonly List<IObserver<int>> _observers;
            private readonly IObserver<int> _observer;

            public Unsubscriber(List<IObserver<int>> observers, IObserver<int> observer)
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