func groupAnagrams(strs []string) [][]string {
	groups := make(map[[26]int][]string, len(strs))
	for _, s := range strs {
		var mask [26]int;
		for _, r := range s {
			mask[r - 'a']++
		}
		groups[mask] = append(groups[mask], s)
	}
	res := make([][]string, 0)
	for _, v := range groups {
		if(len(v) > 0) {
			res = append(res, v)
		}
	}
	return res
}
