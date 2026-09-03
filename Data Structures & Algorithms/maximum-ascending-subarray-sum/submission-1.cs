public class Solution {
    public int MaxAscendingSum(int[] nums) {
        int count = nums[0], max = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] > nums[i - 1]) {
                count += nums[i];
            }
            else count = nums[i];

            max = Math.Max(count, max);
        }

        return max;
    }
}