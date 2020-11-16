using System;

namespace DesignPattern.结构型.适配器模式.类适配器模式.电源插头
{
    /// <summary>
    /// 三个孔的插头，目标角色
    /// </summary>
    public interface IThreeHole
    {
        void Request();
    }

    public abstract class TwoHole
    {
        protected void SpecificeRequest()
        {
            Console.WriteLine("我是俩个孔的插头");
        }
    }

    /// <summary>
    /// 适配器类
    /// </summary>
    public class PowerAdapter : TwoHole, IThreeHole
    {
        public void Request()
        {
            SpecificeRequest();
        }
    }

}