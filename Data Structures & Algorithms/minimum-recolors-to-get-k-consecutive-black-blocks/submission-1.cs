public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        int count = 0;
        for (int i = 0; i < k; i++) {
            if (blocks[i] == 'W') count++;
        }

        int minCount = count, j = 1;
        while (j < blocks.Length - k) {
            if (blocks[j + k - 1] == 'W') count++;
            if (blocks[j - 1] == 'W') count--;

            minCount = Math.Min(minCount, count);
            j++;
        }

        return minCount;
    }
}