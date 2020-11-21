using System;

namespace DesignPattern.行为型.解释器模式.基本
{
    public class NonterminalExpression : AbstractExpression
    {

        public override void Intesrpre(Context context)
        {
            Console.WriteLine("非终端解释器");
        }
    }
}