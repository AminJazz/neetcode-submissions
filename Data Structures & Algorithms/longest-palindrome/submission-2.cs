public class Solution {
    public int LongestPalindrome(string s) {
        int[] arr = new int[58];

        for (int i = 0; i < s.Length; i++) {
            arr[s[i] - 'A']++;
        }

        //find even numbers
        int total = 0;
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] % 2 == 0)
                total += arr[i];
        }

        //count max odd number
        int max = 0;
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] % 2 != 0 && max < arr[i]) {
                total += arr[i] - 1;
                max = 1;
            }
        }

        return total + max;
    }
}