public class Solution {
    public int MaxDifference(string s) {
        int[] arr = new int[26];
        foreach (char c in s) {
            arr[c - 'a']++;
        }

        int odd = -1, even = int.MaxValue;
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] == 0) continue;
            if (arr[i] % 2 == 0) {
                even = Math.Min(arr[i], even);
            }
            else {
                odd = Math.Max(arr[i], odd);
            }
        }

        return odd - even;
    }
}