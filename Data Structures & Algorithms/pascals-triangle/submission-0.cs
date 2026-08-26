public class Solution {
    public List<List<int>> Generate(int numRows) {
        var result = new List<List<int>>();
        result.Add(new List<int>() { 1 });

        for (int i = 1; i < numRows; i++) {
            var child = new List<int>() { 1 };
            
            for (int j = 0; j < result[i - 1].Count - 1; j++) {
                child.Add(result[i - 1][j] + result[i - 1][j + 1]);
            }

            child.Add(1);
            result.Add(child);
        }

        return result;
    }
}