public class Solution {
    public bool DivideArray(int[] nums) {
        int[] arr = new int[501];

        for (int i = 0; i < nums.Length; i++) {
            arr[nums[i]]++;
        }

        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] % 2 != 0) return false;
        }

        return true;
    }
}