public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for (var i = 0; i < 9; i++) {
        var row = new HashSet<char>();
        var column = new HashSet<char>();
        var box = new HashSet<char>();
        
        for (var j = 0; j < 9; j++) {
                if (board[i][j] != '.') {
                    if (row.Contains(board[i][j]))
                        return false;
                    row.Add(board[i][j]);
                }
                
                if (board[j][i] != '.') {
                    if (column.Contains(board[j][i]))
                        return false;
                    column.Add(board[j][i]);
                }
                
                int boxRow = 3 * (i / 3) + (j / 3);
                int boxCol = 3 * (i % 3) + (j % 3);
                
                if (board[boxRow][boxCol] != '.') {
                    if (box.Contains(board[boxRow][boxCol]))
                        return false;
                    box.Add(board[boxRow][boxCol]);
                }
            }
        }
        return true;
    }
}
