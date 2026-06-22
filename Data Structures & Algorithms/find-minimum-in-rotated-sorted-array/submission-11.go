func findMin(nums []int) int {
    n := len(nums)
    l := 0
    r := n - 1
    res := nums[l]
   
    for l <= r {
        if nums[l] < nums[r] {
            if nums[l] < res {
                res = nums[l]
            }
            break;
        }

        m := (l + r) / 2
       
        if nums[m] < res {
            res = nums[m]
        }

        if nums[m] > nums[r]{
            l = m + 1
        }else {
            r = m - 1
        }
    }
    return res
}
