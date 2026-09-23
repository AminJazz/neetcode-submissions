public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < tokens.Length; i++) {
            if (int.TryParse(tokens[i], out int num))
                stack.Push(num);
            else {
                int b = stack.Pop(), a = stack.Pop();
                stack.Push(Operation(a, b, tokens[i]));
            }
        }

        return stack.Pop();
    }

    private int Operation(int a, int b, string Sign) {
        switch (Sign) {
            case "+":
                return a + b;
            case "*":
                return a * b;
            case "-":
                return a - b;
            case "/":
                return a / b;
            default:
                return 0;
        }
    }
}
