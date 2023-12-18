namespace Generic_Practices
{
    internal class GenericStack<T>
    {

        T[] _Elems;
        int _LogLen;

        public GenericStack()
        {
            _Elems = new T[10];
            _LogLen = 0;
        }

        public void Push(T elem)
        {
            if (_LogLen == _Elems.Length)
            {
                _Elems = ResizeArray();
            }
            _Elems[_LogLen] = elem;
            _LogLen++;
        }

        public T Peek(out string status)
        {
            status = "";
            if (_LogLen > 0)
            {
                return _Elems[_LogLen - 1];
            }
            status = "Stack is empty";
            return default(T);
        }

        public T Pop(out string status)
        {
            status = "";
            if (_LogLen > 0)
            {
                T elem = _Elems[_LogLen - 1];
                _LogLen--;
                return elem;
            }
            status = "Stack is empty";
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