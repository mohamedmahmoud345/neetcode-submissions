public class Solution {
    public string MinWindow(string s, string t) {
        if(t == "")
            return "";

        var countt = new Dictionary<char, int>();
        var window = new Dictionary<char, int>();
        
        foreach(var c in t) {
            if(countt.ContainsKey(c))
                countt[c]++;
            else
                countt[c] = 1;
        }

        int have = 0, need = countt.Count;
        int[] res = [-1, -1];
        int resLen = int.MaxValue;
        int l = 0;


        for(var r = 0; r < s.Length; r++){
            var ch = s[r];
            if(window.ContainsKey(ch)){
                window[ch]++;
            }else {
                window[ch] = 1;
            }

            if(countt.ContainsKey(ch) && window[ch] == countt[ch]){
                have++;
            }

            while(have == need){
                if((r -l + 1) < resLen){
                    resLen = r - l + 1;
                    res[0] = l;
                    res[1] = r;
                }

                var leftChar = s[l];
                window[leftChar]--;
                if(countt.ContainsKey(leftChar) && window[leftChar] < countt[leftChar]){
                    have--;
                }
                l++;
            }
        }
        return resLen == int.MaxValue? "" : s.Substring(res[0], resLen);

    }
}
