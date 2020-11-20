namespace DesignPattern.行为型.策略模式.所得税
{
    public class PersonalTaxStrategy : ITaxStragety
    {

        public double CalculateTax(double income)
        {
            return income * 0.12;
        }
    }
}