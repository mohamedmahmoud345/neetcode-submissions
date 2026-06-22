public class Solution {
    public bool IsValidSudoku(char[][] board) {
       for (var i = 0; i < board.Length; i++)
    {
        var rowSet = new HashSet<int>();
        var columnSet = new HashSet<int>();
        var boxSet = new HashSet<int>();
        for (var j = 0; j < 9; j++)
        {
            if (board[i][j] != '.' && rowSet.Contains(board[i][j]))
                return false;
            rowSet.Add(board[i][j]);
        
            if (board[j][i] != '.' && columnSet.Contains(board[j][i]))
                return false;
            columnSet.Add(board[j][i]);
        
            var boxRow = 3 * (i / 3) + (j / 3);
            var boxColumn = 3 * (i % 3) + (j % 3);
            if (board[boxRow][boxColumn] != '.' && boxSet.Contains(board[boxRow][boxColumn]))
                return false;
            boxSet.Add(board[boxRow][boxColumn]);
        }
    }

    return true;
    }
}
