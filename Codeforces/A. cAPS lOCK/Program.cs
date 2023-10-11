using System.Linq;

string message = Console.ReadLine();
bool option1 = message.All(x=> char.IsUpper(x));
if (option1)
{
    var result = message.ToLower();
    Console.WriteLine(result);
}
else{

    string first = message[0].ToString();
    var others = message.Substring(1);
    bool option2 = others.Where(x => char.IsLower(x)).Any();


    if (message != string.Empty && !option2)
    {
        var result = first.ToUpper() + others.ToLower();
        Console.Write(result);
    }
    else
    {
        Console.WriteLine(message);
    }
}