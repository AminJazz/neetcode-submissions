public class Solution {
    public string CustomSortString(string order, string s) {
        int[] arr = new int[26];
        StringBuilder result = new StringBuilder();

        //count char frequency from s
        for (int i = 0; i < s.Length; i++) {
            arr[s[i] - 'a']++;
        }

        //append matching string from order
        for (int i = 0; i < order.Length; i++) {
            if (arr[order[i] - 'a'] > 0) {
                int count = arr[order[i] - 'a'];
                while (count > 0) {
                    result.Append(order[i].ToString());
                    count--;
                }
                arr[order[i] - 'a'] = count;
            }
        }

        //append remaining string from array
        for (int i = 0; i < arr.Length; i++) {
            while (arr[i] > 0) {
                result.Append(((char)(i + 'a')).ToString());
                arr[i]--;
            }
        }

        return result.ToString();
    }
}