var firstLine = Console.ReadLine();
var lastLine = Console.ReadLine();
Console.WriteLine(CompareStrings(lastLine, firstLine));
int CompareStrings(string a, string b)
      { 
            int result = String.Compare(firstLine, lastLine, StringComparison.OrdinalIgnoreCase);
    if(result == 0)
    {
        return 0;
    }
    else if(result > 0)
    {
        return 1;
    }
    return -1;
      }

