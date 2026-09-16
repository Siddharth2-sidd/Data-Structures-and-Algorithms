class Solution {
    public boolean isPalindrome(String s) {
        
        String s1 ="";
        s = s.toLowerCase();
        for(int i =0; i<s.length(); i++){
            if(s.charAt(i)<= 'z' && s.charAt(i) >= 'a'){
                s1 = s1+s.charAt(i);
            }else if(s.charAt(i) <= '9' && s.charAt(i) >= '0'){
                s1 = s1+s.charAt(i);
            }
        }

      String s1R = "";
      for(int i =0; i<s1.length(); i++){
          s1R = s1.charAt(i) + s1R;
      }
      if(s1.equals(s1R)){
          return true;
      }
        return false;
    }
}