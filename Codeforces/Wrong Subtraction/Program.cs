using System.Collections.Generic;

var input = Console.ReadLine().Split(" ");
string[] array = input;


foreach (var item in array)
{
    int first = int.Parse(array[0]);
    int second = int.Parse(array[1]);
    if (first > 0 && first % 10 != 0)
	{
        first--;
    }
	first= first / 10;
    Console.WriteLine(first);
}
