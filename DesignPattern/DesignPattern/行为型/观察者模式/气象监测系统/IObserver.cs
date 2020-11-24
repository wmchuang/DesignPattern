namespace DesignPattern.行为型.观察者模式.气象监测系统
{
    /// <summary>
    /// 观察者接口
    /// </summary>
    public interface IObserver
    {
        public void Update(Data data);
    }
    
    
    public interface IDisplay
    {
        public void Display();
    }
}