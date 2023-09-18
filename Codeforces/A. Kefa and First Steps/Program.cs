int range = int.Parse(Console.ReadLine());
var input = Console.ReadLine().Split(" ");
List<int> numbers = new List<int>();
for (int i = 0; i < range; i++)
{
    numbers.Add(int.Parse(input[i]));
}
int maximumLength = 1;
int currentLength = 1;
for (int i = 1; i < (numbers.Count); i++)
{
    if ((numbers[i] >= numbers[i - 1]))
    {
        currentLength++;

        if (currentLength > maximumLength)
        {
            maximumLength = currentLength;
        }
    }
    else
    {
        currentLength = 1;
    }

}
Console.WriteLine(maximumLength);
