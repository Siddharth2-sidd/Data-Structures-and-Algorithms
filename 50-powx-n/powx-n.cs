public class Solution {
    public double MyPow(double x, int n) {
        long binaryform = n;
        if(n < 0){
            binaryform = -binaryform;
            x = 1/x;
        }
        double pow = 1;
        while(binaryform > 0){
            if(binaryform% 2 == 1){
                pow = pow*x;
            }
            x = x*x;
            binaryform = binaryform/2;
        }
        return pow;
    }
}