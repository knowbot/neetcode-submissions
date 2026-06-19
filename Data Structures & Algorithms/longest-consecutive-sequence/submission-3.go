func longestConsecutive(nums []int) int {
	set := make(map[int]int)
	for _, n := range nums {
		set[n] = n
	}
	
	maxlen := 0
	for i := 0; i < len(nums); i++ {
		if _, ok := set[nums[i]-1]; !ok {
			seqlen := 1
			next := nums[i] + 1
			for {
				_, ok := set[next]
				if !ok {
					break
				}
				seqlen++
				next++
			}
			maxlen = max(maxlen, seqlen)
		}
	}
	return maxlen
}
