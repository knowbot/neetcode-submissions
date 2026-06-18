func productExceptSelf(nums []int) []int {
	prods := make([]int, len(nums))
	prev := 1
	for i := 0; i < len(nums); i++ {
		prods[i] = prev
		prev *= nums[i]
	}
	post := 1
	for j := len(nums) - 1; j >= 0; j-- {
		prods[j] *= post
		post *= nums[j]
	}
	return prods
}
