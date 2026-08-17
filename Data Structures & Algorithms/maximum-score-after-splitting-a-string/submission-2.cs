public class Solution {
    public int MaxScore(string s) {
        int totalOnes = 0;
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '1') {
                totalOnes++;
            }
        }

        int totalZeros = 0, max = 0;
        for (int i = 0; i < s.Length - 1; i++) {
            if (s[i] == '0') {
                totalZeros++;
            }
            else totalOnes--;
            
            if (max < totalZeros + totalOnes) {
                max = totalZeros + totalOnes;
            }
        }

        return max;
    }
}