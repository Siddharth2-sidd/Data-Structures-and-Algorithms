public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        char[] cs = s.ToCharArray();
        char[] ct = t.ToCharArray();
        Array.Sort(cs);
        Array.Sort(ct);
        
        for(int i=0; i<cs.Length; i++){
            if(cs[i] != ct[i]) return false;
        }
        return true;
    }
}