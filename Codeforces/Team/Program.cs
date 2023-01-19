int a = int.Parse(Console.ReadLine());
int totalSolve = 0;
for (int i = 0; i < a; i++)
{
    String[] input = Console.ReadLine().Split();
    if (int.Parse(input[0]) == 0 || int.Parse(input[0]) == 1 ||
        int.Parse(input[1]) == 0 || int.Parse(input[1]) == 1 ||
        int.Parse(input[2]) == 0 || int.Parse(input[2]) == 1)
    {

        int x = int.Parse(input[0]) + int.Parse(input[1]) + int.Parse(input[2]);

        if (x >= 2)
        {
            totalSolve++;
        }
    }
}
Console.WriteLine(totalSolve);