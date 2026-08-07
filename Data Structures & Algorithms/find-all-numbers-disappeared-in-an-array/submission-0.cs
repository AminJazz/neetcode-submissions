public class Solution {
    public List<int> FindDisappearedNumbers(int[] nums) {
        List<int> result = new List<int>();

        for (int i = 0; i < nums.Length; i++) {
            int abs = Math.Abs(nums[i]) - 1;
            if (nums[abs] > 0)
                nums[abs] *= -1;
        }
        
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > 0) result.Add(i + 1);
        }

        return result;
    }
}