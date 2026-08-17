public class Solution {
    public int MaxScore(string s) {
        int[] zeros = new int[s.Length];
        int[] ones = new int[s.Length];

        for (int i = 0; i < s.Length; i++) {
            if (i == 0) {
                if (s[i] == '0') zeros[i] = 1;
                else zeros[i] = 0;
            }
            else if (s[i] == '0')
                zeros[i] = zeros[i - 1] + 1;
            else zeros[i] = zeros[i - 1];
        }

        for (int i = s.Length - 1; i >= 0; i--) {
            if (i == s.Length - 1) {
                if (s[i] == '1') ones[i] = 1;
                else ones[i] = 0;
            }
            else if (s[i] == '1')
                ones[i] = ones[i + 1] + 1;
            else ones[i] = ones[i + 1];
        }

        int max = 0;
        for (int i = 1; i < s.Length; i++) {
            if (max < ones[i] + zeros[i - 1])
                max = ones[i] + zeros[i - 1];
        }

        return max;
    }
}