using System.Diagnostics.Metrics;

var inputOne = Console.ReadLine();
int x = int.Parse(inputOne) - 1;
var inputTwo = Console.ReadLine().Split();
double amount = 0;
double check = 0;
int counter = 0;
for (int i = 0; i < inputTwo.Length; i++)
{
	 amount = amount + int.Parse(inputTwo[i]);
}


var result = Math.Ceiling(amount/2);


if (inputTwo.Length == int.Parse(inputOne))
{
	bool y = inputTwo.All(c=> c == inputTwo[0]);
	if( y == true)
	{
		Console.WriteLine(inputOne);
	}
	else
	{
		for (int i = 0; i < inputTwo.Length; i++)
		{
          check = check + int.Parse(inputTwo[i]);
			while (check < result)
			{
				counter++;
				
			}
			while (check > result)
			{
				Console.WriteLine(counter);
				break;
			}
            }
      

    }
        

    }
