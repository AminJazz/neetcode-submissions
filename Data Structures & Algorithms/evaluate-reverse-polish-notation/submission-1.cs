public class Solution {
    public int EvalRPN(string[] tokens) {
        //create stack
        int[] data = new int[tokens.Length];
        data[0] = Convert.ToInt32(tokens[0]);
        int p = 0;

        //for (int i = 1; i < tokens.Length; i++)
            //data[i] = -201;

        //if array value is digit store in stack
        for (int i = 1; i < tokens.Length; i++) {
            if (!int.TryParse(tokens[i], out int result)) {
                data[p - 1] = Operation(tokens[i], data[p - 1], data[p]);
                p--;
            }
            else {
                data[p + 1] = Convert.ToInt32(tokens[i].ToString());
                p++;
            }
        }

        return data[p];
    }

    public int Operation(string sign, int val1, int val2) {
        switch (sign)
        {
            case "+":
                return val1 + val2;
            case "-":
                return val1 - val2;
            case "*":
                return val1 * val2;
            case "/":
                return val1 / val2;
            default: return 0;
        }
    }
}
