public class Solution {
    public int MaxSubArray(int[] nums) {
        if(nums.Length == 0) return 0;
        int maxSubArray = nums[0];
        int result = maxSubArray;

        for(int i=1; i<nums.Length; i++){
            if(maxSubArray < 0){
                maxSubArray = nums[i];
            }else{
            maxSubArray = maxSubArray + nums[i];
            }
            
            if(result < maxSubArray){
                result = maxSubArray;
                
            }
        }

        return result;
        
    }
}