public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        Array.Sort(strs);
        char[] c = strs[0].ToCharArray();
        char[] c1 = strs[strs.Length-1].ToCharArray();
        string sub = "";

        for(int i=0; i<strs[0].Length; i++){
            if(c[i] != c1[i]){
                break;
            }
            sub = sub+c[i];
        }
        return sub;
    }
}