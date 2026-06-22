func subsets(nums []int) [][]int {
	res := [][]int{}
	subSet := []int{}

	var dfs func(int)

	dfs = func(i int) {
		if i >= len(nums) {
			temp := make([]int, len(subSet))
			copy(temp, subSet)
			res = append(res, temp)
			return 
		}

		subSet = append(subSet, nums[i])
		dfs(i + 1)
		subSet = subSet[:len(subSet) - 1]
		dfs(i + 1)
	}
	dfs(0)

	return res
}
