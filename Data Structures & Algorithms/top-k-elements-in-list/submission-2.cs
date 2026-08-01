public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dir = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            if (dir.ContainsKey(nums[i]))
                dir[nums[i]]++;
            else
                dir.Add(nums[i], 1);
        }
        
        List<int>[] data = new List<int>[nums.Length + 1];
        foreach (var item in dir) {
            if (data[item.Value] == null) {
                data[item.Value] = new List<int>();
            }
            data[item.Value].Add(item.Key);
        }

        List<int> result = new List<int>();
        for (int i = data.Length - 1; i >= 0 && result.Count < k; i--) {
            if (data[i] != null) {
                result.AddRange(data[i]);
            }
        }

        return result.ToArray();
    }
}
