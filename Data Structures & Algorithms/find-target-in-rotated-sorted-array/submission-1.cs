public class Solution {
    public int Search(int[] nums, int target) {
        int min = FindMinIndex(nums); //O(log n)
        int left = 0, right = nums.Length - 1;
        if (nums[min] == target) return min;
        if (min > 0 && nums[min - 1] >= target && nums[left] <= target) right = min - 1;
        else left = min;

        while (left <= right) { //O(log n)
            int mid = left + (right - left) / 2;
            if (nums[mid] == target) return mid;
            else if (nums[mid] > target) right = mid - 1;
            else left = mid + 1;
        }

        return -1;
    }

    public int FindMinIndex(int[] nums) {
        int left = 0, right = nums.Length - 1;
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (nums[mid] > nums[nums.Length - 1]) left = mid + 1;
            else right = mid;
        }

        return left;
    }
}
