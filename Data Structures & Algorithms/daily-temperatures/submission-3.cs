public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var hotDays = new Stack<int>(temperatures.Length);
        var results = new int[temperatures.Length];
        for(int i = temperatures.Length - 1; i >= 0; i--) {
            while(hotDays.Count != 0 && temperatures[i] >= temperatures[hotDays.Peek()]) {
                hotDays.Pop();
            }
            if(hotDays.Count != 0)
            {
                results[i] = hotDays.Peek() - i;
            }
            hotDays.Push(i);
        }
        return results;
    }
}
