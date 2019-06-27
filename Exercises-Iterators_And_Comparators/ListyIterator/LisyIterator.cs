using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> items;

        private int currentIndex;

        public ListyIterator(List<T> list)
        {
            this.items = list;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var currentItem in this.items)
            {
                yield return currentItem;
            }
        }

        public bool HasNext()
        {
            return this.currentIndex < this.items.Count - 1;
        }

        public bool Move()
        {
            bool IsMoved = false;

            if (HasNext())
            {
                this.currentIndex++;
                IsMoved = true;
            }
            return IsMoved;
        }

        public void Print()
        {
           
            if (this. items.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            else
            {
                Console.WriteLine(items[currentIndex]);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
