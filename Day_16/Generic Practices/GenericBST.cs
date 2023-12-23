namespace Generic_Practices
{
    internal class GenericBST<T> where T : IComparable<T>
    {

        GenericNode<T> _Root;


        public void AddNode(T value)
        {
            _Root = AddValueInBST(value, _Root);
        }

        public bool Contains(T value)
        {
            return ContainsNode(value, _Root);
        }

        private bool ContainsNode(T value, GenericNode<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (value.CompareTo(node.Value) > 0)
            {
                return ContainsNode(value, node.Right);
            }
            if (value.CompareTo(node.Value) < 0)
            {
                return ContainsNode(value, node.Left);
            }
            return true;
        }

        private GenericNode<T> AddValueInBST(T value, GenericNode<T> node)
        {
            if (node == null)
            {
                node = new GenericNode<T>(value, null, null);
                return node;
            }
            if (value.CompareTo(node.Value) > 0)
            {
                node.Right = AddValueInBST(value, node.Right);
            }
            else if (value.CompareTo(node.Value) < 0)
            {
                node.Left = AddValueInBST(value, node.Left);
            }
            return node;
        }

        public void PrintBST()
        {
            PrintNodes(_Root);
        }

        private void PrintNodes(GenericNode<T> node)
        {
            if (node == null)
            {
                return;
            }
            PrintNodes(node.Left);
            Console.WriteLine(node.Value);
            PrintNodes(node.Right);
        }

    }
}
