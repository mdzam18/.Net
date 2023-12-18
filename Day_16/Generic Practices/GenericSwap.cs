namespace Generic_Practices
{
    class GenericSwap<T>
    {

        public void SwapElements(T elem1, T elem2, T[] elems, out string status)
        {
            status = "";
            int length = elems.Length;
            int elem1Index = -1;
            int elem2Index = -1;
            for (int i = 0; i < length; i++)
            {
                T elem = elems[i];
                if (elem.Equals(elem1))
                {
                    elem1Index = i;
                }
                else if (elem.Equals(elem2))
                {
                    elem2Index = i;
                }
            }
            if (elem1Index != -1 && elem2Index != -1)
            {
                T temp = elems[elem1Index];
                elems[elem1Index] = elem2;
                elems[elem2Index] = temp;
            }
            else
            {
                status = "Both elems must be in array";
            }
        }

    }
}
