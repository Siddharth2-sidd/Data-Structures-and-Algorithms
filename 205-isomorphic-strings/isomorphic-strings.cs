public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length != t.Length) return false;

        Dictionary<char,int> s1 = new();
        Dictionary<char,int> t1 = new();

        for(int i=0; i<s.Length; i++){
            if(!s1.ContainsKey(s[i])){
                s1.Add(s[i],i);
            }
            if(!t1.ContainsKey(t[i])){
                t1.Add(t[i],i);
            }

            if(s1[s[i]] != t1[t[i]]){
                return false;
            }
        }

        return true;

    }
}