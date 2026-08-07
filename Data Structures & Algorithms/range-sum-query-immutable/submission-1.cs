public class NumArray {
    private int[] arr;
    public NumArray(int[] nums) {
        arr = new int[nums.Length];
        arr = nums;
    }
    
    public int SumRange(int left, int right) {
        int total = 0;

        while (left <= right) {
            total += arr[left];
            left++;
        }

        return total;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */