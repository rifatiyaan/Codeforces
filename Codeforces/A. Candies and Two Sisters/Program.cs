int input = int.Parse(Console.ReadLine());

List<int> output = new List<int>();

for (int i = 0; i < input ; i++)
{
    output.Add( int.Parse(Console.ReadLine()));
}
for (int i = 0; i < output.Count; i++)
{
    if (output[i] == 1 || output[i] == 2)
    {
        Console.WriteLine(0);
    }
    else if (output[i] % 2 == 0)
    {
        Console.WriteLine((output[i]-2)/2);
    }
    else
    {
        Console.WriteLine((output[i]-1)/2);
    }
}