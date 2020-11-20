using System.Collections.Generic;

namespace DesignPattern.行为型.观察者模式.猫叫老鼠逃
{
    public abstract class Subject
    {
        /// <summary>
        /// 保存订阅者列表
        /// </summary>
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }
        
        public void Delete(IObserver observer)
        {
            _observers.Remove(observer);
        }
        
        public void Notify()
        {
            _observers.ForEach(item =>
            {
                item.Response();
            });
        }
    }
}