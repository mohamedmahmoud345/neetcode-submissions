public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dic = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (!dic.ContainsKey(nums[i]))
                dic[nums[i]] = 0;
            dic[nums[i]]++;
        }

        var buckets = new List<int>[nums.Length + 1];
        
        for (var i = 0; i < buckets.Length; i++)
        {
            buckets[i] = new List<int>();
        }
        foreach (var kvp in dic)
        {
            buckets[kvp.Value].Add(kvp.Key);
        }

        int[] res = new int[k];
        int index = 0;
        for(var i = buckets.Length - 1; i > 0 && index < k; i--){
            foreach(var n in buckets[i]){
                res[index++] = n;
                if(index == k)
                    return res;
            }
        }

        return res;
    }
}
