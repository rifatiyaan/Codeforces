int input = int.Parse(Console.ReadLine());

string[,] numbers = new string[input,2];

for(int i = 0; i < input; i++)
{
    string inputLine = Console.ReadLine();
    string[] parts = inputLine.Split(' ');

    if(parts.Length== 2 )
    {
        numbers[i,0] = parts[0];
        numbers[i,1] = parts[1];
    }
}
//5

//10 4    0,0  0,1
//13 9    1,0  1,1
//100 13  2,0  2,1
//123 456 3,0  3,1
//92 46   4,0  4,1

int counter = 0;

//if (int.Parse(numbers[input - 1, 0]) % int.Parse(numbers[input-1, 1]) == 0)
//{
//    Console.WriteLine("0");
//}
//else
//{

//}
int rows = numbers.GetLength(0);
int cols = numbers.GetLength(1);
Console.WriteLine(rows);
Console.WriteLine(cols);

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {

    }
}


