public class Solution {
    public int MinOperations(string s) {
        int expected = (s[0] - '0' == 0) ? 1 : 0;
        int count = 0, minCount = 0;
        for (int i = 1; i < s.Length; i++) {
            if (expected != s[i] - '0') {
                count++;
            }
            expected = expected == 1 ? 0 : 1;
        }

        return (count < s.Length - count) ? count : s.Length - count;
    }
}