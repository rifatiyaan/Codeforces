var input = Console.ReadLine();

var secondInput = Console.ReadLine().Split(' ');

if(secondInput.Length == int.Parse(input))
{
    string answer = secondInput.Contains("1") ? "HARD" : "EASY";
    Console.WriteLine(answer);
}