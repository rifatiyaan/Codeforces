string a = Console.ReadLine();

int up= 0;
int down= 0;

foreach (var item in a)
{
    if (Char.IsUpper(item))
    {
        up++;
    }
    if (char.IsLower(item))
    {
        down++;
    }
}
string result = (up > down) ? $"{a.ToUpper()}" : $"{a.ToLower()}";
Console.WriteLine(result);