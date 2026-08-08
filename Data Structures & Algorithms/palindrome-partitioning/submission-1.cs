public class Solution {
    private List<List<string>> res = new();
    private List<string> part = new();
    public List<List<string>> Partition(string s) {
        DFS(0, 0, s);
        return res;
    }

    private void DFS(int j, int i, string s) {
        if(i >= s.Length){
            if(i == j){
                res.Add(new List<string>(part));
            }
            return;
        }

        if(IsPali(s, j, i)) {
            part.Add(s.Substring(j, i - j + 1));
            DFS(i + 1, i + 1, s);
            part.RemoveAt(part.Count - 1);
        }
        DFS(j, i + 1, s);
    }

    private bool IsPali(string s, int l, int r){
        while(l < r){
            if(s[l] != s[r]){
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
}
