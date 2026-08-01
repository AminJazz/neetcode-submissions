public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        int maxConsecutiveLenth = 0;

        for (int i = 0; i < nums.Length; i++)
            set.Add(nums[i]);

        foreach (var item in set)
        {
            if (set.Contains(item - 1))
                continue;
            else
            {
                int count = 1;
                while (set.Contains(item + count))
                    count++;

                maxConsecutiveLenth = Math.Max(maxConsecutiveLenth, count);
            }
        }

        return maxConsecutiveLenth;
    }
}
