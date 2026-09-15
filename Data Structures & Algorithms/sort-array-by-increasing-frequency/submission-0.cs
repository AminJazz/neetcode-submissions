public class Solution {
    public int[] FrequencySort(int[] nums) {
        Dictionary<int, int> dir = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            if (dir.ContainsKey(nums[i]))
                dir[nums[i]]++;
            else dir.Add(nums[i], 1);
        }

        var sorted = dir.OrderBy(v => v.Value).ThenByDescending(k => k.Key);
        int index = 0;
        foreach (var item in sorted) {
            int count = item.Value;
            while (count > 0) {
                nums[index++] = item.Key;
                count--;
            }
        }

        return nums;
    }
}