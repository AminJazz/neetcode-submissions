public class Solution {
    public int MaxLengthBetweenEqualCharacters(string s) {
        int result = -1;

        for (int i = 0; i < s.Length; i++) {
            for (int j = i + 1; j < s.Length; j++) {
                if (s[i] == s[j])
                    result = Math.Max(result, j - i - 1);
            }
        }

        return result;
    }
}