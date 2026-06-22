public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length) return false;

        int[] s1Arr = new int[26];
        int[] s2Arr = new int[26];
        for(var i = 0; i< s1.Length ;i++){
            s1Arr[s1[i] - 'a']++;
            s2Arr[s2[i] - 'a']++;
        }
        int matchs = 0;
        for(var i =0 ; i < 26 ; i++){
            if(s1Arr[i] == s2Arr[i])
                matchs++;
        }
        int l = 0;

        for(var r = s1.Length ; r < s2.Length; r++){
            if(matchs == 26)
                return true;

            int index = s2[r] - 'a';
            s2Arr[index]++;
            if(s1Arr[index] == s2Arr[index])
                matchs++;
            else if(s1Arr[index] + 1 == s2Arr[index])
                matchs--;
            
            index = s2[l] - 'a';
            s2Arr[index]--;
            if(s1Arr[index] == s2Arr[index])
                matchs++;
            else if(s1Arr[index] - 1 == s2Arr[index])
                matchs--;
            l++;
        }
        return matchs == 26;

    }
}
