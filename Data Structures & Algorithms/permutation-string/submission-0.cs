public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length  > s2.Length ) return false;
        int l = 0, r = 1;
        var freqs = new int[26];
        int matches = 0;
        var window = new int[26];
        // we can do s2 too cause its guaranteed to be longer
        for(int i = 0; i < s1.Length ; i++) {
            freqs[s1[i] - 'a']++;
            window[s2[i] - 'a']++;
        }
        // count matches
        for(int j = 0; j < 26; j++) {
            if(freqs[j] == window[j]) matches++;
        }
        for(int k = s1.Length; k < s2.Length; k++) {
            if (matches == 26) return true;
            var wIn = s2[k] - 'a';
            var wOut = s2[k - s1.Length] - 'a';
            if (window[wOut] == freqs[wOut]) matches--;
            if (--window[wOut] == freqs[wOut]) matches++;
            if (window[wIn] == freqs[wIn]) matches--;
            if (++window[wIn] == freqs[wIn]) matches++;
        }
        return matches == 26;
    }
}
