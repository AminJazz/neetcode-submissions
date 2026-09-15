public class Solution {
    public bool ValidPalindrome(string s) {
        int l = 0, r = s.Length - 1, count = 0;
        while (l <= r) {
            if (s[l] != s[r]) {
                return IsValid(s, l + 1, r) || IsValid(s, l, r - 1);
            }

            l++;
            r--;
        }

        return true;
    }

    public bool IsValid(string s, int l, int r) {
        while (l <= r) {
            if (s[l++] != s[r--]) return false;
        }

        return true;
    }
}