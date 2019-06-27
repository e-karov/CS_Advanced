using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethod
{
    public class Box<T>
        where T : IComparable<T>
    {
        private List<T> boxItems = new List<T>();

        public Box()
        {
            this.boxItems = new List<T>();

        }

        public void Add(T item)
        {
            boxItems.Add(item);
        }

        public int CompareItems(T item)
        {
            int count = 0;
            foreach (var element in this.boxItems)
            {
                if (element.CompareTo(item) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in boxItems)
            {
                sb.AppendLine($"{item.GetType().FullName}; {item}");
            }

            return sb.ToString();
        }

    }
}
