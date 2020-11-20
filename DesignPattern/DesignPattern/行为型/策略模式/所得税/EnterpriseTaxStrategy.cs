namespace DesignPattern.行为型.策略模式.所得税
{
    public class EnterpriseTaxStrategy : ITaxStragety
    {

        public double CalculateTax(double income)
        {
            return (income - 3500) > 0 ? (income - 3500) * 0.045 : 0.0;
        }
    }
}