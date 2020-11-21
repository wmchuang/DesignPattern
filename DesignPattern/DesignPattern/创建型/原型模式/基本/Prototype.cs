namespace DesignPattern.创建型.原型模式.基本
{
    public abstract class Prototype
    {
        protected Prototype(string id,int intId)
        {
            Id = id;
            IntId = intId;
        }

        public string Id { get; set; }

        public int IntId{ get; set; }
        
        public abstract Prototype Clone();
    }
}