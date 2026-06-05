public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       var diffs = new Dictionary<int, int>();
        for(int i = 0; i < nums.Count(); i++) {
            var d = target - nums[i];
            if(diffs.ContainsKey(d)) {
                return new[] {Array.IndexOf(nums, d), i};
            }
            diffs.Add(nums[i], d);
        }
        return new int[0];
    }
}
