public class Solution {
    public IList<int> GetRow(int rowIndex) {
        if (rowIndex == 0) return [ 1 ];

        List<int[]> array = new List<int[]>();
        array.Add([1]);
        array.Add([ 1, 1 ]);

        for (int i = 2; i <= rowIndex; i++)
        {
            int[] arr = new int[i + 1];
            arr[0] = 1;
            arr[arr.Length - 1] = 1;
            for (int k = 1; k < arr.Length - 1; k++)
            {
                arr[k] = array[i - 1][k - 1] + array[i - 1][k];
            }
            array.Add(arr);
        }

        return array[array.Count - 1];
    }
}
