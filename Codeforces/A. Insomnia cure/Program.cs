int[] ints = new int[5];
for (int i = 0; i < ints.Length; i++)
{
    ints[i] = int.Parse(Console.ReadLine());
}
List<int> allNumbers = new List<int>();
for (int i = 1; i <= ints[4]; i++)
{
    var data1 = ints[0] * i;
    var data2 = ints[1] * i;
    var data3 = ints[2] * i;
    var data4 = ints[3] * i;
    allNumbers.AddRange(new List<int> { data1, data2, data3, data4 });
}
int dragons = allNumbers.Distinct().Count(x => x <= ints[4]);
Console.WriteLine(dragons);