public class Solution {
    public int AppendCharacters(string s, string t) {
        int si = 0, ti = 0;

        while (ti < t.Length && si < s.Length) {
            if (s[si] == t[ti]) {
                ti++;
            }

            si++;
        }
        
        return t.Length - ti;
    }
}