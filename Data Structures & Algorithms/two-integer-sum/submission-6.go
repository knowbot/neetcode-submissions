func twoSum(nums []int, target int) []int {
	// a + b = c
	// b = c - a
	indices := make(map[int]int, len(nums))
    diffs := make(map[int]int, len(nums))
	for i, n := range nums {
		d := target - n
		diffs[n] = d
		if _, ok := indices[d]; ok {
			return []int {indices[d], i}
		}
		indices[n] = i
	}
	return []int{}

}
