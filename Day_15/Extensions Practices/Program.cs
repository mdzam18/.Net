namespace Extensions_Practices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringMethods();
            IntMethods();
            ArrayMethods();
            DateTimeMethods();
            CollectionMethod();
        }

        private static void CollectionMethod()
        {
            ShowMergeMethod();
            Console.WriteLine();
            ShowGenerateStringWithSeparator();
        }

        private static void ShowGenerateStringWithSeparator()
        {
            Console.WriteLine("Generate string with separator");
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine("Enter elements");
            for (int i = 0; i < length; i++)
            {
                int elem = int.Parse(Console.ReadLine());
                arr[i] = elem;
            }
            Console.Write("Enter separator: ");
            string separator = Console.ReadLine();
            Console.WriteLine("Generated string with separator is {0}", arr.GenerateStringWithSeparator(separator));
        }

        private static void ShowMergeMethod()
        {
            Console.WriteLine("Merge two sequences");
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine("Enter elements");
            for (int i = 0; i < length; i++)
            {
                int elem = int.Parse(Console.ReadLine());
                arr[i] = elem;
            }

            Console.Write("Enter array length: ");
            int length2 = int.Parse(Console.ReadLine());
            int[] arr2 = new int[length2];
            Console.WriteLine("Enter elements");
            for (int i = 0; i < length2; i++)
            {
                int elem = int.Parse(Console.ReadLine());
                arr2[i] = elem;
            }
            int[] merged = arr.MergeTwoSequences(arr2);
            Console.WriteLine("Merged array is");
            foreach (int elem in merged)
            {
                Console.Write("{0} ", elem);
            }
        }

        private static void DateTimeMethods()
        {
            ShowConvertToStringMethod();
            Console.WriteLine();
            ShowIfDateIsInRangeMethod();
            Console.WriteLine();
            ShowGetAgeMethod();
        }

        private static void ShowGetAgeMethod()
        {
            Console.WriteLine("Calculate age");
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter day: ");
            int day = int.Parse(Console.ReadLine());
            DateTime dateOfBirth = new DateTime(year, month, day);
            Console.WriteLine("Age is: {0}", dateOfBirth.GetAge());
        }

        private static void ShowIfDateIsInRangeMethod()
        {
            Console.WriteLine("Date is in range");
            Console.Write("Enter year for lower range: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter month for lower range: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter day for lower range: ");
            int day = int.Parse(Console.ReadLine());
            DateTime date1 = new DateTime(year, month, day);

            Console.Write("Enter year for upper range: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Enter month for upper range: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Enter day for upper range: ");
            day = int.Parse(Console.ReadLine());
            DateTime date2 = new DateTime(year, month, day);

            Console.Write("Enter year: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Enter month: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Enter day: ");
            day = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(year, month, day);
            if (date.IsDateInRange(date1, date2))
            {
                Console.WriteLine("Date is in range");
            }
            else
            {
                Console.WriteLine("Date is not in range");
            }
        }

        private static void ShowConvertToStringMethod()
        {
            Console.WriteLine("Date as string");
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter day: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Enter hour: ");
            int hour = int.Parse(Console.ReadLine());
            Console.Write("Enter minute: ");
            int minute = int.Parse(Console.ReadLine());
            Console.Write("Enter second: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Enter milisecond: ");
            int milisecond = int.Parse(Console.ReadLine());
            DateTime dateTime = new DateTime(year, month, day, hour, minute, second, milisecond);
            Console.WriteLine("Date and time as string is: {0} ", dateTime.ConvertToString());
        }

        private static void ArrayMethods()
        {
            ShowRemoveDuplicatesMethod();
            Console.WriteLine();
            ShowContainsElementMethod();
            Console.WriteLine();
            ShowGetMaxElement();
            Console.WriteLine();
        }

        private static void ShowGetMaxElement()
        {
            Console.WriteLine("Max element in array");
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine("Enter elements");
            for (int i = 0; i < length; i++)
            {
                int elem = int.Parse(Console.ReadLine());
                arr[i] = elem;
            }
            Console.WriteLine("Max element in array is {0}", arr.GetMaxElement());
        }

        private static void ShowContainsElementMethod()
        {
            Console.WriteLine("Contains element in array");
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine("Enter elements");
            for (int i = 0; i < length; i++)
            {
                int elem = int.Parse(Console.ReadLine());
                arr[i] = elem;
            }
            Console.Write("Enter element: ");
            int n = int.Parse(Console.ReadLine());
            if (arr.ContainsElement(n))
            {
                Console.WriteLine("Array contains {0}", n);
            }
            else
            {
                Console.WriteLine("Array does not contain {0}", n);
            }
        }

        private static void ShowRemoveDuplicatesMethod()
        {
            Console.WriteLine("Remove duplicates");
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine("Enter elements");
            for (int i = 0; i < length; i++)
            {
                int elem = int.Parse(Console.ReadLine());
                arr[i] = elem;
            }

            int[] arrWithoutDuplicates = arr.RemoveDuplicates();
            Console.WriteLine("Array without duplicates");
            for (int i = 0; i < arrWithoutDuplicates.Length; i++)
            {
                Console.Write("{0} ", arrWithoutDuplicates[i]);
            }
            Console.WriteLine();
        }

        private static void IntMethods()
        {
            ShowIsEvenOrOdd();
            Console.WriteLine();
            ShowGetAbsoluteValue();
            Console.WriteLine();
            ShowRoundToTheNearestMultiple();
            Console.WriteLine();
        }

        private static void StringMethods()
        {
            ShowStringReverseMethod();
            Console.WriteLine();
            ShowCountOccurenceMethod();
            Console.WriteLine();
            ShowStartsOrEndsWithSubstringMethod();
            Console.WriteLine();
        }

        private static void ShowRoundToTheNearestMultiple()
        {
            Console.WriteLine("Round to the nearest multiple");
            Console.Write("Enter int: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter multiple: ");
            int multiple = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} rounded to the nearest multiple is {1}", n, n.RoundToTheNearestMultiple(multiple));
        }

        private static void ShowGetAbsoluteValue()
        {
            Console.WriteLine("Absolute value");
            Console.Write("Enter int: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Absolute value of {0} is {1}", n, n.GetAbsoluteValue());
        }

        private static void ShowIsEvenOrOdd()
        {
            Console.WriteLine("Int is even or odd");
            Console.Write("Enter int: ");
            int n = int.Parse(Console.ReadLine());
            if (n.IsEven())
            {
                Console.WriteLine("{0} is even", n);
            }
            else
            {
                Console.WriteLine("{0} is odd", n);
            }
        }

        private static void ShowStartsOrEndsWithSubstringMethod()
        {
            Console.WriteLine("Starts or ends with substring");
            Console.Write("Enter String: ");
            string str = Console.ReadLine();
            Console.Write("Enter substring: ");
            string subString = Console.ReadLine();
            if (str != null && subString != null)
            {
                if (str.StartsOrEndsWithSubstring(subString))
                {
                    Console.WriteLine("String \"{0}\" starts or ends with \"{1}\" substring", str, subString);
                }
                else
                {
                    Console.WriteLine("String \"{0}\" does not start or end with \"{1}\" substring", str, subString);
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        private static void ShowCountOccurenceMethod()
        {
            Console.WriteLine("Count Occurences");
            Console.Write("Enter String: ");
            string str = Console.ReadLine();
            Console.Write("Enter character: ");
            char c = char.Parse(Console.ReadLine());
            if (str != null)
            {
                Console.WriteLine("Occurence of {0} is: {1}", c, str.GetCharacterOccurence(c));
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        private static void ShowStringReverseMethod()
        {
            Console.WriteLine("String Reverse");
            Console.Write("Enter String: ");
            string str = Console.ReadLine();
            if (str != null)
            {
                Console.WriteLine("Reversed string is: {0}", str.Reverse());
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

    }
}