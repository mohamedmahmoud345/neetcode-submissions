public class Solution {
    public int CharacterReplacement(string s, int k) {
        var dic = new Dictionary<char,int>();
        int res = 0;
        int left = 0, maxf = 0;

        for(var right = 0; right < s.Length ; right++){
            if(dic.ContainsKey(s[right]))
                dic[s[right]]++;
            else 
                dic[s[right]] = 1;
            
            maxf = Math.Max(maxf , dic[s[right]]);

            while((right - left + 1) - maxf > k){
                dic[s[left]]--;
                left++;
            }
            res = Math.Max(res,right - left + 1);
        }
        return res;
    }
}
