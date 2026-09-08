public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int, int> dir = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            if (dir.ContainsKey(nums[i])) {
                if (i - dir[nums[i]] <= k) return true;
                else dir[nums[i]] = i;
            }
            else dir[nums[i]] = i;
        }

        return false;
    }
}