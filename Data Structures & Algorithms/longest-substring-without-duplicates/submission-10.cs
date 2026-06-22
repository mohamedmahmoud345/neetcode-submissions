public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var hashSet = new HashSet<char>();
        int l = 0;
        int res = 0;

        for(var r =0 ; r < s.Length; r++){
            while(hashSet.Contains(s[r])){
                hashSet.Remove(s[l]);
                l++;
            }
            hashSet.Add(s[r]);
            res = Math.Max(res, r - l + 1);
        }
        return res;
    }
}
