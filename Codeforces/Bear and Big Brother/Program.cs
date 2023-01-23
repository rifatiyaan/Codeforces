string[] inputs = Console.ReadLine().Split();
int limak = int.Parse(inputs[0]);
int bob =int.Parse(inputs[1]);
int counter = 0;
for (int i = 1; i < 1000; i++)
{
    while (bob >= limak)
    {
        limak = i*limak*3;
        bob = i*bob*2;
        counter++;
    }
}
Console.WriteLine(counter);