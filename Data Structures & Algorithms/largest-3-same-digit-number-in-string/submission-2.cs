public class Solution {
    public string LargestGoodInteger(string num) {
        int max = -1;
        string result = "";
        for (int i = 0; i < num.Length - 2; i++) {
            if (num[i] == num[i + 1] && num[i + 1] == num[i + 2]) {
                int no = num[i] - '0';
                if (max < no) {
                    max = no;
                    result = num.Substring(i, 3);
                }
                
            }
        }

        return result;
    }
}