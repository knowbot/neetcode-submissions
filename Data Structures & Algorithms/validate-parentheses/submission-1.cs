public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>(s.Length);
        foreach(var p in s) {
            if(p == '(' || p == '[' || p == '{') {
                stack.Push(p);
            } else {
                if(stack.Count == 0) return false;
                var o = stack.Pop();
                if (o == '(' && p != ')' || 
                o == '[' && p != ']' ||
                o == '{' && p != '}') {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}
