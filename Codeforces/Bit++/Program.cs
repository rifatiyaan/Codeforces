int input = int.Parse(Console.ReadLine());
string[] arrayOne = new string[input];
int x = 0;
for (int i = 0; i < arrayOne.Length; i++)
{
    arrayOne[i] = Console.ReadLine();
    if (arrayOne[i] == "++X" || arrayOne[i] == "X++" || arrayOne[i] == "++x" || arrayOne[i] == "x++")
    {
        x++;

    }
    if (arrayOne[i] == "--X" || arrayOne[i] == "X--" || arrayOne[i] == "--x" || arrayOne[i] == "x--")
    {
        x--;
    }

}
Console.WriteLine(x);
