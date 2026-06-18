func groupAnagrams(strs []string) [][]string {
	groups := make(map[[26]byte][]string, len(strs))
	for _, s := range strs {
		var mask [26]byte;
		for i := 0; i < len(s); i++ {
			mask[s[i] - 'a']++
		}
		groups[mask] = append(groups[mask], s)
	}
	res := make([][]string, 0, len(groups))
	for _, v := range groups {
		res = append(res, v)
	}
	return res
}
