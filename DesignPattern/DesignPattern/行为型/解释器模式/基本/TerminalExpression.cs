using System;

namespace DesignPattern.行为型.解释器模式.基本
{
    public class TerminalExpression : AbstractExpression
    {

        public override void Intesrpre(Context context)
        {
            Console.WriteLine("终端解释器");
        }
    }
}