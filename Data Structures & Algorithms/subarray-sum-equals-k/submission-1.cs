public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int, int> dir = new Dictionary<int, int>();
        int count = 0, prefix = 0;
        for (int i = 0; i < nums.Length; i++) {
            prefix += nums[i];
            if (prefix == k) count++;
            
            if (dir.ContainsKey(prefix - k))
                count += dir[prefix - k];

            if (dir.ContainsKey(prefix)) dir[prefix]++;
            else dir.Add(prefix, 1);
        }

        return count;
    }
}