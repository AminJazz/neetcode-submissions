public class Solution {
    public bool MakeEqual(string[] words) {
        Dictionary<char, int> dir = new Dictionary<char, int>();
        
        for (int i = 0; i < words.Length; i++) {
            for (int j = 0; j < words[i].Length; j++) {
                if (dir.ContainsKey(words[i][j]))
                    dir[words[i][j]]++;
                else dir.Add(words[i][j], 1);
            }
        }

        foreach (int val in dir.Values) {
            if (val % words.Length != 0)
                return false;
        }

        return true;
    }
}