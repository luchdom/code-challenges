using System;
using System.Collections.Generic;
using System.Globalization;

namespace CodeChallenges
{
    public class ValidParentheses
    {
        //Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

        //An input string is valid if:

        //Open brackets must be closed by the same type of brackets.
        //Open brackets must be closed in the correct order.
        //Every close bracket has a corresponding open bracket of the same type.
        //Example 1:

        //Input: s = "()"
        //Output: true
        //Example 2:

        //Input: s = "()[]{}"
        //Output: true
        //Example 3:

        //Input: s = "(]"
        //Output: false
 

        //Constraints:

        //1 <= s.length <= 104
        //s consists of parentheses only '()[]{}'.

        public static readonly Dictionary<char, char> brackets = new Dictionary<char, char>
        {
            {'(', ')'},
            {'[', ']'},
            {'{', '}'}
        };

        public bool IsValid(string input)
        {
            var endings = new Stack<char>();
            foreach (var current in input)
            {
                if (brackets.ContainsKey(current))
                {
                    endings.Push(brackets[current]);
                }
                else if (endings.Count == 0 || endings.Pop() != current)
                {
                    return false;
                }
            }
            return endings.Count == 0;
        }

        public int CalPoints(string[] ops)
        {
            Stack<int> score = new Stack<int>();
            for (int i = 0; i < ops.Length; i++)
            {
                if (ops[i] == "C")
                {
                    score.Pop();
                }
                else if (ops[i] == "D")
                {
                    int x = score.Peek();
                    score.Push(x * 2);
                }
                else if (ops[i] == "+")
                {
                    int temp1 = score.Pop();
                    int temp2 = score.Peek();
                    score.Push(temp1);
                    score.Push(temp1 + temp2);
                }
                else
                    score.Push(Convert.ToInt32(ops[i], CultureInfo.InvariantCulture));
            }
            return score.Sum();
        }
    }




}
