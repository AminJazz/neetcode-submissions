public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] arr = new int[26];
        int maxFreq = 0, left = 0, right = 0, total = 0, maxTotal = 0;
        while (right < s.Length) {
            arr[s[right] - 'A']++;
            maxFreq = Math.Max(maxFreq, arr[s[right] - 'A']);
            right++;
            total++;

            if (total - maxFreq <= k) {
                maxTotal = Math.Max(maxTotal, total);
            }
            
            //shrink window size if large
            if (total - maxFreq > k) {
                arr[s[left] - 'A']--;
                left++;
                total--;
            }
        }

        return maxTotal;
    }
}
