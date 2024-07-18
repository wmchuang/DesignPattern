namespace DesignPattern.结构型.适配器模式.类适配器模式.电压
{
    public class VoltageAdapter : Voltage220V, IVoltage5V
    {
        public int Output5V()
        {
            int srcV = Output220V();
            int dstV = srcV / 44;
            return dstV;
        }
    }
}