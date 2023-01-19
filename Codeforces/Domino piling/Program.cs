string input = Console.ReadLine();
string[] inputArray = new string[2];
inputArray = input.Split(" ");
int tableArea = int.Parse(inputArray[0]) * int.Parse(inputArray[1]);
int numberOfDominos = tableArea / 2;
Console.WriteLine(numberOfDominos);