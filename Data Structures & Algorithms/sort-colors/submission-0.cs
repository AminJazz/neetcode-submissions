public class Solution {
    public void SortColors(int[] nums) {
        int r = 0, w = 0, b = nums.Length - 1;
        while (w <= b) {
            if (nums[w] == 1) w++;
            else if (nums[w] == 0) {
                SwapArray(nums, r, w);
                r++;
                if (r > w) w++;
            }
            else if (nums[w] == 2) {
                SwapArray(nums, w, b);
                b--;
            }
        }
    }

    void SwapArray(int[] arr, int i, int j) {
        (arr[i], arr[j]) = (arr[j], arr[i]);
    }
}