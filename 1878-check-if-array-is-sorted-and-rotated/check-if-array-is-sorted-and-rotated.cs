public class Solution {
    public bool Check(int[] nums) {
        
        bool fault = false;
        int n = nums.Length;

        for (int i = 0; i < n; i++) {
            if (nums[i] > nums[(i + 1) % n]) {
                if (fault) return false;
                fault = true;
            }
        }

        return true;
    }
}