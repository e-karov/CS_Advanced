namespace Pascal_Triangle                       // 100 / 100
{
    using System;
    using System.Linq;


    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            long[][] triangle = new long[n][];
            int cols = 1;

            for (int row = 0; row < n; row++)
            {

                triangle[row] = new long[cols];
                triangle[row][0] = 1;
                triangle[row][cols - 1] = 1;

                if (cols > 2)
                {
                    long[] previousRow = triangle[row-1];

                    for (int col = 1; col < triangle[row].Length - 1; col++)
                    {
                        triangle[row][col] = (triangle[row - 1][col - 1]) + (triangle[row - 1][col]);
                    }
                }
                cols++;
            }

            foreach (var row in triangle)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}
