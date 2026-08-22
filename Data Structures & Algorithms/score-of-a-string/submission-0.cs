public class Solution {
    public int ScoreOfString(string s) {
        int sum = 0;
        for (int i = 0; i < s.Length - 1; i++) {
            int n = s[i] - s[i + 1];
            sum += n < 0 ? n * -1 : n;
        }
        return sum;
    }
}