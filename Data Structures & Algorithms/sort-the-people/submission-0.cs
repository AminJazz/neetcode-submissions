public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        Dictionary<int, string> dir = new Dictionary<int, string>();
        for (int i = 0; i < heights.Length; i++) {
            dir.Add(heights[i], names[i]);
        }

        Array.Sort(heights);

        string[] result = new string[names.Length];
        for (int i = names.Length; i > 0; i--) {
            result[names.Length - i] = dir[heights[i - 1]];
        }

        return result;
    }
}