namespace DesignPattern.行为型.解释器模式.基本
{
    /// <summary>
    /// 抽象表达式
    /// 抽象表达式是生成语法集合（语法树）的关键，每个语法结合完成指定语法解析任务，它是通过递归调用的方式，最终由最小的语法单元进行解析完成
    /// </summary>
    public abstract class AbstractExpression
    {
        public abstract void Intesrpre(Context context);
    }
}