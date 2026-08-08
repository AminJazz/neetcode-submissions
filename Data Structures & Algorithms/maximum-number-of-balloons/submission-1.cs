public class Solution {
    public int MaxNumberOfBalloons(string text) {
        int[] arr = new int[5];

        for (int i = 0; i < text.Length; i++) {
            if (text[i] == 'b') arr[0]++;
            else if (text[i] == 'a') arr[1]++;
            else if (text[i] == 'l') arr[2]++;
            else if (text[i] == 'o') arr[3]++;
            else if (text[i] == 'n') arr[4]++;
        }

        arr[2] /= 2;
        arr[3] /= 2;

        int min = arr[0];
        for (int i = 1; i < arr.Length; i++) {
            if (min > arr[i]) min = arr[i];
        }

        return min;
    }
}