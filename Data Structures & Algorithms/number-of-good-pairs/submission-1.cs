public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int[] arr = new int[101];
        for (int i = 0; i < nums.Length; i++) {
            arr[nums[i]]++;
        }

        int result = 0;
        for (int i = 0; i < arr.Length; i++) {
            result += (arr[i] * (arr[i] - 1)) / 2;
        }

        return result;
    }
}