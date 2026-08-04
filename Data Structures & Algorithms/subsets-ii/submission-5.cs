public class Solution {
    private List<List<int>> res;
    public List<List<int>> SubsetsWithDup(int[] nums) {
        res = new List<List<int>>();
        Array.Sort(nums);
        Backtracking(0, nums, new List<int>());
        return res;
    }
    
    private void Backtracking(int idx,int[] nums, List<int> path){
        res.Add(new List<int>(path));

        for(var i = idx; i < nums.Length; i++){
            if(i > idx && nums[i] == nums[i - 1]){
                continue;
            }

            path.Add(nums[i]);
            Backtracking(i + 1, nums, path);
            path.RemoveAt(path.Count - 1);
        }
    }
}
