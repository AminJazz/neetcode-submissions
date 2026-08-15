public class Solution {
    public int MaxProductDifference(int[] nums) {
        int max1 = -1, max2 = -1, min1 = 10002, min2 = 10002;

        for (int i = 0; i < nums.Length; i++) {
            if (max1 <= nums[i]) {
                max2 = max1;
                max1 = nums[i];
            }
            else if (max2 <= nums[i]) {
                max2 = nums[i];
            }

            if (min1 >= nums[i]) {
                min2 = min1;
                min1 = nums[i];
            }
            else if (min2 >= nums[i]) {
                min2 = nums[i];
            }
        }

        return (max1 * max2) - (min1 * min2);
    }
}