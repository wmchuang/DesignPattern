namespace DesignPattern.结构型.适配器模式.对象适配器模式.电压
{
    public class VoltageAdapter : IVoltage5V
    {
        private Voltage220V voltage220V;
        //构造器
        public VoltageAdapter(Voltage220V voltage220v) {
            this.voltage220V = voltage220v;
        }
        
        public int Output5V()
        {
           	int dst = 0;
            if(null != voltage220V) {
                int src = voltage220V.Output220V();//获取220v电压
                dst = src / 44;
            }
            return dst;
        }
    }
}