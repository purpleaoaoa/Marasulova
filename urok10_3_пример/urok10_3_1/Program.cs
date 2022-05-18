using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urok10_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 4];
            int minValue = -10;
            int maxValue = 10;
            FillMatrix(matrix, minValue, maxValue);
            PrintMatrix(matrix);
            FillMatrix(matrix);
            Console.WriteLine("Матрица 3 x 4: ");
            PrintMatrix(matrix);
            Console.WriteLine("введите номера столбцов для обмена (первый столбец - 0-й):");
            int col1 = int.Parse(Console.ReadLine());
            int col2 = int.Parse(Console.ReadLine());
            ChangeColumns(matrix, col1, col2);
            Console.WriteLine("The resulting matrix:");
            PrintMatrix(matrix);

            Console.ReadKey();
        }


        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }

        }

        private static void FillMatrix(int[,] matrix, int minValue = -10, int maxValue = 10)
        {
            Random rand = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(minValue, maxValue);
                }
            }

        }

        private static void ChangeColumns(int[,] matrix, int col1, int col2)
        {
            System.Diagnostics.Debug.Assert((col1 < matrix.GetLength(1)) && (col2 < matrix.GetLength(1)), "указанный номер столбца выходит за границы размерности массива!");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int temp = matrix[i, col1];
                matrix[i, col1] = matrix[i, col2];
                matrix[i, col2] = temp;

            }

        }
    }
}

