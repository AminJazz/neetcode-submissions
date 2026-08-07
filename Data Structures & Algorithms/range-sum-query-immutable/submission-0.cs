public class NumArray {
    private int[] arr;
    public NumArray(int[] nums) {
        arr = new int[nums.Length];
        arr = nums;
    }
    
    public int SumRange(int left, int right) {
        int result = 0;

        for (int i = left; i <= right; i++)
            result += arr[i];

        return result;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */