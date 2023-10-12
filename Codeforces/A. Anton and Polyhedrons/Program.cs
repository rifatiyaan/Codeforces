using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int temp = 0;

        for (int i = 0; i < input; i++)
        {
            string shape = Console.ReadLine();

            switch (shape)
            {
                case "Tetrahedron":
                    temp += 4;
                    break;
                case "Cube":
                    temp += 6;
                    break;
                case "Octahedron":
                    temp += 8;
                    break;
                case "Dodecahedron":
                    temp += 12;
                    break;
                case "Icosahedron":
                    temp += 20;
                    break;
            }
        }

        Console.WriteLine(temp);
    }
}




