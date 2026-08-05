public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0, right = heights.Length - 1;
        int max = 0;

        while (left < right) {
            int number = (right - left) *
                Math.Min(heights[left], heights[right]);
            max = Math.Max(max, number);

            if (heights[left] >= heights[right])
                right--;
            else left++;
        }

        return max;
    }
}
