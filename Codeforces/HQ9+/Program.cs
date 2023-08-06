var input = Console.ReadLine();
string targetChar = "HQ9";
if (input != null) {

    string isFound = input.Any(targetChar.Contains) ? "YES" : "NO";
    
    Console.WriteLine(isFound);
    Console.ReadLine();

}
