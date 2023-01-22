string input = Console.ReadLine();
int number = input.Distinct().Count();
string message = (number % 2 == 0) ? "CHAT WITH HER!" : "IGNORE HIM!";
Console.WriteLine(message);