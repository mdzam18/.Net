namespace Generic_Practices
{
    internal class GenericMaxFinder<T> where T : IComparable<T>
    {

        public T GetMaxValue(T[] elems, out string status)
        {
            status = "";
            if (elems.Length == 0)
            {
                status = "Array is empty";
                return default(T);
            }
            T max = elems[0];
            for (int i = 1; i < elems.Length; i++)
            {
                if (elems[i].CompareTo(max) > 0)
                {
                    max = elems[i];
                }
            }
            return max;
        }


    }
}