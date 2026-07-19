public class Solution {
    public void SortColors(int[] nums) {
        int low = 0; int mid = 0; int end = nums.Length-1;

        while(mid<=end){
            if(nums[mid] == 0){
                Swap(nums,low,mid);
                mid++; low++;
            }else if(nums[mid] == 1){
                mid++;
            }else{
                Swap(nums,mid,end);
                end--;
            }
        }
    }
    public void Swap(int[]nums, int swap1, int swap2){
        int temp = nums[swap1];
        nums[swap1] = nums[swap2];
        nums[swap2]  = temp;
    }
}