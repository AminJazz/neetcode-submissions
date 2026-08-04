public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dir = new Dictionary<int, int>();
        dir[target - nums[0]] = 0;

        for (int i = 1; i < nums.Length; i++) {
            int diff = target - nums[i];
            if (dir.ContainsKey(nums[i]))
                return new int[] { dir[nums[i]], i };
            else
                dir[diff] = i;
        }

        return new int[] {};
    }
}
