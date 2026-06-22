public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        var dic = new Dictionary<char,int>();
        foreach(var c in s)
        {
            if(dic.ContainsKey(c))
                dic[c] += 1;
            else
                dic[c] = 1;
        }

        for(var i = 0 ; i < t.Length; i++) {
            if(!dic.ContainsKey(t[i]))
                return false;
            dic[t[i]] -= 1;

            if(dic[t[i]] == 0)
                dic.Remove(t[i]);
        }

        return dic.Count == 0;
    }
}
