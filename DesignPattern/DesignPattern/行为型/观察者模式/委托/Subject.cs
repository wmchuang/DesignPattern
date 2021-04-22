using System;

namespace DesignPattern.行为型.观察者模式.委托
{
    public abstract class Subject
    {
        private event Action Event;
        
        public void Attach(IObserver observer)
        {
            Event += observer.Response;
        }
        
        public void Delete(IObserver observer)
        {
            Event -= observer.Response;
        }

        protected void Notify()
        {
            Event?.Invoke();
        }
    }
}