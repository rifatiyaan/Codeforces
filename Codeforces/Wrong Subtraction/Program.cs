var input = Console.ReadLine().Split(" ");

int firstInput = int.Parse(input[0]);
int secondInput = int.Parse(input[1]);

for (int s = 0; s < secondInput; s++)
{
   firstInput = ((firstInput % 10) == 0)? firstInput / 10 : firstInput - 1;
}
Console.WriteLine(firstInput);
