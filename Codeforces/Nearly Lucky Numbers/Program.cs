var input = Console.ReadLine();
if (input != null && long.Parse(input) > 0)
{
  int counter = 0;
    int digitOne = 4;
    int digitTwo = 7;   
    

    foreach (var c in input)
    {
        if(c == digitOne.ToString()[0] || c == digitTwo.ToString()[0])
        {
            counter++;
        }
    }
    if (counter == 4 || counter == 7) Console.WriteLine("YES");
    else Console.WriteLine("NO");
     
}