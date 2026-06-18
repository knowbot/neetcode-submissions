func productExceptSelf(nums []int) []int {
	prod := 1
	zeroes := 0
	for i := 0; i < len(nums); i++ {
		if nums[i] == 0 {
			zeroes++
			if zeroes > 1 {
				prod = 0
			}
			continue
		}
		prod = prod * nums[i]
	}
	for j, n := range nums {
		if n == 0 {
			nums[j] = prod
			continue
		}
		if zeroes > 0 {
			nums[j] = 0
			continue
		}
		nums[j] = prod / n
	}
	return nums
}
