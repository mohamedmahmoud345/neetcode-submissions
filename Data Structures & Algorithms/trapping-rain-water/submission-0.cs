public class Solution {
    public int Trap(int[] height) {
         var result = 0;
    for (var i = 1; i < height.Length - 1; i++)
    {
        int left = 0;
        int right = height.Length - 1;

        int GreaterNumInLeft = -1;
        int GreaterNumInRight = -1;
        while (left < i)
        {
            GreaterNumInLeft = Math.Max(GreaterNumInLeft, height[left]);
            left++;
        }
        while (right > i)
        {
            GreaterNumInRight = Math.Max(GreaterNumInRight, height[right]);
            right--;
        }
        var minBar = Math.Min(GreaterNumInLeft, GreaterNumInRight);
        if (minBar - height[i] > 0)
            result += minBar - height[i];

    }

    return result;
    }
}
