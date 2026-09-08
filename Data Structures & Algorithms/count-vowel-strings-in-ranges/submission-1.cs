public class Solution {
    public int[] VowelStrings(string[] words, int[][] queries) {
        int[] result = new int[queries.Length];
        int[] dp = new int[words.Length];
        int count = 0;

        for (int i = 0; i < words.Length; i++) {
            int n = words[i].Length - 1;
            if (IsVowel(words[i][0]) && IsVowel(words[i][n])) count++;
            dp[i] = count;
        }

        for (int i = 0; i < queries.Length; i++) {
            int l = queries[i][0], r = queries[i][1];
            result[i] = dp[r];
            if (l > 0) result[i] -= dp[l - 1];
        }

        return result;
    }

    public bool IsVowel(char c) =>
        c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
}