public class Solution {
    public bool IsMonotonic(int[] nums) {
        bool isIncreasing = false;
        int i = 0;
        for (i = 0; i < nums.Length - 1; i++) {
            if (nums[i] != nums[i + 1] && nums[i] < nums[i + 1]) {
                isIncreasing = true;
                break;
            }
            else if (nums[i] != nums[i + 1]) break;
        }

        for (; i < nums.Length - 1; i++) {
            if (isIncreasing) {
                if (nums[i] > nums[i + 1]) return false;
            }
            else {
                if (nums[i] < nums[i + 1]) return false;
            }
        }

        return true;
    }
}