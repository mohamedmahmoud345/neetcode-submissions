public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dic = new Dictionary<int, int>();

    for (var i = 0; i < nums.Length; i++)
    {
        if (dic.ContainsKey(nums[i]))
        {
            dic[nums[i]] += 1;
        }
        else
        {
            dic.Add(nums[i], 1);
        }
    }
    var sortValues = dic.Values.OrderDescending().ToArray();
    List<int> list = new List<int>();
    for (var i = 0; i < k; i++)
    {
        int key = dic.FirstOrDefault(x => x.Value == sortValues[i] && !list.Contains(x.Key)).Key;

            list.Add(key);
    }

    return list.ToArray();
    }
}
