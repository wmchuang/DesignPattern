namespace DesignPattern.结构型.桥接模式.饮品店
{
    public abstract class Coffee
    {
        protected IMakeCoffee _makeCoffee;

        protected Coffee(IMakeCoffee makeCoffee)
        {
            _makeCoffee = makeCoffee;
        }

        public void SetCoffee(IMakeCoffee makeCoffee)
        {
            _makeCoffee = makeCoffee;
        }

        public abstract void Make();
    }
}