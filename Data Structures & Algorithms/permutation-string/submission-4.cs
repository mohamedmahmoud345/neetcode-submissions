public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length) return false;

        int[] s1arr = new int[26];
        int[] s2arr = new int[26];

        for(var i = 0 ; i < s1.Length;i++){
            s1arr[s1[i] - 'a']++;
            s2arr[s2[i] - 'a']++;
        }

        var matches = 0;
        for(var i =0 ;i < 26; i++){
            if(s1arr[i] == s2arr[i])
                matches++;
        }
        
        int l = 0;
        for(var r = s1.Length; r < s2.Length; r++){
            if(matches == 26)
                return true;

            var index = s2[r] - 'a';
            s2arr[index]++;
            if(s1arr[index] == s2arr[index]){
                matches++;
            }
            else if(s1arr[index] + 1 == s2arr[index]) {
                matches--;
            }

            index = s2[l] - 'a';
            s2arr[index]--;
            if(s1arr[index] == s2arr[index]){
                matches++;
            }
            else if(s1arr[index] - 1 == s2arr[index])
            {
                matches--;
            }
            l++;
        }
        return matches == 26;
    }
}
