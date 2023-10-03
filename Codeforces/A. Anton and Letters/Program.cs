using System.Text;
var input = Console.ReadLine().Split(", ");
string sb = string.Empty;
for (int i = 0;i < input.Length; i++)
{
    sb += input[i];
}
var result = sb.TrimStart('{').TrimEnd('}').ToList();
var output = result.Distinct();
Console.WriteLine(output.Count());