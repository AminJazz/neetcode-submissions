public class Solution {
    public int MajorityElement(int[] nums) {
        Array.Sort(nums);

        int count = 1, ele = nums[0], maxCount = 1;
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] == nums[i - 1]) {
                count++;
                if (maxCount < count) {
                    ele = nums[i];
                    maxCount = count;
                }
            }
            else count = 1;
        }

        return ele;
    }
}