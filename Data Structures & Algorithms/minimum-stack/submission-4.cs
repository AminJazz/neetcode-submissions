public class MinStack {
    private Stack<int> stack;
    private Stack<int> min;

    public MinStack() {
        stack = new Stack<int>();
        min = new Stack<int>();
    }
    
    public void Push(int val) {
        if (min.Count == 0 || min.Peek() >= val)
            min.Push(val);
        
        stack.Push(val);
    }
    
    public void Pop() {
        if (min.Peek() == stack.Peek())
            min.Pop();

        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return min.Peek();
    }
}
