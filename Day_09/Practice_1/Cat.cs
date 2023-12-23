namespace Practice_1
{
    internal class Cat
    {

        string _Name;
        string _Breed;
        int _Age;
        string _Sex;
        int _FoodWeight;

        private int FoodWeight => 10;

        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                if (value >= 0)
                {
                    _Age = value;
                }
            }
        }

        public string Breed { get; set; }

        public string Sex
        {
            get
            {
                return _Sex;
            }
            set
            {
                if (value == "male" || value == "female")
                    _Sex = value;
            }
        }

        public string Name { get; set; }

        public void Meowing(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Meowing ...");
            }
        }

        public void Eating(int weight)
        {
            Console.WriteLine("{0} start eating.", Name);
            int numberOfBites = weight / FoodWeight;
            if (weight % FoodWeight != 0)
            {
                numberOfBites++;
            }
            for (int i = 0; i < numberOfBites; i++)
            {
                Console.WriteLine("Eating ...");
            }
            Console.WriteLine("{0} finished eating.", Name);
        }
    }
}
