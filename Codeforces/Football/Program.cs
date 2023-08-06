var input = Console.ReadLine();

string zeros = "0000000";
string ones = "1111111";

bool resultOne = input.Contains(zeros) ? true: false;
bool resulTwo = input.Contains(ones) ? true: false;
string result = ((resultOne || resulTwo) == true) ? "YES" : "NO";
Console.WriteLine(result);
