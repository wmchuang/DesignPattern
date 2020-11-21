using DesignPattern.创建型.原型模式.基本;

namespace DesignPattern.行为型.中介者模式.基本
{
    /// <summary>
    /// 抽象中介者角色
    /// </summary>
    public abstract class Mediator
    {
        protected Mediator(ColleagueA a, ColleagueB b)
        {
            this.a = a;
            this.b = b;
        }

        protected ColleagueA a { get; set; }
        protected ColleagueB b { get; set; }

        public abstract void Send(string message,Colleague colleague);
    }
}