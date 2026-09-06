public class Solution {
    public int StrStr(string haystack, string needle) {
        int h = 0, n = 0;
        while (h < haystack.Length) {
            if (haystack[h] == needle[n]) n++;
            else {
                h = h - n;
                n = 0;
            }

            h++;
            if (n == needle.Length) return h - n;
        }

        return -1;
    }
}