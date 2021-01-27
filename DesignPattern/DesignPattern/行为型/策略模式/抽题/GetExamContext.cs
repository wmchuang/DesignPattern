using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.行为型.策略模式.抽题
{
    public class GetExamContext
    {
        private readonly Queue<IGetExamStrategy> _getExamQueue = new Queue<IGetExamStrategy>();
        private readonly int _count;

        public GetExamContext(int count)
        {
            _count = count;
        }


        public void AddStrategy(IGetExamStrategy getExam)
        {
            _getExamQueue.Enqueue(getExam);
        }


        public void GetExam()
        {
            var list = new List<int>();
            foreach (var item in _getExamQueue.Where(item => list.Count < _count))
            {
                list.AddRange(item.GetExam(_count).Take(_count - list.Count));
            }
            
            list.ForEach(Console.WriteLine);
        }

    }
}