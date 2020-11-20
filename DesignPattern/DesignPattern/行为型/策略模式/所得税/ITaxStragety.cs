namespace DesignPattern.行为型.策略模式.所得税
{
    /// <summary>
    /// 所得税计算策略
    /// </summary>
    public interface ITaxStragety
    {
        double CalculateTax(double income);
    }
}