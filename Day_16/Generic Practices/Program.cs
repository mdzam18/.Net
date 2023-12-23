namespace Generic_Practices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowGenericSwap();
            ShowGenericMax();
            ShowGenericStack();
            ShowGenericQueue();
            Console.WriteLine();
            ShowBST();
        }

        private static void ShowBST()
        {
            Console.WriteLine("Binary Search Tree");
            GenericBST<int> bst = new GenericBST<int>();
            bst.AddNode(1);
            bst.AddNode(2);
            bst.AddNode(-1);
            bst.AddNode(10);
            Console.WriteLine("Node values");
            bst.PrintBST();
            Console.WriteLine("Check if bst contains 2");
            Console.WriteLine(bst.Contains(2));
            Console.WriteLine("Check if bst contains 5");
            Console.WriteLine(bst.Contains(5));
        }

        private static void ShowGenericQueue()
        {
            ShowGenericQueueForInt();
            Console.WriteLine("\n");
            ShowGenericQueueForString();
            Console.WriteLine("\n");
            ShowGenericQueueForInvalidInput();
        }

        private static void ShowGenericQueueForInvalidInput()
        {
            Console.WriteLine("Generic queue for invalid input");
            GenericQueue<string> queue = new GenericQueue<string>();
            Console.WriteLine("Dequeue in empty queue");
            String status;
            string dequeue = queue.Dequeue(out status);
            if (status.Length == 0)
            {
                Console.Write("{0} ", dequeue);
            }
            else
            {
                Console.WriteLine(status);
            }
        }

        private static void ShowGenericQueueForString()
        {
            Console.WriteLine("Generic queue for string");
            GenericQueue<string> queue = new GenericQueue<string>();
            Console.WriteLine("Enqueue and peek");
            for (int i = 0; i < 20; i++)
            {
                queue.Enqueue("a" + i);
                String status;
                string peek = queue.Peek(out status);
                if (status.Length == 0)
                {
                    Console.Write("{0} ", peek);
                }
                else
                {
                    Console.WriteLine(status);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Dequeue");
            for (int i = 0; i < 20; i++)
            {
                String status;
                string dequeue = queue.Dequeue(out status);
                if (status.Length == 0)
                {
                    Console.Write("{0} ", dequeue);
                }
                else
                {
                    Console.WriteLine(status);
                }
            }
        }

        private static void ShowGenericQueueForInt()
        {
            Console.WriteLine("Generic queue for int");
            GenericQueue<int> queue = new GenericQueue<int>();
            Console.WriteLine("Enqueue and peek");
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
                String status;
                int peek = queue.Peek(out status);
                if (status.Length == 0)
                {
                    Console.Write("{0} ", peek);
                }
                else
                {
                    Console.WriteLine(status);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Dequeue");
            for (int i = 0; i < 10; i++)
            {
                String status;
                int dequeue = queue.Dequeue(out status);
                if (status.Length == 0)
                {
                    Console.Write("{0} ", dequeue);
                }
                else
                {
                    Console.WriteLine(status);
                }
            }
        }

        private static void ShowGenericStack()
        {
            ShowGenericStackForInt();
            Console.WriteLine("\n");
            ShowGenericStackForString();
            Console.WriteLine("\n");
            ShowGenericStackForInvalidInput();
            Console.WriteLine("\n");
        }

        private static void ShowGenericStackForInvalidInput()
        {
            Console.WriteLine("Generic stack for invalid input");
            GenericStack<string> stack = new GenericStack<string>();
            Console.WriteLine("Pop in empty stack");
            String status;
            string pop = stack.Pop(out status);
            if (status.Length == 0)
            {
                Console.Write("{0} ", pop);
            }
            else
            {
                Console.WriteLine(status);
            }
        }

        private static void ShowGenericStackForString()
        {
            Console.WriteLine("Generic stack for string");
            GenericStack<string> stack = new GenericStack<string>();
            Console.WriteLine("Push and peek");
            for (int i = 0; i < 20; i++)
            {
                stack.Push("a:" + i);
                String status;
                string peek = stack.Peek(out status);
                if (status.Length == 0)
                {
                    Console.Write("{0} ", peek);
                }
                else
                {
                    Console.WriteLine(status);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Pop");
            for (int i = 0; i < 20; i++)
            {
                String status;
                string pop = stack.Pop(out status);
                if (status.Length == 0)
                {
                    Console.Write("{0} ", pop);
                }
                else
                {
                    Console.WriteLine(status);
                }
            }
        }

        private static void ShowGenericStackForInt()
        {
            Console.WriteLine("Generic stack for int");
            GenericStack<int> stack = new GenericStack<int>();
            Console.WriteLine("Push and Peek");
            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
                String status;
                int peek = stack.Peek(out status);
                if (status.Length == 0)
                {
                    Console.Write("{0} ", peek);
                }
                else
                {
                    Console.WriteLine(status);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Pop");
            for (int i = 0; i < 10; i++)
            {
                String status;
                int pop = stack.Pop(out status);
                if (status.Length == 0)
                {
                    Console.Write("{0} ", pop);
                }
                else
                {
                    Console.WriteLine(status);
                }
            }
        }

        private static void ShowGenericMax()
        {
            ShowGenericMaxForInt();
            Console.WriteLine();
            ShowGenericMaxForDouble();
            Console.WriteLine();
            ShowGenericMaxForInvalidInput();
            Console.WriteLine();
        }

        private static void ShowGenericMaxForInvalidInput()
        {
            Console.WriteLine("Find max method for invalid input");
            GenericMaxFinder<int> maxFinder = new GenericMaxFinder<int>();
            int[] elems = new int[] { };
            foreach (int elem in elems)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
            string status;
            int max = maxFinder.GetMaxValue(elems, out status);
            if (status.Length == 0)
            {
                Console.WriteLine("max is: {0}", max);
            }
            else
            {
                Console.WriteLine(status);
            }
        }

        private static void ShowGenericMaxForDouble()
        {
            Console.WriteLine("Find max method for double");
            GenericMaxFinder<double> maxFinder = new GenericMaxFinder<double>();
            double[] elems = new double[] { 1, 2.5, 3, -4, 13, -2, 15.9, -1.2 };
            foreach (double elem in elems)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
            string status;
            double max = maxFinder.GetMaxValue(elems, out status);
            if (status.Length == 0)
            {
                Console.WriteLine("max is: {0}", max);
            }
            else
            {
                Console.WriteLine(status);
            }
        }

        private static void ShowGenericMaxForInt()
        {
            Console.WriteLine("Find max method for int");
            GenericMaxFinder<int> maxFinder = new GenericMaxFinder<int>();
            int[] elems = new int[] { 1, 2, 3, -4, 13, -2, 15 };
            foreach (int elem in elems)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
            string status;
            int max = maxFinder.GetMaxValue(elems, out status);
            if (status.Length == 0)
            {
                Console.WriteLine("max is: {0}", max);
            }
            else
            {
                Console.WriteLine(status);
            }
        }

        private static void ShowGenericSwap()
        {
            ShowSwapForInt();
            Console.WriteLine("\n");
            ShowSwapForString();
            Console.WriteLine("\n");
            ShowSwapForInvalidInput();
            Console.WriteLine("\n");
        }

        private static void ShowSwapForInvalidInput()
        {
            Console.WriteLine("Swap method for invalid input");
            GenericSwap<string> swap = new GenericSwap<string>();
            string elem1 = "ab";
            string elem2 = "ad";
            string[] elems = new string[] { "ab", "ad2" };
            foreach (string elem in elems)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Swap {0} and {1}", elem1, elem2);
            string status;
            swap.SwapElements(elem1, elem2, elems, out status);
            if (status.Length == 0)
            {
                foreach (string elem in elems)
                {
                    Console.Write(elem + " ");
                }
            }
            else
            {
                Console.WriteLine(status);
            }
        }

        private static void ShowSwapForString()
        {
            Console.WriteLine("Swap method for string");
            GenericSwap<string> swap = new GenericSwap<string>();
            string elem1 = "ab";
            string elem2 = "ad";
            string[] elems = new string[] { "ab", "ad" };
            foreach (string elem in elems)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Swap {0} and {1}", elem1, elem2);
            string status;
            swap.SwapElements(elem1, elem2, elems, out status);
            if (status.Length == 0)
            {
                foreach (string elem in elems)
                {
                    Console.Write(elem + " ");
                }
            }
            else
            {
                Console.WriteLine(status);
            }
        }

        private static void ShowSwapForInt()
        {
            Console.WriteLine("Swap method for int");
            GenericSwap<int> swap = new GenericSwap<int>();
            int elem1 = 2;
            int elem2 = 4;
            int[] elems = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach (int elem in elems)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Swap {0} and {1}", elem1, elem2);
            string status;
            swap.SwapElements(elem1, elem2, elems, out status);
            if (status.Length == 0)
            {
                foreach (int elem in elems)
                {
                    Console.Write(elem + " ");
                }
            }
            else
            {
                Console.WriteLine(status);
            }
        }

    }
}
