int input = int.Parse(Console.ReadLine());

string score = Console.ReadLine();

if (score.Length == input)
{
    int counterOne = 0;
    int counterTwo = 0;
    foreach (Char C in score)
    {
        if (C == 'A')
        {
            counterOne++;
        }
        if (C == 'D')
        {
            counterTwo++;
        }
    }
    
    string result = counterOne > counterTwo ? "Anton" : "Danik";
    string tie = counterOne == counterTwo ? "Friendship":result;
    Console.WriteLine(tie);
    
}

