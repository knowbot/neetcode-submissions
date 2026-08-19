public class Solution {
    public int EvalRPN(string[] tokens) {
        var operands = new Stack<int>(tokens.Length);
        for(int i = 0; i < tokens.Length; i++) {
            if (Int32.TryParse(tokens[i], out int val))
            {
                operands.Push(val);
            }
            else
            {
                int b = operands.Pop();
                int a = operands.Pop();
                switch (tokens[i][0])
                {
                    case '+': operands.Push(a+b); break;
                    case '-': operands.Push(a-b); break;
                    case '*': operands.Push(a*b); break;
                    case '/': operands.Push(a/b); break;
                }
            }
        }
        return operands.Pop();
    }
}
