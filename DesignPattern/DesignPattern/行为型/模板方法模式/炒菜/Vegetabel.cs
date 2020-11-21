using System;

namespace DesignPattern.行为型.模板方法模式.炒菜
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Vegetabel
    {

        // 模板方法，不要把模版方法定义为Virtual或abstract方法，避免被子类重写，防止更改流程的执行顺序
        public void CookVegetabel()
        {
            Console.WriteLine("抄蔬菜的一般做法");
            this.PourOil();
            this.HeatOil();
            this.PourVetetable();
            this.StirFry();
        }

        protected virtual void PourOil()
        {
            Console.WriteLine("倒油");
        }

        protected virtual void HeatOil()
        {
            Console.WriteLine("把油烧热");
        }

        /// <summary>
        /// 油热了之后倒蔬菜下去，具体哪种蔬菜由子类决定
        /// </summary>
        protected abstract void PourVetetable();

        protected virtual void StirFry()
        {
            Console.WriteLine("翻炒");
        }
    }
}