string input = Console.ReadLine();
string inputTwo = Console.ReadLine();
string result = new string(input.Reverse().ToArray());
string answer = (inputTwo == result) ? "YES" : "NO";

Console.WriteLine(answer);