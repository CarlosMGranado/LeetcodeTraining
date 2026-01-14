public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int pointerM = m - 1;
        int pointerN = n - 1;

        if(n == 0){ return ;}

        while (pointerN >= 0) {
            if (pointerM >= 0 && nums1[pointerM] >= nums2[pointerN]) {
                nums1[pointerM + pointerN + 1] = nums1[pointerM];
                pointerM--;
            } else {
                nums1[pointerM + pointerN + 1] = nums2[pointerN];
                pointerN--;
            }
        }
    }
}