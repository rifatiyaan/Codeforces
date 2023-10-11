int input = int.Parse(Console.ReadLine());

var secondLine = Console.ReadLine().Split(" ").ToList();

int x = secondLine.Where(x => int.Parse(x) % 2 == 0).Count();
int y = secondLine.Where(x => int.Parse(x) % 2 != 0).Count();

if(x == 1)
{
    Console.WriteLine(secondLine.IndexOf(secondLine.Single(x=>int.Parse(x) % 2 == 0))+1);
}
else
{
    Console.WriteLine(secondLine.IndexOf(secondLine.Single(x => int.Parse(x) % 2 != 0))+1);
}