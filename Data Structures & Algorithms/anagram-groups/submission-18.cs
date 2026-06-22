public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string, List<string>>();

        foreach(var str in strs) {
            var arr = new int[26];

            for(var i = 0; i < str.Length; i++){
                arr[str[i] - 'a']++;
            }
            var joinArr = string.Join(',', arr);

            if(dic.ContainsKey(joinArr))
                dic[joinArr].Add(str);
            else 
                dic[joinArr] = new List<string>(){str};
        }

        return dic.Values.ToList();
    }
}
