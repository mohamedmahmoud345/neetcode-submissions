public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        var dic = new Dictionary<char, char>(){
            {')' , '('},
            {'}' , '{'},
            {']' , '['}
        };

        foreach(var c in s) {
            if(dic.ContainsKey(c)){
                if(stack.Count > 0 && stack.Peek() == dic[c])
                    stack.Pop();
                else 
                    return false;
            }
            else 
                stack.Push(c);
        }

        return stack.Count == 0;
    }
}
