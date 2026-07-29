public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dir = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            if (dir.ContainsKey(nums[i]))
                dir[nums[i]]++;
            else
                dir.Add(nums[i], 1);
        }

        var sorted = dir.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();
        return sorted;
    }
}
