public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int[] result = new int[2];
        int sum = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[Math.Abs(nums[i]) - 1] > 0) {
                nums[Math.Abs(nums[i]) - 1] *= -1;
            }
            else {
                result[0] = Math.Abs(nums[i]);
            }

            sum += Math.Abs(nums[i]);
        }

        int expected = (nums.Length * (nums.Length + 1)) / 2;
        result[1] = expected - (sum - result[0]);

        return result;
    }
}