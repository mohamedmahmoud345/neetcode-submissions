public class Solution {
    public string MinWindow(string s, string t) {
        if (t == "") return "";

    var tCount = new Dictionary<char, int>();
    var window = new Dictionary<char, int>();

    for (var i = 0; i < t.Length; i++)
    {
        if (tCount.ContainsKey(t[i]))
            tCount[t[i]]++;
        else
            tCount[t[i]] = 1;
    }

    int have = 0, need = tCount.Count;
    int[] res = {-1, -1};
    int resLength = int.MaxValue;
    int l = 0;

    for (var r = 0; r < s.Length; r++)
    {
        var ch = s[r];
        if (window.ContainsKey(ch))
            window[ch]++;
        else
            window[ch] = 1;

        if (tCount.ContainsKey(ch) && tCount[ch] == window[ch])
            have++;

        while (have == need)
        {
            if ((r - l + 1) < resLength)
            {
                resLength = r - l + 1;
                res[0] = l;
                res[1] = r;
            }

            var leftChar = s[l];
            window[leftChar]--;
            if (tCount.ContainsKey(leftChar) && window[leftChar] < tCount[leftChar])
                have--;

            l++;
        }
    }

    return resLength == int.MaxValue ? "" : s.Substring(res[0], resLength);
    }
}

