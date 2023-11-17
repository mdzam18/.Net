int year = 2004;
if(year < 0)
{
    Console.WriteLine("Invalid year");
} 
else
{
    bool isLeap = false;
    if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
    {
        isLeap = true;  
    }
    Console.WriteLine(isLeap);
}