public class Solution {
    public bool ValidPalindrome(string s) {
        int l = 0, r = s.Length - 1, count = 0;
        while (l <= r) {
            if (s[l] == s[r]) {
                l++;
                r--;
            }
            else {
                return IsValid(s, l + 1, r) || IsValid(s, l, r - 1);
            }
        }

        return true;
    }

    public bool IsValid(string s, int l, int r) {
        while (l <= r) {
            if (s[l] == s[r]) {
                l++;
                r--;
            }
            else return false;
        }

        return true;
    }
}