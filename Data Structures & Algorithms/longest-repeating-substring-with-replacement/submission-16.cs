public class Solution {
    public int CharacterReplacement(string s, int k) {
        int res = 0;
        var charSet = new HashSet<char>(s);

        foreach(var c in s){
            int count = 0, l = 0;
            for(var r = 0; r < s.Length; r++){
                if(s[r] == c){
                    count++;
                }

                while((r - l + 1) - count > k){
                    if(s[l] == c){
                        count--;
                    }
                    l++;
                }

                res = Math.Max(res, r - l + 1);
            }
        }
        return res;
    }
}
