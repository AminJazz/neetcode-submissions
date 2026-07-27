public class LinkedList {

    private int[] array;
    private int tail;
    public LinkedList() {
        array = new int[2];
        tail = -1;
    }

    public int Get(int index) {
        if (index < 0 || index > tail) return -1;
        return array[index];
    }

    public void InsertHead(int val) {
        if (tail < 0) {
            array[0] = val;
            tail = 0;
            return;
        }

        if (tail == array.Length - 1) Resize();

        for (int i = tail; i >= 0; i--) {
            array[i + 1] = array[i]; //swap
        }
        array[0] = val;
        tail++;
    }

    public void InsertTail(int val) {
        if (tail < 0) {
            array[0] = val;
            tail = 0;
            return;
        }

        if (tail == array.Length - 1) Resize();
        
        tail++;
        array[tail] = val;
    }

    public bool Remove(int index) {
        if (tail < 0 || index > tail) return false;
        for (int i = index; i < tail; i++)
            array[i] = array[i + 1];
        tail--;
        return true;
    }
    
    public void Resize() {
        int[] newArray = new int[array.Length * 2];
        for (int i = 0; i < array.Length; i++) {
            newArray[i] = array[i];
        }
        array = newArray;
    }

    public List<int> GetValues() {
        if (tail < 0) return new List<int>();

        List<int> items = new List<int>();

        for (int i = 0; i <= tail; i++)
            items.Add(array[i]);

        return items;
    }
}