public class Solution {
    public int LengthOfLongestSubstring(string s) {
 var maxLength = 0;
    var hashset = new HashSet<char>();
    int l = 0;
    for (var i = 0; i < s.Length; i++)
    { 
        while(hashset.Contains(s[i])){
            hashset.Remove(s[l]);
            l++;
        }
    
        hashset.Add(s[i]);
            maxLength = Math.Max(maxLength, i - l + 1);
    }
    return maxLength;
    }
}
