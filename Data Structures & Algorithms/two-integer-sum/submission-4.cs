public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       var seen = new Dictionary<int, int>();
        for(int i = 0; i < nums.Count(); i++) {
            var diff = target - nums[i];
            if(seen.ContainsKey(diff)) {
                return new[] {seen[diff], i};
            }
            seen.Add(nums[i], i);
        }
        return new int[0];
    }
}
