int a = int.Parse(Console.ReadLine());
if (a >= 1 && a <= 100)
{
    for (int i = 0; i < a; i++)
    {
        string b = Console.ReadLine();
        int c = (b.Length);
        int d = c - 2;
        if (c >= 1 && c <= 100)
        {
            if (c <= 10)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(b[0] + "" + d + "" + b[c - 1]);
            }
        }
    }
}