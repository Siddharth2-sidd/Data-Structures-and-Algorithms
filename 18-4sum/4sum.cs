public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        IList<IList<int>> list = new List<IList<int>>();
        Array.Sort(nums);
        for(int i=0; i<nums.Length-3; i++){
            if(i> 0 && nums[i] == nums[i-1]) continue;
            for(int j=i+1; j<nums.Length-2; j++){
                if(j>i+1 && nums[j] == nums[j-1]) continue;
                int left = j+1; int right = nums.Length-1;
                while(left < right){
                    long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];
                    if(sum == target){
                    list.Add([nums[left], nums[right],nums[i],nums[j]]);
                    while(left < right && nums[left] == nums[left+1]) left++;
                    while(left < right && nums[right] == nums[right-1]) right--;
                    left++; right--;
                    }else if(sum < target){
                        left++;
                    }else{
                        right--;
                    }
                }
            }
        }
        return list;
    }
}