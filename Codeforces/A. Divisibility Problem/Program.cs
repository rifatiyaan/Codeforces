int input = int.Parse(Console.ReadLine());
List<int> results = new List<int>();

for (int i = 0; i < input; i++)
{
    var secondLine = Console.ReadLine().Split(" ");
    int dividend = int.Parse(secondLine[0]);
    int divisor = int.Parse(secondLine[1]);

    int counter = 0;

    if (dividend % divisor == 0)
    {
        results.Add(0);
    }
    else
    {
        counter = divisor - (dividend % divisor);
        results.Add(counter);
    }
}

foreach (var result in results)
{
    Console.WriteLine(result);
}



