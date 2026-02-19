using System;

namespace ArrayTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------ Part 1 ------------------------
            int[] numbers = new int[5];
            int sum = 0;

            Console.WriteLine("Enter 5 integers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine($"\nSum = {sum}");
            Console.WriteLine($"Average = {average}");

            // ------------------------ Separator ------------------------
            Console.WriteLine("\n------------------------------------\n");

            // ------------------------ Part 2 ------------------------
            int[,] matrix = new int[3, 3];

            Console.WriteLine("Enter 9 numbers to fill a 3x3 matrix:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // ------------------------ Separator ------------------------
            Console.WriteLine("\n------------------------------------\n");

            // ------------------------ Part 3 ------------------------
            int[,] arr2D = new int[2, 3];
            Console.WriteLine("Enter 6 numbers to fill a 2x3 array:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    arr2D[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nTrying to sort 2D array directly...");
            try
            {
                Array.Sort(arr2D); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Cannot sort a multidimensional array directly!");
                Console.WriteLine($"Exception message: {ex.Message}");
            }

            int[] flatArray = new int[arr2D.Length];
            int index = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    flatArray[index++] = arr2D[i, j];
                }
            }

            Array.Sort(flatArray);

            Console.WriteLine("\nSorted 1D Array:");
            foreach (int num in flatArray)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\n\nProgram finished successfully!");
        }
    }
}
