var input =int.Parse(Console.ReadLine());

IEnumerable<int> num = Enumerable.Range(1,input);
long pos = num.Where(x => x %2 == 0).Sum();
long neg = num.Where(x => x %2 != 0).Sum();
long output = pos - neg;
Console.WriteLine(output);

