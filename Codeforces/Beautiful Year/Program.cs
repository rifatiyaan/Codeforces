var input = Console.ReadLine();
int year = int.Parse(input);
int newYear = year+ 1;
ShowYear(newYear);
void ShowYear(int year)
{
    if  (newYear.ToString().Distinct().Count() == 4) 
    { 
        Console.WriteLine(newYear.ToString()); 
    }
    else 
    { 
        newYear++;
        ShowYear(newYear); 
    }    
}
