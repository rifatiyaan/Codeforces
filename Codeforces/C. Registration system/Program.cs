int input = int.Parse(Console.ReadLine());
Dictionary<string, int> frequency = new Dictionary<string, int>();
List<string> result = new List<string>();

for (int i = 0; i < input; i++)
{
    string line = Console.ReadLine();

    if (frequency.TryGetValue(line, out int count))
    {
        frequency[line] = count + 1;
        result.Add($"{line}{count}");
    }
    else
    {
        frequency[line] = 1;
        result.Add("OK");
    }
}

foreach (var item in result)
{
    Console.WriteLine(item);
}