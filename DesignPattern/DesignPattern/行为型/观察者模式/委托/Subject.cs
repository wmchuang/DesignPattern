using System;

namespace DesignPattern.行为型.观察者模式.委托
{
    public abstract class Subject
    {
        public event Action @event;
        
        public void Attach(IObserver observer)
        {
            @event += observer.Response;
        }
        
        public void Delete(IObserver observer)
        {
            @event -= observer.Response;
        }

        protected void Notify()
        {
            @event?.Invoke();
        }
    }
}