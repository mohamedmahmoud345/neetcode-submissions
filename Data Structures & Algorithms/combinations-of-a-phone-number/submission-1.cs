public class Solution {
    private Dictionary<int, string> dic = new() {
        {2, "abc"},
        {3, "def"},
        {4, "ghi"},
        {5, "jkl"},
        {6, "mno"},
        {7, "pqrs"},
        {8, "tuv"},
        {9, "wxyz"}
    };
    private List<string> res = new();
    private StringBuilder path = new();
    public List<string> LetterCombinations(string digits) {
        if(digits.Length == 0)
            return [];
        DFS(0, digits, path);
        return res;
    }

    private void DFS(int i, string digits, StringBuilder path){
        if(i >= digits.Length){
            var s = path.ToString();
            res.Add(s);
            return;
        }
        var letters = dic[digits[i] - '0'];

        foreach(var c in letters){
            path.Append(c);
            DFS(i + 1, digits, path);
            path.Remove(path.Length - 1, 1);
        }
    }
}
