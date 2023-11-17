Console.WriteLine("Enter integer number : ");
int number = 0;
bool b = int.TryParse(Console.ReadLine(), out number);
if (b)
{
    String str = "";
    if (number % 2 == 0)
    {
        str = "even";
    }
    else
    {
        str = "odd";
    }
    Console.WriteLine("Entered number " + number + " is " + str);
}
else
{
    Console.WriteLine("invalid Number");
}