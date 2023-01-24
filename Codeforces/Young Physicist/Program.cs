using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows in the array: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns in the array: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] multiArray = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("Enter the value for element [{0},{1}]: ", i, j);
                multiArray[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Multidimensional Array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(multiArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

