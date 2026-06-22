public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var seen = new HashSet<string>();

        for(var i= 0; i < 9; i++){
            for(var j = 0; j < 9; j++) {
                var value = board[i][j];
                if(value == '.')
                    continue;

                var row = $"row-{i}-{value}";
                var column = $"column-{j}-{value}";
                var box = $"box-{i/3}-{j/3}-{value}";
                if(!seen.Add(row) || !seen.Add(column) || !seen.Add(box))
                    return false;
            }
        }
        return true;
    }
}
