using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution.Palindrome
{
    public static class PalindromeChecker
    {
        public static bool CekPalindrom(string input)
        {
            var normalizedString = new string(input.Where(c => Char.IsLetterOrDigit(c)).Select(c => Char.ToLower(c)).ToArray());

            Stack<char> stack = new Stack<char>();

            foreach (var c in normalizedString)
            {
                stack.Push(c);
            }

            foreach (var c in normalizedString)
            {
                if (c != stack.Pop())
                {
                    return false;
                }
            }

            return true; 
        }
    }
}
