public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        int[] arr = new int[26];
        for (int i = 0; i < t.Length; i++) {
            arr[t[i] - 'a']++;
            arr[s[i] - 'a']--;
        }

        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] != 0) return false;
        }

        return true;
    }
}
