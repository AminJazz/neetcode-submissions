public class Solution {
    public int[] RearrangeArray(int[] nums) {
        int[] arr = new int[nums.Length];
        int p = 0, n = 1;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > 0) {
                arr[p] = nums[i];
                p += 2;
            }
            else {
                arr[n] = nums[i];
                n += 2;
            }
        }

        return arr;
    }
}