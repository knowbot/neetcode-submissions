func topKFrequent(nums []int, k int) []int {
	by_elem := make(map[int]int)
	for _, n := range nums {
		by_elem[n]++
	}
	by_freq := make(map[int][]int)
	for key, val := range by_elem {
		by_freq[val] = append(by_freq[val], key)
	}
	res := make([]int, 0)
	max := len(nums)
	left := k
	for i := max; i > 0 && left > 0; i-- {
		if v, ok := by_freq[i]; ok {
			res = append(res, v...)
			left = left - len(v)
		}
	}
	return res
}
