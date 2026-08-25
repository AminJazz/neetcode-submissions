public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int total = 0, count = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 1) {
                count++;
            }
            else count = 0;

            total = total > count ? total : count;
        }

        return total;
    }
}