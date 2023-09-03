int size = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] inputArr = input.Split(" ");
int[] numbers = Array.ConvertAll(inputArr, int.Parse);

if (numbers.Length == size)
{
    int maxValueIndex = Array.IndexOf(numbers, numbers.Max());
    int minValueIndex = Array.LastIndexOf(numbers, numbers.Min());
    int output = (minValueIndex < maxValueIndex)? 
        (((size - 1) - minValueIndex) + maxValueIndex) - 1
        : maxValueIndex + ((size - 1) - minValueIndex);
    Console.WriteLine(output);
}
