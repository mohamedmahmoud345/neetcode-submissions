public class Solution {
    private List<List<int>> res;
    public List<List<int>> Permute(int[] nums) {
        res = new List<List<int>>();
        BackTrack(new List<int>(), nums, new bool[nums.Length]);
        return res;
    }
    private void BackTrack(List<int> perm, int[] nums, bool[] pick){
            
        if(perm.Count == nums.Length){
            res.Add(new List<int>(perm));
            return;
        }

        for(var i = 0; i < nums.Length; i++){
            if(pick[i])
                continue;

            perm.Add(nums[i]);
            pick[i] = true;

            BackTrack(perm, nums, pick);
            perm.RemoveAt(perm.Count - 1);
            pick[i] = false;
        }
    }
}
