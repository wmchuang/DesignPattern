namespace DesignPattern.创建型.工厂模式.基本
{
    public class BFactory : IFactory
    {

        public IProduct CreateProduct()
        {
            return new ProductB();
        }
    }
}