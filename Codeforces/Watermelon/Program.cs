String input = Console.ReadLine();
int output;
Int32.TryParse(input, out output);

if (output >= 1 && output <= 100 && output % 2 == 0 && output != 2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("NO");
}

