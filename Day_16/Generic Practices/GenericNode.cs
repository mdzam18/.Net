namespace Generic_Practices
{
    internal class GenericNode<T>
    {

        T _Value;
        GenericNode<T?> _Left;
        GenericNode<T?> _Right;

        public GenericNode<T> Left
        {
            get
            {
                return _Left;
            }
            set
            {
                _Left = value;
            }
        }

        public GenericNode<T> Right
        {
            get
            {
                return _Right;
            }
            set
            {
                _Right = value;
            }
        }

        public T Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
            }
        }

        public GenericNode(T value, GenericNode<T> left, GenericNode<T> right)
        {
            Value = value;
            Left = left;
            Right = right;
        }

    }
}
