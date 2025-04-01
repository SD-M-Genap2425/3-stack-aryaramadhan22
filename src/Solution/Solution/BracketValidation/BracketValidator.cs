using System;

namespace Solution.BracketValidation
{
    public class BracketNode
    {
        public char Data;
        public BracketNode? Next;

        public BracketNode(char data)
        {
            Data = data;
            Next = null;
        }
    }
    public class BracketValidator
    {
        private BracketNode? top;

        public BracketValidator()
        {
            top = null;
        }

        private void Push(char bracket)
        {
            var newNode = new BracketNode(bracket);
            newNode.Next = top;
            top = newNode;
        }
        private char? Pop()
        {
            if (top == null) return null;
            char data = top.Data;
            top = top.Next;
            return data;
        }
        private bool IsEmpty()
        {
            return top == null;
        }
        public bool ValidasiEkspresi(string ekspresi)
        {
            var stack = new BracketValidator(); 

            foreach (char ch in ekspresi)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    char? topBracket = stack.Pop();
                    if (topBracket == null || !IsMatchingPair(topBracket.Value, ch))
                        return false;
                }
            }

            return stack.IsEmpty();
        }
        private static bool IsMatchingPair(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '{' && close == '}') ||
                   (open == '[' && close == ']');
        }
    }
}
