public class Solution {
    public string KthDistinct(string[] arr, int k) {
        Dictionary<string, int> dir = new Dictionary<string, int>();
        
        //count all elements
        for (int i = 0; i < arr.Length; i++) {
            if (dir.ContainsKey(arr[i]))
                dir[arr[i]]++;
            else dir.Add(arr[i], 1);
        }

        foreach (var item in dir) {
            if (item.Value == 1) k--;

            if (k == 0) {
                return item.Key;
            }
        }

        return "";
    }
}