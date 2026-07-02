public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if(nums2.Length == 0 || nums1.Length == 0){
            return;
        }
        for(int i = nums2.Length-1; i>=0; i--){
            nums1[m+n-1] = nums2[i];
            m--;
        }
    
    Array.Sort(nums1);
    }
}