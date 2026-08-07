public class Solution {
    public int MaxArea(int[] heights) {
        var max = 0;
        var l = 0;
        var r = heights.Length - 1;
        while(l < r) {
            var min = (heights[l] < heights[r]) ? l : r;
            var width = r - l;
            var area = heights[min] * width;
            if (area > max) max = area;
            if(min == l) {
                l++;
            } else {
                r--;
            }
        }
        return max;
    }
}
