using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> innerList;


        public CustomStack()
        {
            this.innerList = new List<T>();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = innerList.Count - 1; i >= 0; i--)
            {
                yield return innerList[i];
            }
        }

        public void Push(T element)
        {
            this.innerList.Add(element);
        }

        public T Pop()
        {
            T currentItem = innerList[innerList.Count - 1];
            innerList.Remove(currentItem);
            return currentItem;

        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
