public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dir = new  Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++) {
            var chrs = strs[i].ToCharArray().OrderBy(s => s).ToArray();
            string str = new string(chrs);

            if (!dir.ContainsKey(str)) dir[str] = new List<string>();
            dir[str].Add(strs[i]);
        }

        var result = new List<List<string>>();
        foreach (var val in dir.Values) result.Add(val);

        return result;
    }
}
