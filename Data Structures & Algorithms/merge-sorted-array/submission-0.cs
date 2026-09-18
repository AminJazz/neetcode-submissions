public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = 0;
        while (m < nums1.Length) {
            nums1[m++] = nums2[i++];
        }

        Array.Sort(nums1);
    }
}