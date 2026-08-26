public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new List<List<string>>();
        Dictionary<string, List<string>> dir = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++) {
            int[] arr = new int[26];
            foreach(char c in strs[i]) arr[c - 'a']++;

            string key = "";
            for (int j = 0; j < arr.Length; j++) {
                if (arr[j] == 0) continue;

                int count = arr[j];
                while (count > 0) {
                    key += (j + 'a').ToString();
                    count--;
                }
            }

            if (dir.ContainsKey(key)) dir[key].Add(strs[i]);
            else dir.Add(key, new List<string>() {strs[i]});
        }

        foreach (var item in dir.Values) result.Add(item);

        return result;
    }
}
