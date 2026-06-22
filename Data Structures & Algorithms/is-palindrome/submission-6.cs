public class Solution {
    public bool IsPalindrome(string s) {
    var letters = new StringBuilder();

    foreach (var c in s.ToLower())
    {
        if (char.IsLetter(c) || char.IsNumber(c))
            letters.Append(c);            
    }
    int left = 0;
    int right = letters.Length - 1;

    while (left <= right)
    {
        if (letters[left] != letters[right])
            return false;
        left++;
        right--;
    }

    return true;
    }
}
