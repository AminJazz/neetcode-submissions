public class Solution {
    public int FindLucky(int[] arr) {
        int[] count = new int[501];

        for (int i = 0; i < arr.Length; i++) {
            count[arr[i]]++;
        }

        int max = - 1;
        for (int i = 1; i < count.Length; i++) {
            if (count[i] == i) max = i;
        }

        return max;
    }
}