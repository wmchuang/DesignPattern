namespace DesignPattern.结构型.桥接模式.饮品店
{
    public abstract class Coffee
    {
        protected IMakeCoffee MakeCoffee;

        protected Coffee(IMakeCoffee makeCoffee)
        {
            MakeCoffee = makeCoffee;
        }

        public void SetCoffee(IMakeCoffee makeCoffee)
        {
            MakeCoffee = makeCoffee;
        }

        public abstract void Make();
    }
}