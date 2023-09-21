using System.Text;

var input = Console.ReadLine();

string a = "WUB";
string b = " ";

string[] result = input.Replace(a, b).Trim().
    Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
StringBuilder sb = new StringBuilder();
foreach(string s in result)
{
    sb.Append(s+" ");
}
Console.WriteLine(sb);