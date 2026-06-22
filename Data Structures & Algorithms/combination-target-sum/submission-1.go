func combinationSum(nums []int, target int) [][]int {
	res := [][]int{}
	sub := []int{}

	var dfs func(int, int)

	dfs = func(i int, sum int) {
		if sum == target {
			temp := make([]int, len(sub))
			copy(temp, sub)
			res = append(res, temp)
			return
		}

		if i >= len(nums) || sum > target {
			return 
		}

		sub = append(sub, nums[i])
		dfs(i, sum+nums[i])
		sub = sub[:len(sub)-1]
		dfs(i+1, sum)
	}

	dfs(0, 0)

	return res
}
