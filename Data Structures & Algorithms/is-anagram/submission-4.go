func isAnagram(s string, t string) bool {
    if len(s) != len(t) {
		return false
	}
	ms := make(map[rune]int, len(s))
	mt := make(map[rune]int, len(t))
	for i := 0; i < len(s); i++ {
		ms[rune(s[i])]++
		mt[rune(t[i])]++
	}
	for k, v := range ms {
		if mt[k] != v {
			return false
		}
	}
	return true
}
