public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string, List<string>>();

        for (var i = 0; i < strs.Length; i++)
        {
            int[] arr = new int[26];
            for (var j = 0; j < strs[i].Length; j++)
            {
                arr[strs[i][j] - 'a']++;
            }
            var key = string.Join(',' , arr);

            if (dic.ContainsKey(key))
            {
                dic[key].Add(strs[i]);
            }
            else
                dic[key] = new List<string>(){strs[i]};
        }

        return dic.Values.ToList();
    }
}
