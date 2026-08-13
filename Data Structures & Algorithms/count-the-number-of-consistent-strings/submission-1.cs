public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        HashSet<char> hs = new HashSet<char>();
        int result = 0;

        for (int i = 0; i < allowed.Length; i++) {
            hs.Add(allowed[i]);
        }

        for (int i = 0; i < words.Length; i++) {
            result++;
            for (int j = 0; j < words[i].Length; j++) {
                if (!hs.Contains(words[i][j])) {
                    result--;
                    break;
                }
            }
        }
        
        return result;
    }
}