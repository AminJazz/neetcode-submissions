public class Solution {
    public List<string> StringMatching(string[] words) {
        var result = new HashSet<string>();

        for (int i = 0; i < words.Length; i++) {
            for (int j = i + 1; j < words.Length; j++) {
                if (words[i].Contains(words[j])) {
                    result.Add(words[j]);
                }
                else if (words[j].Contains(words[i])) {
                    result.Add(words[i]);
                }
            }
        }

        return result.ToList();
    }
}