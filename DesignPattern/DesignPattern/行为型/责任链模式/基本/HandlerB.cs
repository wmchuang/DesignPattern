namespace DesignPattern.行为型.责任链模式.基本
{
    public class HandlerB : Handler
    {

        public override string HandlerRequest(string str)
        {
            return SetSuccesrror($"B处理{str}");
        }
    }
}