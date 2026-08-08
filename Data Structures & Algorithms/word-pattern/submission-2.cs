public class Solution {
    public bool WordPattern(string pattern, string s) {
        string[] str = s.Split(' ');
        if (pattern.Length != str.Length) return false;

        Dictionary<char, string> dir = new Dictionary<char, string>();

        for (int i = 0; i < pattern.Length; i++) {
            if (dir.ContainsKey(pattern[i])) {// && str[i] != dir[pattern[i]])
                if (dir[pattern[i]] != str[i])
                    return false;
            }
            else {
                if (dir.ContainsValue(str[i]))
                    return false;
                else
                    dir.Add(pattern[i], str[i]);
            }
        }

        return true;
    }
}