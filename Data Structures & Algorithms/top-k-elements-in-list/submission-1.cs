public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freqs = new Dictionary<int, int>();
        foreach(var n in nums) {
            if(freqs.ContainsKey(n))
                freqs[n]++;
            else
                freqs.Add(n, 1);
        }
        var queue = new PriorityQueue<int, int>();
        foreach(var (key, val) in freqs) {
            queue.Enqueue(key, val);
            if(queue.Count > k)
                queue.Dequeue();
        }
        var res = new int[k];
        for(int i = 0; i < k; i++)
            res[i] = queue.Dequeue();
        return res;
    }
}
