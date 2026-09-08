public class Solution {
    public int[] VowelStrings(string[] words, int[][] queries) {
        int[] result = new int[queries.Length];
        
        for (int i = 0; i < queries.Length; i++) {
            int j = queries[i][0];
            while (j <= queries[i][1]) {
                int n = words[j].Length - 1;
                if (IsVowel(words[j][0]) && IsVowel(words[j][n])) result[i]++;
                j++;
            }
        }

        return result;
    }

    public bool IsVowel(char c) =>
        c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
}