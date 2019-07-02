using System;
using System.Collections.Generic;
using System.Linq;

namespace Spaceshift_Crafting                               // 100 / 100
{
    public class StartUp
    {
        static void Main()
        {
            int[] chemicalLiquids = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] physicalItems = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> liquids = new Queue<int>(chemicalLiquids);

            List<int> items = new List<int>(physicalItems);

            Dictionary<string, int> materials = new Dictionary<string, int>();
            materials.Add("Glass", 0);
            materials.Add("Aluminium", 0);
            materials.Add("Lithium", 0);
            materials.Add("Carbon fiber", 0);

            while (liquids.Count != 0 && items.Count != 0)
            {
                int currentLiquid = liquids.Dequeue();
                int currentItem = items[items.Count - 1];

                if (currentLiquid + currentItem == 25)
                {
                    items.Remove(currentItem);

                    materials["Glass"] += 1;
                }

                else if (currentLiquid + currentItem == 50)
                {
                    items.Remove(currentItem);

                    materials["Aluminium"] += 1;
                }

                else if (currentLiquid + currentItem == 75)
                {
                    items.Remove(currentItem);

                    materials["Lithium"] += 1;
                }

                else if (currentLiquid + currentItem == 100)
                {
                    items.Remove(currentItem);

                    materials["Carbon fiber"] += 1;
                }

                else
                {
                    items[items.Count - 1] += 3;
                }
            }

            bool areAllMaterials = materials["Glass"] > 0 && materials["Aluminium"] > 0 
                && materials["Lithium"] > 0 && materials["Carbon fiber"] > 0;

            if (areAllMaterials)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }

            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (liquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {String.Join(", ", liquids)}");
            }

            if (items.Count == 0)
            {
                Console.WriteLine("Physical items left: none");
            }

            else
            {
                items.Reverse();
                Console.WriteLine($"Physical items left: {String.Join(", ", items)}");
            }

            foreach (var material in materials.OrderBy(m => m.Key))
            {
                Console.WriteLine($"{material.Key}: { material.Value}");
            }
        }
    }
}
