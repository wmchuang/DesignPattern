namespace DesignPattern.行为型.责任链模式.基本
{
    public class HandlerA : Handler
    {
        
        public override string HandlerRequest(string str)
        {
            this.NextHandler = new HandlerB();
            return str == "1" ? SetSuccesrror($"A处理{str}") : NextHandler.HandlerRequest(str);
        }
    }
}