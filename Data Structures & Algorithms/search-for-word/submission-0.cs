public class Solution {
        private int rows, cols;
        private HashSet<(int, int)> path = new HashSet<(int, int)>();
    public bool Exist(char[][] board, string word) {
        rows = board.Length;
        cols = board[0].Length;

        for(var r = 0; r < rows; r++){
            for(var c= 0; c < cols; c++){
                if(DFS(board, word, r, c, 0)){
                    return true;
                }
            }
        }
        return false;
    }

    private bool DFS(char[][] board, string word, int r, int c, int i){
        if(i == word.Length) {
            return true;
        }

        if(r < 0 || c < 0 || r >= rows || c >= cols || board[r][c] != word[i] || path.Contains((r,c)))
            return false;

        path.Add((r,c));
        bool res = DFS(board, word, r + 1, c, i + 1) ||
                   DFS(board, word, r - 1, c, i + 1) ||
                   DFS(board, word, r, c + 1, i + 1) ||
                   DFS(board, word, r, c - 1, i + 1);
        path.Remove((r, c));

        return res;
    }
}
