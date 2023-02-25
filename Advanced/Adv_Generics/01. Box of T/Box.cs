using System;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> data = new List<T>();

        private int count;
        public int Count { get { return this.count; } }

        public void Add(T input)
        {
            this.data.Add(input);
            count++;
        }
        public T Remove() 
        {
            count--;
            var rem = this.data.Last();
            this.data.RemoveAt(this.data.Count - 1);
            return rem;
        }
    }
}
