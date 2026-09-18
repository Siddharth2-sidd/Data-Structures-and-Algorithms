public class Solution {
    public int Reverse(int x) {
        
        long rev = 0;
        while(x != 0){
            int rem = x%10;
            rev = rev*10+rem;
            x = x/10;
        }
        if(rev > int.MaxValue || rev < int.MinValue) return 0;
        
        return (int)rev;
    }
}