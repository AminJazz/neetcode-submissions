public class MinStack {
    private Stack<int> stack = new Stack<int>();
    private Stack<int> minStack = new Stack<int>();

    public MinStack() {
        
    }
    
    public void Push(int val) {
        if (minStack.Count > 0) {
            if (minStack.Peek() >= val)
                minStack.Push(val);
        }
        else minStack.Push(val);

        stack.Push(val);
    }
    
    public void Pop() {
        if (minStack.Count > 0 && minStack.Peek() == stack.Peek()) {
            minStack.Pop();
        }

        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
