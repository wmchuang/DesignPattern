namespace DesignPattern.创建型.工厂模式.基本
{
    public class AFactory : IFactory
    {

        public IProduct CreateProdcut()
        {
            return new ProductA();
        }
    }
}