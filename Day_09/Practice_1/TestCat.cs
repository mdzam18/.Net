namespace Practice_1
{

    internal class TestCat
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Cat object...");
            Cat cat = new Cat();
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            cat.Name = name;
            Console.Write("Enter breed: ");
            string breed = Console.ReadLine();
            cat.Breed = breed;
            Console.Write("Enter age: ");
            int age = 0;
            bool b = int.TryParse(Console.ReadLine(), out age);
            if (b)
            {
                cat.Age = age;
            }
            else
            {
                Console.WriteLine("Invalid number");
                return;
            }
            Console.Write("Enter sex: ");
            string sex = Console.ReadLine();
            cat.Sex = sex.ToLower();
            Console.WriteLine("Cat object created.");
            Console.Write("Enter food weight in grams: ");
            int weight = 0;
            b = int.TryParse(Console.ReadLine(), out weight);
            if (b)
            {
                cat.Eating(weight);
            }
            else
            {
                Console.WriteLine("Invalid number");
                return;
            }
            Console.Write("Enter meowing count: ");
            int meowingCount = 0;
            b = int.TryParse(Console.ReadLine(), out meowingCount);
            if (b)
            {
                cat.Meowing(meowingCount);
            }
            else
            {
                Console.WriteLine("Invalid number");
                return;
            }
        }
    }

}
