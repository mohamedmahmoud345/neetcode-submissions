public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var list = new List<List<int>>();
    var hashset = new HashSet<string>();
    for (var i = 0; i < nums.Length; i++)
    {
        for (var j = i + 1; j < nums.Length; j++)
        {
            for (var f = j + 1; f < nums.Length; f++)
            {
                if (nums[i] + nums[j] + nums[f] == 0)
                {
                    List<int> arr =new List<int> {nums[i], nums[j], nums[f]};
                    arr.Sort();
                    var str = $"{arr[0]}{arr[1]}{arr[2]}";
                    if (!hashset.Contains(str))
                    {
                        list.Add(arr);
                        hashset.Add(str);
                    }
                }
            }
        }
    }
    return list.ToList();
    }
}
