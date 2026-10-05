public class Solution {
    public string LargestOddNumber(string num) {
        int end = num.Length - 1;

        while(end >= 0){
            if((num[end]-'0')%2 != 0){
                break;
                
            }
            end--;
        }
        if(end < 0) return "";
        int start = 0;
        while(start <= end && num[start] == 0){
            start++;
        }
        return num.Substring(start, end-start+1);
    }
}