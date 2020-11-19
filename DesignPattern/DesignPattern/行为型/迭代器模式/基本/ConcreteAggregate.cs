using System.Linq;

namespace DesignPattern.行为型.迭代器模式.基本
{
    public class ConcreteAggregate : IAggregate
    {

        readonly int[] _collection;

        public ConcreteAggregate()
        {
            _collection = Enumerable.Range(1, 10).ToArray();
        }

        public ITerator GetIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Length
        {
            get { return _collection.Length; }
        }

        public int GetElement(int index)
        {
            return _collection[index];
        }
    }
}