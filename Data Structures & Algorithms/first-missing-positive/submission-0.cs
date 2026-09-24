public class Solution {
    public int FirstMissingPositive(int[] nums) {
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] < 0) nums[i] = 0;
        
        for (int i = 0; i < nums.Length; i++) {
            int val = Math.Abs(nums[i]);
            if (val - 1 < nums.Length && val > 0) {
                if (nums[val - 1] == 0) {
                    nums[val - 1] = (nums.Length + 1) * -1;
                }
                else if (nums[val - 1] > 0) {
                    nums[val - 1] *= -1;
                }
            }
        }

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] >= 0) return i + 1;
        }

        return nums.Length + 1;
    }
}