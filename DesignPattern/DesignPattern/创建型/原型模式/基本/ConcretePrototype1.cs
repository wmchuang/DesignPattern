namespace DesignPattern.创建型.原型模式.基本
{
    public class ConcretePrototype1 : Prototype
    {

        public ConcretePrototype1(string id, int intId) : base(id, intId)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype) this.MemberwiseClone();
        }

    }
}