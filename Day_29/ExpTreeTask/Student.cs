namespace ExpTreeTask
{
    class Student
    {

        public Student(int age, string name, char group)
        {
            Age = age;
            Name = name;
            Group = group;
        }

        public int Age { get; set; }

        public string Name { get; set; }

        public char Group { get; set; }

    }
}