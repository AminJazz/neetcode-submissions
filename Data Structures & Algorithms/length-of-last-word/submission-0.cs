public class Solution {
    public int LengthOfLastWord(string s) {
        int count = 0;
        bool wordStarts = false;

        for (int i = s.Length - 1; i >= 0; i--) {
            if (s[i] == ' ' && wordStarts) break;

            if (s[i] != ' ') wordStarts = true;

            if (wordStarts) count++;
        }

        return count;
    }
}