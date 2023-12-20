namespace Data_Structures_Practices
{
    static internal class BracketsBalance
    {

        public static bool IsBracketsBalanced(string str)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict['('] = ')';
            dict['{'] = '}';
            dict['['] = ']';
            Stack<char> stack = new Stack<char>();
            char[] charArray = str.ToCharArray();
            foreach (char c in charArray)
            {
                if (stack.Count != 0)
                {
                    if (dict.ContainsKey(c))
                    {
                        stack.Push(c);
                    }
                    else if (dict.ContainsValue(c))
                    {
                        char lastElem = stack.Peek();
                        if (dict.ContainsKey(lastElem))
                        {
                            if (dict[lastElem] == c)
                            {
                                stack.Pop();
                            }
                            else
                            {
                                stack.Push(c);
                            }
                        }
                        else
                        {
                            stack.Push(c);
                        }
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            return false;
        }

    }
}
