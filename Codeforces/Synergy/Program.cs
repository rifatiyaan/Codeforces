class Program
{
    static void Main(string[] args)
    {
        int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int num = 4;
       foreach(int i in ShowArray(number,num))
        { 
            Console.Write(i+" ");
        }
    }
   static int[] ShowArray(int[] ints,int k)
    {
        List<int> list = new List<int>();
        for (int i = k + 1; i < ints.Length; i++)
        {
            list.Add(ints[i]);
        }
        for (int i = 0; i < k; i++)
        {
            list.Add(ints[i]);
        }
        int[] result = list.ToArray();
        return result;
    }
}
