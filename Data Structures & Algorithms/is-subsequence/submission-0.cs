public class Solution {
    public bool IsSubsequence(string s, string t) {
        int si = 0, ti = 0;
        while (si < s.Length && ti < t.Length) {
            if (s[si] == t[ti]) {
                si++;
            }

            ti++;
        }

        if (si == s.Length) return true;

        return false;
    }
}