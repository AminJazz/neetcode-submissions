public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int left = 0, right = matrix.Length - 1;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            // find mid
            // check first and last element of mid row
            if (matrix[mid][0] <= target && matrix[mid][matrix[mid].Length - 1] >= target) {
                for (int i = 0; i < matrix[mid].Length; i++) {
                    if (matrix[mid][i] == target)
                        return true;
                }

                return false;
            }
            else if (matrix[mid][0] >= target) {
                right = mid - 1;
            }
            else {
                left = mid + 1;
            }
        }

        return false;
    }
}
