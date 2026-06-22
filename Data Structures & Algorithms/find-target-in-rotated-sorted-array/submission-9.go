func search(nums []int, target int) int {
	n := len(nums)
	l := 0
	r := n - 1 

	for l < r {
		mid := (l + r) / 2
		if nums[mid] > nums[r] {
			l = mid + 1
		}else {
			r = mid 
		}

	}
	
	pivot := l

	var binarySearch func(left, right int) int 
	binarySearch = func(left, right int) int {
		for left <= right {
            mid := (left + right) / 2
            if nums[mid] == target {
                return mid
            } else if nums[mid] < target {
                left = mid + 1
            } else {
                right = mid - 1
            }
        }
        return -1
	}
	result := binarySearch(0 , pivot - 1)

	if result != - 1{
		return result
	}
	return binarySearch(pivot, n - 1)
}
