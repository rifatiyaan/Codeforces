string[] inputs = Console.ReadLine().Split();
int k = int.Parse(inputs[0]);
int n = int.Parse(inputs[1]);
int w = int.Parse(inputs[2]);
int counter = 0;
for (int i = 1; i <= w; i++)
{
    int sum = k * i;
    counter += sum;   
}
string result = counter - n < 0 ? "0" : $"{counter - n}";
Console.WriteLine(result);
