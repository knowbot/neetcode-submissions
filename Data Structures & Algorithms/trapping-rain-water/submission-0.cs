public class Solution {
    public int Trap(int[] height) {
        int water = 0;
        var prefix = new int[height.Length];
        prefix[0] = height[0];
        for(int i = 1; i < height.Length - 1; i++) {
            prefix[i] = Math.Max(prefix[i-1], height[i]);
        }
        var suffix = new int[height.Length];
        suffix[height.Length - 1] = height[height.Length - 1];
        for(int i = height.Length - 2; i >= 0; i--) {
            suffix[i] = Math.Max(suffix[i+1], height[i]);
        }
        for(int i = 0; i < height.Length - 1; i++) {
            water += Math.Min(prefix[i], suffix[i]) - height[i];
        }
        return water;
    }
}
