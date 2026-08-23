public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int result = 0, p = 0;

        while (tickets[k] > 0) {
            p = p % tickets.Length;
            
            if (tickets[p] != 0) {
                tickets[p]--;
                result++;
            }

            p++;
        }

        return result;
    }
}