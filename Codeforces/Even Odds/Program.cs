//using System.Text;

//var input = Console.ReadLine().Split(' ');
//List<long> inputs = new List<long>();
//List<long> even = new List<long>();
//List<long> odd = new List<long>();

//for (int i = 0; i < long.Parse(input[0]); i++)
//{
//    inputs.Add(i+1);
//}


//foreach (var item in inputs)
//{
//    if (item % 2 == 0)
//    {
//        even.Add(item);
//    }

//    else
//    {
//        odd.Add(item);
//    }
//}

//StringBuilder a;

//Console.WriteLine(odd[int.Parse(input[1])-1]);
//1 3 5 7 2 4 6

string userInput = Console.ReadLine();
var user = userInput.Split(' '); //4 6    
long n = Convert.ToInt64(user[0]);//
long w = Convert.ToInt64(user[1]);//

if ((n + 1) / 2 >= w) { 
                                  //8 5
    Console.WriteLine(w * 2 - 1); /*1 3 5 7 2 4 6 8*/
}// 4 6 // 1 3 5 2 4 6
// 6 - (4+1)/2 * 2
else
{
    Console.WriteLine((w - (n + 1) / 2) * 2);
                    //(7 - (7 + 1) / 2) * 2
}                      /*((5-(8+1)/2)*2)*/  