public class Solution {
    public int CountCharacters(string[] words, string chars) {
        int[] arr = new int[26];
        int result = 0;

        for (int i = 0; i < chars.Length; i++) {
            arr[chars[i] - 'a']++;
        }

        for (int i = 0; i < words.Length; i++) {
            if (words[i].Length > chars.Length) continue;

            int[] temp = new int[26];
            for (int j = 0; j < words[i].Length; j++) {
                temp[words[i][j] - 'a']++;
            }

            int count = 0;
            //check both string are matching
            for (int k = 0; k < temp.Length; k++) {
                if (temp[k] == 0) continue;
                if (arr[k] >= temp[k]) count += temp[k];
            }

            if (count == words[i].Length) result += count;
        }

        return result;
    }
}