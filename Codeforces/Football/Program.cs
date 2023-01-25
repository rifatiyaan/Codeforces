string input = Console.ReadLine();

string[] b = input.Split();
string[] a = new string[b.Length];

for (int i = 0; i < b.Length; i++)
{
    a[i] = b[i];
}
foreach (var item in a)
{
    Console.WriteLine(item);
}
//for(int i = 0;i < a.Length; i++)
//{
//    if( a.Length>=7 &&  a[i] == a[i + 1] 
//        &&a[i] == a[i + 2]
//        &&a[i] == a[i + 3]
//        &&a[i] == a[i + 4]
//        &&a[i] == a[i + 5]
//        &&a[i] == a[i + 6]
//        &&a[i] == a[i + 7]
//       )
//    {
//        Console.WriteLine("YES");
//    }
//    else 
//       {
//        Console.WriteLine("NO");     
//       }
    
//}