using System;
using System.Collections.Generic;
using System.Linq;

namespace Valid_parentheses
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var temp = IsValid("{[]}");
            Console.WriteLine(temp);
        }

        public static bool IsValid(string s)
        {
            var st = new Stack<char>();
            foreach (var c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    st.Push(c);
                }
                else
                {
                    if (st.Count == 0)
                    {
                        return false;
                    }

                    var top = st.Peek();
                    if (c == ')' && top == '(' ||
                        c == '}' && top == '{' ||
                        c == ']' && top == '[')
                    {
                        st.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (st.Count == 0) return true;

            return false;
        }
    }
}