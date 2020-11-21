using System;

namespace DesignPattern.行为型.模板方法模式.炒菜
{
    /// <summary>
    /// 菠菜
    /// </summary>
    public class Spinach : Vegetabel
    {

        protected override void PourVetetable()
        {
            Console.WriteLine("倒菠菜");
        }
    }
}