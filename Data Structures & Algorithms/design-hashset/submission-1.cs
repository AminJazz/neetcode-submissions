public class MyHashSet {
    private List<int> set;
    public MyHashSet() {
        set = new List<int>();
    }
    
    public void Add(int key) {
        if (!Contains(key)) set.Add(key);
    }
    
    public void Remove(int key) {
        //foreach (int item in set) {
            //if (item == key) {
                //set.Remove(key);
                //break;
            //}
        //}

        set.Remove(key);
    }
    
    public bool Contains(int key) {
        if (set.Contains(key)) return true;
        else return false;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */