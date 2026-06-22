public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        var dic = new Dictionary<char, char>(){
            {'}', '{'},
            {']', '['},
            {')', '('}
        };

        foreach(var ch in s) {
            if(dic.ContainsKey(ch)){

                if(stack.Count > 0 && dic[ch] == stack.Peek()){
                        stack.Pop();
                }
                 else {
                    return false;
                 }       
            }
            else {
                stack.Push(ch);
            }
        }
        return stack.Count == 0;
    }
}
