double a = readNumber("first");
if(a == -1)
{
    return;
}
double b = readNumber("second");
if (b == -1)
{
    return;
}
double c = readNumber("third");
if (c == -1)
{
    return;
}
if(isTriangle(a, b, c))
{
    Console.WriteLine("This should be a triangle !");
} else
{
    Console.WriteLine("This can't be a triangle !");
}

static bool isTriangle(double a, double b, double c)
{
    if(a + b > c && a + c > b && b + c > a)
    {
        return true;
    }
    return false;
}

static double readNumber(String str)
{
    Console.WriteLine("Enter " + str + " number :");
    double a = 0;
    bool b = double.TryParse(Console.ReadLine(), out a);
    if (b && a > 0)
    {
        return a;
    }
    else
    {
        Console.WriteLine("invalid number");
        return -1;
    }
}