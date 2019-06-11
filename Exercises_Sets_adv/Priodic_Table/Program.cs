namespace Priodic_Table             // 100 / 100 
{
    using System;
    using System.Collections.Generic;

    public  class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] currentElements = Console.ReadLine()
                    .Split();
                for (int k = 0; k < currentElements.Length; k++)
                {
                    elements.Add(currentElements[k]);
                }
            }

            foreach (var element in elements)
            {
                Console.Write(element + " ");
            }
        }
    }
}
