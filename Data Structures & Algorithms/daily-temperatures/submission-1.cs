public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var hotDays = new Stack<int>(temperatures.Length);
        var results = new int[temperatures.Length];
        hotDays.Push(temperatures.Length - 1);
        for(int i = temperatures.Length - 2; i >= 0; i--) {
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
