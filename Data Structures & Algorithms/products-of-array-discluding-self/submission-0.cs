public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] left = new int[n];
        int[] right = new int[n];
        int[] output = new int[n];
        left[0] = 1;
        right[n - 1] = 1;

        //calculate prefix
        for (int i = 1; i < n; i++) {
            left[i] = left[i - 1] * nums[i - 1];
        }

        //calculate suffix
        for (int i = n - 2; i >= 0; i--) {
            right[i] = right[i + 1] * nums[i + 1];
        }

        //multiply both except current element
        for (int i = 0; i < n; i++) {
            output[i] = left[i] * right[i];
        }

        return output;
    }
}
