using System.Text.RegularExpressions;

var input = int.Parse(Console.ReadLine());
string pattern = "^[4,7]+$"; 

if (input % 4 == 0 || input % 7 == 0 || input % 47 == 0 || input % 74 == 0)
{
    Console.WriteLine("YES");
}
else if (Regex.IsMatch(input.ToString(), pattern))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
