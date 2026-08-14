public class Solution {
    public string LargestGoodInteger(string num) {
        int max = -1;
        for (int i = 0; i < num.Length - 2; i++) {
            int no = num[i] - '0';

            //traverse window
            int size = 1;
            while (size < 3) {
                if (num[i + size] != num[i]) break;
                size++;
            }

            if (size == 3) {
                max = Math.Max(no, max);
            }
        }

        return max == - 1 ? "" : $"{max}{max}{max}";
    }
}