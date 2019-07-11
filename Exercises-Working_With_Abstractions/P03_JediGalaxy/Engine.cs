namespace P03_JediGalaxy
{
    using System;
    using System.Linq;


    public class Engine
    {
        private int[,] matrix;
        private long totalSum;

        public void Run()
        {
            int[] dimensions = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            InitializeMatrix(dimensions);

            string command = Console.ReadLine();

            while (command != "Let the Force be with you")
            {
                int[] ivosCoordinates = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int[] evilsCoordinates = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                MoveEvil(evilsCoordinates);

                MovePlayer(ivosCoordinates);

                command = Console.ReadLine();
            }
            Console.WriteLine(totalSum);
        }

        private void InitializeMatrix(int[] dimensions)
        {
            int rows = dimensions[0];
            int cols = dimensions[1];

            matrix = new int[rows, cols];

            int value = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = value++;
                }
            }
        }

        private void MovePlayer(int[] ivosCoordinates)
        {
            int ivosRow = ivosCoordinates[0];
            int ìvosCol = ivosCoordinates[1];

            while (ivosRow >= 0 && ìvosCol < matrix.GetLength(1))
            {
                if (ivosRow < matrix.GetLength(0) && ìvosCol >= 0)
                {
                    totalSum += matrix[ivosRow, ìvosCol];
                }

                ìvosCol++;
                ivosRow--;
            }
        }

        private void MoveEvil(int[] evilsCoordinates)
        {
            int evilsRow = evilsCoordinates[0];
            int evilsCol = evilsCoordinates[1];

            while (evilsRow >= 0 && evilsCol >= 0)
            {
                if (evilsRow < matrix.GetLength(0) && evilsCol < matrix.GetLength(1))
                {
                    matrix[evilsRow, evilsCol] = 0;
                }

                evilsRow--;
                evilsCol--;
            }
        }
    }
}
