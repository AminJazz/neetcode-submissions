public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int rowCount = grid[0].Length;
        int colCount = grid.Length;
        int[] arr = new int[(rowCount * colCount) + 1];

        for (int i = 0; i < grid.Length; i++) {
            for (int j = 0; j < grid[i].Length; j++) {
                arr[grid[i][j]]++;
            }
        }
        
        int[] result = new int[2];
        for (int i = 1; i < arr.Length; i++) {
            if (arr[i] > 1) {
                result[0] = i;
                continue;
            }

            if (arr[i] == 0) {
                result[1] = i;
                continue;
            }
        }

        return result;
    }
}