using System;
int inputOne = int.Parse(Console.ReadLine());

int[] compare = new int[inputOne];
for (int i = 0;i < compare.Length; i++)
{
    compare[i] = i + 1;
}

string[] array = Console.ReadLine().Split(' ');
int[] array2 = new int[array.Length];

for (int i = 0; i < inputOne - 1; i++)
{
    array2[i] = int.Parse(array[i]);
}

int[] result = compare.Except(array2).ToArray();

foreach (var item in result)
{
    Console.Write(item);
}

