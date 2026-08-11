public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLen = 0;
        int start = 0;
        var seenChars = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (seenChars.TryGetValue(s[i], out int prev) && prev >= start)
            {
                start = prev + 1;
            }
            seenChars[s[i]] = i;
            maxLen = Math.Max(maxLen, i - start + 1);
        }
        return maxLen;
    }
}
