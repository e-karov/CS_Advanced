using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T>
    {
        private List<T> boxCollection;

        public Box()
        {
            this.boxCollection = new List<T>();
        }

        public void Add(T item)
        {
            this.boxCollection.Add(item);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T temp = boxCollection[firstIndex];
            boxCollection[firstIndex] = boxCollection[secondIndex];
            boxCollection[secondIndex] = temp;
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            foreach (var text in boxCollection)
            {
                sb.AppendLine($"{text.GetType().FullName}: {text}");
            }

            return sb.ToString();
        }
    }
}
