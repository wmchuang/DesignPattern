namespace DesignPattern.行为型.策略模式.所得税
{
    public class InterestOperation
    {
        private ITaxStragety _strategy;

        public void SetStragety(ITaxStragety strategy)
        {
            _strategy = strategy;
        }

        public double GetTax(double income)
        {
            return _strategy?.CalculateTax(income) ?? 0;
        }
    }
}