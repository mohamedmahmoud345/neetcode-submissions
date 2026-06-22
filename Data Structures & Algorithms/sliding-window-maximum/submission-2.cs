public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var n = nums.Length;
        var arr = new int[n - k + 1];
        int l = 0, r = 0;
        var q = new LinkedList<int>();
        while(r < n){
            while(q.Count > 0 && nums[q.Last.Value] < nums[r])
            {
                q.RemoveLast();
            }
            
            q.AddLast(r);

            if(l > q.First.Value)
            {
                q.RemoveFirst();
            }
            
            if((r + 1) >= k){
                arr[l] = nums[q.First.Value];
                l++;
            }
            r++;
        }

        return arr;
    }
}
