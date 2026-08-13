public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        int[] arr = new int[26];
        int result = 0;

        for (int i = 0; i < allowed.Length; i++) {
            arr[allowed[i] - 'a']++;
        }

        for (int i = 0; i < words.Length; i++) {
            int[] temp = new int[26];
            for (int j = 0; j < words[i].Length; j++) {
                temp[words[i][j] - 'a']++;
            }

            result++;
            for (int k = 0; k < temp.Length; k++) {
                if (temp[k] != 0 && arr[k] == 0) {
                    result--;
                    break;
                }
            }
        }

        return result;
    }
}