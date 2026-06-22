public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        var list = new List<string>();
        var stack = "";
        BackTrack(n , 0 , 0 , list , stack);
        return list;
    }

    private void BackTrack(int n , int open , int close , List<string> list , string res) {
        if(open == close && open == n){
            list.Add(res);
            return;
        }

        if(open < n){
            BackTrack(n , open + 1 , close , list , res + "(");
        }
        if(close < open){
            BackTrack(n , open , close + 1 , list , res + ")");
        }

    }
}
