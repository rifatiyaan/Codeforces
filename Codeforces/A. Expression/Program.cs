int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int firstResult = a+(b*c);
int secondResult = a*b*c ;
int thirdResult = (a+b)*c ;
int fourthResult = a * (b + c);
int fifthResult = a + b + c;

int[] resultArray ={firstResult,secondResult,thirdResult,fourthResult,fifthResult}; 

Console.WriteLine(resultArray.Max());