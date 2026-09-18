public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int ni = 0, l = nums1.Length - 1;
        while (ni < nums2.Length) {
            if (m <= 0) {
                nums1[m++] = nums2[n - 1];
                n--;
                ni++;
            }
            else if (nums1[m - 1] >= nums2[n - 1]) {
                nums1[l--] = nums1[m - 1];
                m--;
            }
            else {
                nums1[l--] = nums2[n - 1];
                n--;
                ni++;
            }
        }
    }
}