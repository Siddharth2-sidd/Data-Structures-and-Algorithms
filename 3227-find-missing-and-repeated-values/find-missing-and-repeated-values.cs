public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int n = grid.Length;
        int[] count = new int[n*n+1];

        for(int i=0; i<n; i++){
            for(int j = 0; j<n; j++){
                int v = grid[i][j];
                count[v]++;
            }
        }
        int a = 0; int b = 0;
        for(int i=1; i<count.Length; i++){
            if(count[i] == 0){
                b = i;
            }
            if(count[i]>1){
                a = i;
            }
        }

        return new int[]{a,b};

    }
}