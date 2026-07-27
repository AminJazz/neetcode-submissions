public class DynamicArray {
    
    private int[] array;
    private int size;
    public DynamicArray(int capacity) {
        if (capacity > 0)
        {
            array = new int[capacity];
            size = 0;
        }
    }

    public int Get(int i) {
        return array[i];
    }

    public void Set(int i, int n) {
        array[i] = n;
    }

    public void PushBack(int n) {
        if (size == array.Length)
            Resize();
        
        array[size] = n;
        size++;
    }

    public int PopBack() {
        return array[--size];
    }

    private void Resize() {
        int[] newArray = new int[array.Length * 2];
        for (int i = 0; i < array.Length; i++) {
            newArray[i] = array[i];
        }

        array = newArray;
    }

    public int GetSize() {
        return size;
    }

    public int GetCapacity() {
        return array.Length;
    }
}
