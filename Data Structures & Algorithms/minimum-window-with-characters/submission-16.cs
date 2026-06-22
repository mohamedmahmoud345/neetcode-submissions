public class Solution {
    public string MinWindow(string s, string t) {
        if(t == "") return "";

        var countT = new Dictionary<char, int>();
        var window = new Dictionary<char, int>();

        foreach(var c in t){
             if(countT.ContainsKey(c))
                countT[c]++;
            else
                countT[c] = 1;
        }
        
        int have = 0, need = countT.Count;
        int[] res = {-1, -1};
        int resLen = int.MaxValue;
        int l = 0;

        for(var r = 0; r < s.Length; r++) {
            char ch = s[r];
            if(window.ContainsKey(ch)){
                window[ch]++;
            }else {
                window[ch] = 1;
            }

            if(countT.ContainsKey(ch) && countT[ch] == window[ch]){
                have++;
            }

            while(have == need) {
                if((r - l + 1) < resLen){
                    resLen = r - l + 1;
                    res[0] = l;
                    res[1] = r;
                }

                var leftChar = s[l];
                window[leftChar]--;
                if(countT.ContainsKey(leftChar) && window[leftChar] < countT[leftChar]){
                    have--;
                }
                l++;
            }
        }
        
        
        return resLen == int.MaxValue ? "" : s.Substring(res[0], resLen);
    }
    /*
    Core Idea:
    Use a sliding window (left, right pointers).
        Maintain two dictionaries:
            countT: frequency of characters in t
            window : frequency of characters in the current window of s.
        Track:
            Need: number of unique characters required.
            Have: number of unique characters currently satisfied in the window.
        Expand the window with right, and shrink it with left when all requirements are met.
    pseudo-code/ steps:
        Build frequency map of t → countt. 
        Initialize window dictionary, have = 0, need = countt.Count.
        Traverse s with right pointer:
            Add s[right] to window.
            If window[ch] == countt[ch], increment have.
        When have == need:
            Try to shrink window from left.
            Update result if current window is smaller.
            Remove s[left] from window and adjust have if requirement breaks.
            Move left forward.
        Return smallest valid window substring.

    */
}
