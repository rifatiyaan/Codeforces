int input = int.Parse(Console.ReadLine());
var drinks = Console.ReadLine().Split(" ");
float sum = 0;
if (drinks.Length == input)
{
	for (int i = 0; i < drinks.Length; i++)
	{
		int a = int.Parse(drinks[i]);
		sum += (a);
	}	
}
Console.WriteLine((sum)/input);






