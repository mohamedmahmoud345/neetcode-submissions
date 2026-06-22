public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();


        for(var i = 0; i < strs.Length; i++){            
            int[] arrCount = new int[26];
            for(var j = 0; j < strs[i].Length; j++){
                arrCount[strs[i][j] - 'a']++;
            }

            var arrToString = string.Join("," , arrCount);

            if(!map.ContainsKey(arrToString)){
                map[arrToString] = new List<string>();
            }
            map[arrToString].Add(strs[i]);
        }

        return map.Values.ToList();
    }
}
