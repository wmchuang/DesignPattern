using System;

namespace DesignPattern.行为型.模板方法模式.炒菜
{
    public class ChineseCabbage : Vegetabel
    {

        protected override void PourOil()
        {
            Console.WriteLine("倒橄榄油");
        }

        

        protected override void PourVetetable()
        {
            Console.WriteLine("倒大白菜");
        }
    }
}