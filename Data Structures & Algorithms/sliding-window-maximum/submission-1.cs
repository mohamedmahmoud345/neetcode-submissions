public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var elements = new List<int>();
        int[] arr = new int[nums.Length];
        for(var i = 0; i < k ; i++){
            arr[i] = nums[i];
        }
        
        elements.Add(arr.Max());

        for(var i = k; i < nums.Length; i++){
            arr[i - k] = int.MinValue;
            arr[i] = nums[i];
            elements.Add(arr.Max());
        }

        return elements.ToArray();
    }
}
