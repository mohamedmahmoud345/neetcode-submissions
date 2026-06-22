func twoSum(nums []int, target int) []int {
    
   res := [2]int{}
	for i := 0; i < len(nums); i++ {
		num := target - nums[i]
		for idx, v := range nums {
			if num == v && idx != i {
				res[0] = idx
				res[1] = i
			}
		}
	}

	return res[:]
}
