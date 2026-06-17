func hasDuplicate(nums []int) bool {
    m := make(map[int]bool, len(nums))
	for _, v := range nums {
		if m[v] {
			return true
		}
		m[v] = true
	}
	return false
}
