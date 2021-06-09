using System.Collections.Generic;

namespace BoxOfT
{
    public class BoxOfT<T>
    {
        private Stack<T> elements;

        public int Count { get { return this.elements.Count; } }

        public BoxOfT()
        {
            this.elements = new Stack<T>();
        }

        public void Add(T element)
        {
            this.elements.Push(element);
        }

        public T Remove()
        {
            var lastElement = this.elements.Peek();
            this.elements.Pop();

            return lastElement;
        }
    }
}
