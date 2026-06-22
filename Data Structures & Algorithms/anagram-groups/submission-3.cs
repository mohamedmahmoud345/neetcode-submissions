public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
     
        var dic = new Dictionary<string, List<string>>();
        foreach(var str in strs)
        {
            var sort = new String(str.Order().ToArray());
            if (!dic.ContainsKey(sort))
                dic.Add(sort, new List<string>{});
        }

        for (var i = 0; i < strs.Length; i++)
        {
            var sort = new String(strs[i].Order().ToArray());
            if(dic.ContainsKey(sort)){
                dic[sort].Add(strs[i]);
            }
        }

        return dic.Values.ToList();
    }
}
