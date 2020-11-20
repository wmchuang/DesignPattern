namespace DesignPattern.行为型.策略模式.基本
{
    public class Context
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void AlgorithmInvoker()
        {
            _strategy?.Algorithm();
        }
    }
}