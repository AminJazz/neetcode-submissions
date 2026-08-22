public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int max = -1, temp = 0;
        for (int i = arr.Length - 1; i >= 0; i--) {
            temp = max > arr[i] ? max : arr[i];
            arr[i] = max;
            max = temp;
        }
        
        return arr;
    }
}