public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0; 
        int r = s.Length - 1;
        var sToLower = s.ToLower();
        
        while(l < r){
            while(l < r && char.IsLetterOrDigit(sToLower[l]) == false)
                l++;
            while(r > l && char.IsLetterOrDigit(sToLower[r]) == false)
                r--;
            
            if(sToLower[l] != sToLower[r])
                return false;
            
            l++;
            r--;
        }

        return true;
    }
}
