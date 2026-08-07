public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var result = new List<List<int>>();
        for (int i = 0; i < nums.Length - 2; i++) {
            if(nums[i] > 0) break;
            if(i > 0 && nums[i] == nums[i-1]) continue;
            var j = i + 1;
            var k = nums.Length - 1;
            while(j < k) {
                var sum = nums[i] + nums[j] + nums[k];
                if (sum > 0) {
                    k--;
                    continue;
                }
                if (sum < 0) {
                    j++;
                    continue;
                }
                if (sum == 0) {
                    result.Add(new List<int>{nums[i], nums[j], nums[k]});
                    j += 1;
                    k -= 1;
                }
                while (j < k && nums[j] == nums[j-1]) {
                    j++;
                }
                while (j < k && nums[k] == nums[k+1]) {
                    k--;
                }
            }
        }
        return result;
    }
}
