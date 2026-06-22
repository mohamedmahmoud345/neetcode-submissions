public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        int[] sArr = new int[26];
        int[] tArr = new int[26];

        for(var i = 0; i < s.Length; i++){
            sArr[s[i] - 'a']++;
            tArr[t[i] - 'a']++;
        }

        for(var i = 0; i < 26; i++){
            if(sArr[i] != tArr[i])
                return false;
        }
        return true;
    }
}
