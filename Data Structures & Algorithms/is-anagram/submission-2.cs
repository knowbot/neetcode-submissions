public class Solution {
    public bool IsAnagram(string s, string t) {
        var collisions = new Dictionary<char, int>();
        foreach (var c1 in s)
        {
            if (collisions.ContainsKey(c1))
                collisions[c1]++;
            else
                collisions.Add(c1, 1);
        }
        foreach (var c2 in t)
        {
            if (!collisions.ContainsKey(c2))
                return false;
            collisions[c2]--;
            if (collisions[c2] == 0) collisions.Remove(c2);
        }
        return collisions.Keys.Count == 0;
    }
}
