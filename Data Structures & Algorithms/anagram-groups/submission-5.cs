public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dir = new  Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++) {
            string key = IsKeyExists(strs[i], dir);

            if (key == "$") dir.Add(strs[i], [strs[i]]);
            else dir[key].Add(strs[i]);
        }

        var result = new List<List<string>>();
        foreach (var val in dir.Values) result.Add(val);

        return result;
    }

    public string IsKeyExists(string key, Dictionary<string, List<string>> dir) {
        foreach (var keys in dir.Keys) {
            if (keys.Length != key.Length) continue;
            int matchLength = 0;
            string tempKey = key;
            for (int i = 0; i < keys.Length; i++) {
                for (int j = 0; j < keys.Length; j++) {
                    if (keys[i] == tempKey[j]) {
                        char[] c = tempKey.ToCharArray();
                        c[j] = '.';
                        tempKey = new string(c);
                        matchLength++;
                        break;
                    }
                }
            }

            if (matchLength == key.Length) return keys;
        }

        return "$";
    }
}
