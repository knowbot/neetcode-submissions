type Solution struct{}

func (s *Solution) Encode(strs []string) string {
	escape := '/'
	separator := ';'
	encoded := make([]rune, 0) 
	for _, s := range strs {
		for _, r := range []rune(s) {
			if r == escape || r == separator {
				encoded = append(encoded, escape)
			}
			encoded = append(encoded, r)
		}
		encoded = append(encoded, separator)
	}
	return string(encoded)
}

func (s *Solution) Decode(encoded string) []string {
	escape := '/'
	separator := ';'
	decoded := make([]string, 0)
	escaped := false
	str := make([]rune, 0)
	for _, r := range []rune(encoded) {
		if r == escape && !escaped {
			escaped = true
			continue
		}
		if r == separator && !escaped {
			decoded = append(decoded, string(str))
			str = nil
			continue
		}
		str = append(str, r)
		escaped = false
	}
	return decoded
}
