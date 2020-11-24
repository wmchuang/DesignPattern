using DesignPattern.结构型.外观模式.基本;

namespace DesignPattern.行为型.观察者模式.气象监测系统
{
    /// <summary>
    /// 主题实现
    /// </summary>
    public class WeatherData : Subject
    {
        public Data _data = new Data();

        public void Notify()
        {
            base.Notify(_data);
        }
    }
}