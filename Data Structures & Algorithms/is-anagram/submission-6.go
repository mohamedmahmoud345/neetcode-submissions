func isAnagram(s string, t string) bool {
	if len(s) != len(t) {
		return false
	}

	arr1 := [26]int{}
	arr2 := [26]int{}

	for i := 0; i < len(s); i++ {
		arr1[s[i] - 'a']++
		arr2[t[i] - 'a']++
	}

	for i := 0 ; i < 26;i++ {
		if arr1[i] != arr2[i]{
			return false
		}
	}

	return true
}
