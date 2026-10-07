public class Solution {
    public string FrequencySort(string s) {
        StringBuilder sb = new StringBuilder();
        int[] freq = new int[128];

        for(int i=0; i<s.Length; i++){
            freq[s[i]]++;
        }
        
        while(sb.Length < s.Length){
            int max = 0;

            for(int i=1; i<128; i++){
                if(freq[i] > freq[max]){
                    max = i;
                }
            }

            for(int i=0; i<freq[max]; i++){
                sb.Append((char)max);
            }
            freq[max] = 0;
        }
        return sb.ToString();
    }
}