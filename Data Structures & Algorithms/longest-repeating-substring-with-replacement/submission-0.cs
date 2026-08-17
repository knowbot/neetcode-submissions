public class Solution {
    public int CharacterReplacement(string s, int k) {
        var max = 0;
        var freqs = new Dictionary<char, int>();
        int l = 0, r = 0;
        while(r < s.Length) {
            if(freqs.ContainsKey(s[r])) {
                freqs[s[r]]++;
            } else {
                freqs[s[r]] = 1;
            }
            
            max = Math.Max(freqs[s[r]], max);
            var window = r - l + 1;
            if (window - max > k) {
                freqs[s[l]]--;
                l++;
            }
            r++;
        }
        return (s.Length - l);
    }
}
