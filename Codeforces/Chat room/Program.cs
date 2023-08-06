using System.Text.RegularExpressions;

var input = Console.ReadLine();

string pattern = "h.*e.*l.*l.*o";

string result = Regex.IsMatch(input, pattern) ? "YES" : "NO";
Console.WriteLine(result);

