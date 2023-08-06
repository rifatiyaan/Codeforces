int input =int.Parse(Console.ReadLine());
string odd = "I hate that";
string even = "I love that";
string result = "";
 if (input % 2 != 0)
{
    for (int i = 0; i < (input - 1) / 2; i++)
    {
        result += (odd + " " + even + " ");
    }
    Console.WriteLine(result + "I hate it");
}
else if (input % 2 == 0)
{
    for (int i = 0; i < input/2; i++)
    {
        result += (odd + " " + even + " ");
    }
    string anotherResult = result.Substring(0, result.Length - 5);
    Console.WriteLine(anotherResult+"it");
}