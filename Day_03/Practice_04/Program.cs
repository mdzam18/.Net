Console.WriteLine("Enter your birth year:");
int year = 0;
bool b = int.TryParse(Console.ReadLine(), out year);
string result = "";
if(b && year >= 0 && year <= DateTime.Now.Year)
{
    switch (year % 12)
    {
        case 0:
            result = "Monkey";
            break;
        case 1:
            result = "Rooster";
            break;
        case 2:
            result = "Dog";
            break;
        case 3:
            result = "Pig";
            break;
        case 4:
            result = "Rat";
            break;
        case 5:
            result = "Ox";
            break;
        case 6:
            result = "Tiger";
            break;
        case 7:
            result = "Rabbit";
            break;
        case 8:
            result = "Dragon";
            break;
        case 9:
            result = "Snake";
            break;
        case 10:
            result = "Horse";
            break;
        case 11:
            result = "Goat";
            break;
    }
    Console.WriteLine(year + " was " + result + " year");
} 
else
{
    Console.WriteLine("Invalid year");
}
