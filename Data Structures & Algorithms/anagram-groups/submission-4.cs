public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string,List<string>>();      

        foreach(var str in strs) {
            var count = new int[26];

            foreach(var c in str){
                count[c - 'a']++;
            }

            var charCount = string.Join(',' , count);
            if(!dic.ContainsKey(charCount))
                dic.Add(charCount, new List<string>{});

            dic[charCount].Add(str);
        }

        return dic.Values.ToList();
    }
}
