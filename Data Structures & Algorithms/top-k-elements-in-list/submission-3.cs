public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dic = new Dictionary<int,int>();

        foreach(var n in nums) {
            if(dic.ContainsKey(n))
                dic[n]++;
            else 
                dic.Add(n, 1);
        }

        List<int>[] freq = new List<int>[nums.Length + 1];
        for(var i = 0; i < freq.Length; i++){
            freq[i] = new List<int>();
        }
        foreach(var i in dic) {
            freq[i.Value].Add(i.Key);
        }

        int[] res = new int[k];
        int index = 0;
        for(var i = freq.Length - 1; i > 0&& index< k; i--){
            foreach(var n in freq[i])
            {
                res[index++] = n;
                if(index == k)
                    return res;
            }
        }
        return res;
    }
}
