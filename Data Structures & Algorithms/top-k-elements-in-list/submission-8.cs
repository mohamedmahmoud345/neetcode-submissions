public class Solution {
      public int[] TopKFrequent(int[] nums, int k)
    {
        var dic = new Dictionary<int, int>();
        var queue = new PriorityQueue<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (!dic.ContainsKey(nums[i]))
                dic[nums[i]] = 1;

            dic[nums[i]]++;
        }

        foreach (var kvp in dic)
        {
            queue.Enqueue(kvp.Key, -kvp.Value);
        }

        var list = new List<int>();

        for(var i = 0; i < k; i++)
        {
            list.Add(queue.Dequeue());
        }
        return list.ToArray();
    }
}
