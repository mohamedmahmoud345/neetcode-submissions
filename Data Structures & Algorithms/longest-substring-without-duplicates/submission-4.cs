public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var hashSet = new HashSet<char>();
        int res = 0;
        int l = 0;

        for(var i = 0; i < s.Length ; i++){
            while(hashSet.Contains(s[i])){
                hashSet.Remove(s[l]);
                l++;
            }
            hashSet.Add(s[i]);
            res = Math.Max(res , i - l + 1);
        }
        return res;
    }
}
