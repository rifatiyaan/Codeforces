string input = Console.ReadLine();

string capital = input[0].ToString().ToUpper();
string x = input.Substring(1);

Console.WriteLine($"{capital}{x}");