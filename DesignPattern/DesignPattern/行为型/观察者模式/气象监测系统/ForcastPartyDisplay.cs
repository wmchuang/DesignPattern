using System;

namespace DesignPattern.行为型.观察者模式.气象监测系统
{
    public class ForcastPartyDisplay : IObserver,IDisplay
    {
        private Data _data = new Data();
        public void Update(Data data)
        {
            _data.Hum = data.Hum;
            _data.Tempoerature = data.Tempoerature;
        }

        public void Display()
        {
            Console.WriteLine($"气象站2温度{_data.Tempoerature},湿度：{_data.Hum}");
        }
    }
}