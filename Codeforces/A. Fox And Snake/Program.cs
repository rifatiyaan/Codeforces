var input = Console.ReadLine().Split(" ").ToList();
List<string> output = new List<string>();
for (int i = 1;i <= int.Parse(input[0]); i++)
{
    if (i % 2 != 0)
    {

        var result = string.Concat(Enumerable.Repeat("#", int.Parse(input[1])));

        output.Add(result);  
    }
    else if(i%2==0 && i%4!=0)
    {
        var result = Enumerable.Repeat(".", int.Parse(input[1])-1);
        var acctual = string.Concat(result)+"#";
        output.Add(acctual);
    }
    else if(i%2==0 && i % 4 == 0)
    {
        var result = Enumerable.Repeat(".", int.Parse(input[1])-1);
        var acctual ="#"+ string.Concat(result);
        output.Add(acctual);
    }
}
foreach (var item in output)
{
    Console.WriteLine(item);
}

