public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int result = 0;

        for (int i = 0; i < tickets.Length; i++) {
            if (i <= k) result += Math.Min(tickets[i], tickets[k]);
            else result += Math.Min(tickets[i], tickets[k] - 1);
        }

        return result;
    }
}