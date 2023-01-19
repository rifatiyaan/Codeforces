string a = Console.ReadLine();
string[] b = new string[2];
b = a.Split(" ");
int n = int.Parse(b[0]);
int k = int.Parse(b[1]);

string d = Console.ReadLine();
string[] e = new string[n];
e = d.Split(" ");
int value = 0;


bool res = e.AsQueryable().All(val => int.Parse(val) == 0);
if (res == false)
{
    for (int i = 0; i < e.Length; i++)
    {
        if (int.Parse(e[i]) >= int.Parse(e[k - 1]) && int.Parse(e[i]) != 0)
        {
            value++;
        }
    }
    Console.WriteLine(value);
}
else
{
    Console.WriteLine("0");
}

