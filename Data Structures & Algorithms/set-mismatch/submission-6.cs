public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++) {
            if (nums[Math.Abs(nums[i]) - 1] > 0) {
                nums[Math.Abs(nums[i]) - 1] *= -1;
            }
            else {
                result[0] = Math.Abs(nums[i]);
            }
        }

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > 0) {
                result[1] = i + 1;
                break;
            }
        }

        return result;
    }
}