using DesignPattern.行为型.责任链模式.采购;

namespace DesignPattern.行为型
{
    /// <summary>
    /// 行为型
    /// 用户描述对类或对象怎样交互和怎样分配职责
    /// </summary>
    public  class BehavioralType
    {
        public static void Run()
        {
            ChainOfResponsibility();
        }

        /// <summary>
        /// 责任链模式
        /// 使多个对象都有机会处理请求，从而避免请求的发送者和接收者之间的耦合关系
        /// 将这些对象连成一条链，并沿着这条链传递该请求，直到有一个对象处理它为止。
        /// </summary>
        private static void ChainOfResponsibility()
        {
          
            {
                var requestTelphone = new PurchaseRequest(4000.0, "Telphone");
                var requestSoftware = new PurchaseRequest(10000.0, "Visual Studio");
                var requestComputers = new PurchaseRequest(40000.0, "Computers");
                Approver manager = new Manager("LearningHard");


                // 处理请求
                manager.ProcessRequest(requestTelphone);
                manager.ProcessRequest(requestSoftware);
                manager.ProcessRequest(requestComputers);
            }
        }
    }
}