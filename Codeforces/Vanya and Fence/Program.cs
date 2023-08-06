var inputOne = Console.ReadLine().Split(" ");
var inputTwo = Console.ReadLine().Split(" ");
int counter = 0;

if(inputTwo.Length == int.Parse(inputOne[0]))
{
	foreach (var item in inputTwo)
	{
		if(int.Parse(item) > int.Parse(inputOne[1])) counter = counter + 2;
		else counter = counter + 1; 
	}
}
Console.WriteLine(counter);
    
