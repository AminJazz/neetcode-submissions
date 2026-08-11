public class Solution {
    public int HeightChecker(int[] heights) {
        int[] copy = new int[heights.Length];
        for (int i = 0; i < heights.Length; i++) {
            copy[i] = heights[i];
        }
        
        Array.Sort(copy);
        int result = 0;

        for (int i = 0; i < heights.Length; i++) {
            if (heights[i] != copy[i]) result++;
        }

        return result;
    }
}