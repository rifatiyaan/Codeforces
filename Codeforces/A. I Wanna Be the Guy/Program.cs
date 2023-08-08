int levels = int.Parse(Console.ReadLine());
var second = Console.ReadLine().Split(" ");
var third = Console.ReadLine().Split(" ");

HashSet<int> X= new HashSet<int>();
for (int s = 1; s < second.Length; s++)
{
    X.Add(int.Parse(second[s]));
}

HashSet<int> Y = new HashSet<int>();
for (int s = 1; s < third.Length; s++)
{
    X.Add(int.Parse(third[s]));
}
X.UnionWith(Y);
//List<int> result = X.ToList();
List<int> compare = new List<int>();
for (int i = 1; i <= levels; i++)
{
    compare.Add(i);
}
string output = X.OrderBy(item => item).SequenceEqual(compare.OrderBy(item => item)) ? "I become the guy." : "Oh, my keyboard!";
Console.WriteLine(output);

