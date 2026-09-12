public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        int[] arr = new int[1001];
        int[] result = new int[arr1.Length];
        int index = 0;

        for (int i = 0; i < arr1.Length; i++) arr[arr1[i]]++;

        for (int i = 0; i < arr2.Length; i++) {
            int count = arr[arr2[i]];
            while (count > 0) {
                result[index++] = arr2[i];
                count--;
            }
            arr[arr2[i]] = 0;
        }

        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] > 0) {
                int count = arr[i];
                while (count > 0) {
                    result[index++] = i;
                    count--;
                }
                arr[i] = 0;
            }
        }

        return result;
    }
}