func longestConsecutive(nums []int) int {
	set := make(map[int]int)
	for _, n := range nums {
		set[n] = n
	}
	
	maxlen := 0
	for i := 0; i < len(nums); i++ {
		if _, ok := set[nums[i]-1]; !ok {
			seq := make([]int, 0 , len(nums))
			next := nums[i]
			for {
				v, ok := set[next]
				if !ok {
					break
				}
				seq = append(seq, v)
				next++
			}
			maxlen = max(maxlen, len(seq))
		}
	}
	return maxlen
}
