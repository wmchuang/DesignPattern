using System;

namespace DesignPattern.行为型.观察者模式.气象监测系统
{
    /// <summary>
    /// 抽象主题
    /// </summary>
    public abstract class Subject
    {
        public event Action<Data> Observers;

        public void RegisterObserver(IObserver observer)
        {
            Observers += observer.Update;
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers -= observer.Update;
        }

        protected void Notify(Data data)
        {
            Observers?.Invoke(data);
        }
    }
}