namespace MyList
{
    static class MyListExtension
    {

        public static T First<T>(this MyList<T> myList, Predicate<T> predicate)
        {
            for (int i = 0; i < myList.Count(); i++)
            {
                T item = myList.Get(i);
                if (predicate(item))
                {
                    return item;
                }
            }
            throw new Exception("item was not found");
        }

        public static T? FirstOrDefault<T>(this MyList<T> myList, Predicate<T> predicate)
        {
            for (int i = 0; i < myList.Count(); i++)
            {
                T item = myList.Get(i);
                if (predicate(item))
                {
                    return item;
                }
            }
            return default(T);
        }

        public static IEnumerable<T> Where<T>(this IEnumerable<T> myList, Predicate<T> predicate)
        {
            T[] temp = new T[myList.Count()];
            int index = 0;
            for (int i = 0; i < myList.Count(); i++)
            {
                if (predicate(myList.ElementAt(i)))
                {
                    temp[index] = myList.ElementAt(i);
                    index++;
                }
            }
            T[] result = new T[temp.Length - index];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = temp[i];
            }
            return result;
        }

        public static IEnumerable<T> Distinct<T>(this IEnumerable<T> myList)
        {
            T[] temp = new T[myList.Count()];
            int index = 0;
            for (int i = 0; i < myList.Count(); i++)
            {
                T item = myList.ElementAt(i);
                bool contains = false;
                for (int j = 0; j < myList.Count(); j++)
                {
                    if (i != j && item.Equals(myList.ElementAt(j)))
                    {
                        contains = true;
                        break;
                    }
                }
                if (!contains)
                {
                    temp[index] = item;
                    index++;
                }
            }
            T[] result = new T[temp.Length - index];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = temp[i];
            }
            return result;
        }

    }
}
