var x = int.Parse(Console.ReadLine());
var inputs = Console.ReadLine().Split(" ");
double counter = 0;
if(inputs.Length == x)
{
	foreach (var item in inputs)
	{
		counter += int.Parse(item);
	}
}
Console.WriteLine(Math.Ceiling(counter/4));