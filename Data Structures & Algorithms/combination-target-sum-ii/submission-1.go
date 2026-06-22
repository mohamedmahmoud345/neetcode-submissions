func combinationSum2(candidates []int, target int) [][]int {
	sort.Ints(candidates)

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

		if i >= len(candidates) || sum > target {
			return 
		}

		sub = append(sub, candidates[i])
		dfs(i + 1, sum + candidates[i])
		sub = sub[:len(sub)-1]

		for i + 1 < len(candidates) && candidates[i] == candidates[i+1]{
			i++
		}
		dfs(i+1, sum)
	}

	dfs(0, 0)

	return res
}
