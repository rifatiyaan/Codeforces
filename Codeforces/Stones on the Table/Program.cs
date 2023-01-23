int input = int.Parse(Console.ReadLine());
int counter = 0;
string line = Console.ReadLine();
while (line.Length == input)
{ 
	for (int i = 0; i < input - 1; i++)
	{
		if (line[i] == line[i + 1])
		{
			counter++;
		}
	}
	break;
}
Console.WriteLine(counter);