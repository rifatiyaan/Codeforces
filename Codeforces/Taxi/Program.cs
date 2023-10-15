int input = int.Parse(Console.ReadLine());

List<int> numbers = new List<int>(input);

int output = 0;
   numbers.AddRange(Console.ReadLine().Split(" ").ToList().Select(int.Parse).ToList());
int one = 0; int two = 0; int three = 0; int four = 0;
for (int i = 0; i < numbers.Count; i++)
{
    switch (numbers[i])
    {
            case 1: one++;   break;
            case 2:  two++;   break;
            case 3: three++; break;
            case 4: four++;  break;
    }
}
//Console.WriteLine($"{one} {two} {three} {four}");

int restOne = 0;
int restTwo = 0;
int restThree = 0;



 if (two == 0 && three == 0 && four == 0)
{
    output += (one / 4) + (one % 4);
    if (three == 0 && four == 0)
    {
        output += 1;
    }
}
else
{
    output += four;
    if (one == three)
    {
        output += three;
        if (two % 2 == 0)
        {
            output += two / 2;
        }
        else if (two % 2 != 0)
        {
            output += two / 2;
            restTwo = two - two % 2;
            if (restTwo == one - three)
            {
                output += restTwo;
            }
        }
    }
    else
    {
        if (one > three)
        {
            restOne += one - three;
            if (restOne / 2 > two)
            {
                output += two;
                int rest = restOne / 2 - two;
                output += rest;
            }
            else if (restOne == 0)
            {
                output += two;
            }
            else if (two > (restOne / 2))
            {
                int restTwoo = two - restOne / 2;
                output += two;
                output += restTwoo;
            }
        }
        else if (three > one)
        {
            restThree += three - one;
            output += restThree;
            output += three;
        }
    }
}
Console.WriteLine(output);

