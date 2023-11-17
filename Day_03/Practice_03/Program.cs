Console.WriteLine("Enter number :");
double number = 0;
bool b = double.TryParse(Console.ReadLine(), out number);
int pow = 2;
if(b)
{
    Console.WriteLine("The pow of the entered number is " + Math.Pow(number, pow));
} 
else
{
    Console.WriteLine("Invalid number");
}