public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int w1 = 0, w2 = 0;
        string str = "";
        while (w1 < word1.Length && w2 < word2.Length) {
            str += word1[w1++].ToString() + word2[w2++].ToString();
        }

        while (w1 < word1.Length) {
            str += word1[w1++].ToString();
        }

        while (w2 < word2.Length) {
            str += word2[w2++].ToString();
        }

        return str;
    }
}