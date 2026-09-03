public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> dir = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            if (dir.ContainsKey(nums[i])) dir[nums[i]]++;
            else dir.Add(nums[i], 1);
        }

        int max = 0, key = 0;
        foreach (var v in dir) {
            if (v.Value > max) {
                key = v.Key;
                max = v.Value;
            }
        }

        return key;
    }
}