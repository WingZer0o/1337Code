namespace _1337Code.Valid_Parentheses
{
    public class Solution
    {

        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            var pairs = new Dictionary<char, char>
            {
                [')'] = '(',
                ['}'] = '{',
                [']'] = '['
            };

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (pairs.TryGetValue(c, out char expected))
                {
                    if (stack.Count == 0 || stack.Pop() != expected)
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
}