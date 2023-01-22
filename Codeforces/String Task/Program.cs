string first = Console.ReadLine().ToLower();
string[] two = first.Split('a','e','i','o','u','y');
string three = String.Join("",two);

foreach (var item in three)
{
    Console.Write("."+item);
}


   
