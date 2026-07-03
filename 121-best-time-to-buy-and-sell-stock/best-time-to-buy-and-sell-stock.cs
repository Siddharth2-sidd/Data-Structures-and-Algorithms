public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int buy = int.MaxValue;
        for(int i=0; i<prices.Length; i++){
            if(prices[i] < buy){
                buy = prices[i];
            }else if((prices[i]-buy) > profit){
                profit = prices[i] - buy;
            }
        }

    return profit;
    }
}