public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, List<string>>();
        var start = (int)'a';
        foreach(var s in strs) {
            var freqs = new int[26];
            foreach(var c in s) {
                var ind = (int)c - start;
                freqs[ind]++;
            }
            var key = string.Join(",", freqs);
            
            if(groups.TryGetValue(key, out List<string> group)) {
                group.Add(s);
            } else {
                var newGroup = new List<string> {s};
                groups.Add(key, newGroup);
            }
        }
        return groups.Values.ToList();
    }
}
