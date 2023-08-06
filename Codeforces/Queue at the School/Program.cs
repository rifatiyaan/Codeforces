var input = Console.ReadLine().Split();

var line = Console.ReadLine();
string[] result = new string[line.Length];

for(int i = 0;i < line.Length; i++)
{
    if (line[i] == 'B' && line[i+1] == 'G')
    {
        result[i] = "G";
        result[i + 1] = "B";
    }
    if (line[i] == 'B' && line[i + 1] == 'G')
    {
        result[i] = "G";
        result[i + 1] = "B";
    }

    else if (line[i] == 'B')
    {
        result[i] = "B";  
    }
 
    //else 
    //{
    //    result[i] = "B";
    //}
}
foreach (var item in result)
{
    Console.Write(item);
}