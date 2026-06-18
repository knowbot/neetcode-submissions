type Solution struct{}

func (s *Solution) Encode(strs []string) string {
	escape := '/'
	separator := ';'
	var b strings.Builder 
	for _, s := range strs {
		for _, r := range []rune(s) {
			if r == escape || r == separator {
				b.WriteRune(escape)
			}
			b.WriteRune(r)
		}
		b.WriteRune(separator)
	}
	return b.String()
}

func (s *Solution) Decode(encoded string) []string {
	escape := '/'
	separator := ';'
	decoded := make([]string, 0)
	escaped := false
	var b strings.Builder 
	for _, r := range []rune(encoded) {
		if r == escape && !escaped {
			escaped = true
			continue
		}
		if r == separator && !escaped {
			decoded = append(decoded, b.String())
			escaped = false
			b.Reset()
			continue
		}
		b.WriteRune(r)
		escaped = false
	}
	return decoded
}
