namespace Generic_Practices
{
    internal class GenericQueue<T>
    {
        T[] _Elems;
        int _LogLen;

        public GenericQueue()
        {
            _Elems = new T[10];
            _LogLen = 0;
        }

        public T Peek(out string status)
        {
            status = "";
            if (_LogLen > 0)
            {
                return _Elems[0];
            }
            status = "Queue is empty";
            return default(T);
        }

        public void Enqueue(T elem)
        {
            if (_LogLen == _Elems.Length)
            {
                _Elems = ResizeArray();
            }
            _Elems[_LogLen] = elem;
            _LogLen++;
        }

        public T Dequeue(out string status)
        {
            status = "";
            if (_LogLen > 0)
            {
                T result = _Elems[0];
                for (int i = 0; i < _LogLen - 1; i++)
                {
                    _Elems[i] = _Elems[i + 1];
                }
                _LogLen--;
                return result;
            }
            status = "Queue is empty";
            return default(T);
        }

        private T[] ResizeArray()
        {
            int length = _Elems.Length;
            T[] temp = new T[length * 2];
            for (int i = 0; i < length; i++)
            {
                temp[i] = _Elems[i];
            }
            return temp;
        }

    }
}
