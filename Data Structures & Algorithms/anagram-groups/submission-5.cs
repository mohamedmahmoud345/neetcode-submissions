public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string,List<string>>();

        foreach(var str in strs) {
           var charNumbers = new int[26];
            
            foreach(var c in str)
            {
                charNumbers[c-'a']++;
            }
            var arrayAsString = string.Join(',',charNumbers);
            if(dic.ContainsKey(arrayAsString)){
                dic[arrayAsString].Add(str);
            }
            else 
                dic.Add(arrayAsString, new List<string>{str});
        }
        return dic.Values.ToList();
    }
}
