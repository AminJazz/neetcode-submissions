public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int[] prefix = new int[nums.Length];
        prefix[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
            prefix[i] = prefix[i - 1] + nums[i];
        
        Dictionary<int, int> dir = new Dictionary<int, int>();
        int count = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (prefix[i] == k) count++;
            
            if (dir.ContainsKey(prefix[i] - k))
                count += dir[prefix[i] - k];

            if (dir.ContainsKey(prefix[i])) dir[prefix[i]]++;
            else dir.Add(prefix[i], 1);
        }

        return count;
    }
}