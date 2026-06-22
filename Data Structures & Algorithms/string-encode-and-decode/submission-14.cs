public class Solution {

    public string Encode(IList<string> strs) {
        var encode = "";
        foreach(var str in strs){
            encode += str.Length + "#" + str;
        }
        return encode;
    }

    public List<string> Decode(string s) {
        var res = new List<string>();
        var i = 0;
        while(i < s.Length) {
            int j = i;
            while(s[j] != '#'){
                j++;
            }
            var length = int.Parse(s.Substring(i , j - i));
            i = j + 1;
            j = i + length;
            res.Add(s.Substring(i , length));
            i = j;
        }
        return res;
   }
}
