using System.Collections;

namespace DesignPattern.行为型.迭代器模式.自带
{
    public class MyItrerator
    {
        public class Months : IEnumerable
        {
            private readonly string[] months = {"1月", "2月", "3月", "4月", "5月", "6月", "7月", "8月", "9月", "10月", "11月", "12月"};

            public IEnumerator GetEnumerator()
            {
                foreach (var t in months) yield return t;
            }
        }
    }
}