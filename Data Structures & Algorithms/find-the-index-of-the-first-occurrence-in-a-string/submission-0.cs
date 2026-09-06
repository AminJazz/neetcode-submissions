public class Solution {
    public int StrStr(string haystack, string needle) {
        for (int i = 0; i < haystack.Length - needle.Length + 1; i++) {
            int count = 0;
            for (int j = 0; j < needle.Length; j++) {
                if (needle[j] == haystack[i + j]) count++;
                else break;
            }
            
            if (count == needle.Length) return i;
        }

        return -1;
    }
}