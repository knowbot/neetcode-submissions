func isValidSudoku(board [][]byte) bool {
	var rows [9][9]int
	var cols [9][9]int
	var boxs [9][9]int
	for i := 0; i < 9; i++ {
		for j := 0; j < 9; j++ {
			if board[i][j] == '.' {
				continue
			}
			n := board[i][j] - '1'
			z := 3*(j/3)+i/3
			rows[i][n]++
			cols[j][n]++
			boxs[z][n]++
			if rows[i][n] > 1 || cols[j][n] > 1 || boxs[z][n] > 1 {
				return false
			}
		}
	}
	return true
}
