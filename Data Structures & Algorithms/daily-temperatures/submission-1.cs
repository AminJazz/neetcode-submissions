public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> stack = new Stack<int>();
        int[] result = new int[temperatures.Length];

        for (int i = temperatures.Length - 1; i >= 0; i--) {
            while (stack.Count > 0 && temperatures[stack.Peek()] <= temperatures[i])
                stack.Pop();
            
            if (stack.Count > 0) result[i] = stack.Peek() - i;
            else result[i] = 0;
            stack.Push(i);
        }

        return result;
    }
}
