using System.Linq.Expressions;

namespace ExpTreeTask
{
    class Program
    {

        static void Main(string[] args)
        {
            Student student1 = new Student(18, "Zuko", 'a');
            Student student2 = new Student(19, "Katara", 'b');
            Student student3 = new Student(17, "Aang", 'a');
            Student student4 = new Student(19, "Sokka", 'b');
            Student student5 = new Student(18, "Azula", 'a');
            List<Student> students = new List<Student>() { student1, student2, student3, student4, student5 };
            List<Object> fillters = new List<Object>() { 18 };
            var result = FillterStudents(students, fillters);
            foreach (var student in result)
            {
                Console.WriteLine("Name: {0}, Age: {1}, Group: {2}", student.Name, student.Age, student.Group);
            }
        }

        private static List<Student> FillterStudents(List<Student> students, List<object> fillterList)
        {
            if (fillterList.Count == 0)
            {
                return students;
            }
            var classType = typeof(Student);
            var parameterExpression = Expression.Parameter(classType, "s");
            List<BinaryExpression> bodies = new List<BinaryExpression>();
            foreach (object obj in fillterList)
            {
                ConstantExpression constant = Expression.Constant(obj);
                Type typeOfStudent = typeof(Student);
                var properties = typeOfStudent.GetProperties();
                var property = properties.FirstOrDefault(p => obj.GetType() == p.PropertyType);
                if (property == null)
                {
                    throw new InvalidTypeException();
                }
                string propertyName = property.Name;
                MemberExpression memberExpression = Expression.Property(parameterExpression, propertyName);
                BinaryExpression body = Expression.Equal(memberExpression, constant);
                bodies.Add(body);
            }

            Expression finalExpression = bodies.Aggregate(Expression.AndAlso);
            var finalLambdaExpression = Expression.Lambda<Func<Student, bool>>(finalExpression, parameterExpression);
            Func<Student, bool> fillterFunc = finalLambdaExpression.Compile();
            return students.Where(fillterFunc).ToList();
        }

    }
}