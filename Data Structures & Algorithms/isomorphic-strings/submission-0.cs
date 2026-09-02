public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length) return false;

        Dictionary<char, char> dir = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++) {
            if (!dir.ContainsKey(s[i])) {
                if (dir.ContainsValue(t[i])) return false;
                else dir[s[i]] = t[i];
            }
            else {
                if (dir[s[i]] != t[i]) return false;
            }
        }

        return true;
    }
}