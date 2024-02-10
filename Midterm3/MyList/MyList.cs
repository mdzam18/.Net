namespace MyList
{
    class MyList<T>
    {

        int _LogLen;
        T[] arr;

        public MyList()
        {
            arr = new T[10];
            _LogLen = 0;
        }

        public void Add(T item)
        {
            if (_LogLen == arr.Length)
            {
                ResizeArray();
            }
            arr[_LogLen] = item;
            _LogLen++;
        }

        public T Get(int i)
        {
            if (i < 0 || i >= _LogLen)
            {
                throw new InvalidRangeException("Out of range");
            }
            return arr[i];
        }

        public void AddRange(MyList<T> list)
        {
            for (int i = 0; i < list.Count(); i++)
            {
                Add(list.Get(i));
            }
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < _LogLen; i++)
            {
                if (item.Equals(arr[i]))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public void RemoveRange(int start, int length)
        {
            if (start < 0 || start >= _LogLen || start + length - 1 < 0 || start + length - 1 >= _LogLen)
            {
                throw new InvalidRangeException("out of range");
            }
            for (int i = start; i < start + length; i++)
            {
                RemoveAt(i);
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _LogLen)
            {
                throw new InvalidIndexException(String.Format("Index {0} is invalid", index));
            }
            for (int j = index + 1; j < _LogLen; j++)
            {
                arr[j - 1] = arr[j];
            }
            _LogLen--;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < _LogLen; i++)
            {
                if (item.Equals(arr[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public int Count()
        {
            return _LogLen;
        }

        private void ResizeArray()
        {
            int length = arr.Length;
            T[] temp = new T[length];
            length *= 2;
            for (int i = 0; i < _LogLen; i++)
            {
                temp[i] = arr[i];
            }
            arr = new T[length];
            for (int i = 0; i < _LogLen; i++)
            {
                arr[i] = temp[i];
            }
        }

    }
}