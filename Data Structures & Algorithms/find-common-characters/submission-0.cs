public class Solution {
    public IList<string> CommonChars(string[] words) {
        int[] arr = new int[26];
        for (int i = 0; i < arr.Length; i++) arr[i] = 102;

        for (int i = 0; i < words.Length; i++) {
            int[] a = new int[26];
            for (int j = 0; j < words[i].Length; j++) {
                a[words[i][j] - 'a']++;
            }

            for (int j = 0; j < a.Length; j++) {
                arr[j] = Math.Min(arr[j], a[j]);
            }
        }

        var result = new List<string>();
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] > 0) {
                while (arr[i] > 0) {
                    result.Add(((char)(i + 'a')).ToString());
                    arr[i]--;
                }
            }
        }

        return result;
    }
}