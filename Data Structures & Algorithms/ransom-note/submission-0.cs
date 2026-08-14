public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if (magazine.Length < ransomNote.Length) return false;
        
        int[] arr = new int[26];

        for (int i = 0; i < magazine.Length; i++) {
            arr[magazine[i] - 'a']++;
        }

        int[] note = new int[26];
        for (int i = 0; i < ransomNote.Length; i++) {
            note[ransomNote[i] - 'a']++;
        }

        for (int i = 0; i < note.Length; i++) {
            if (note[i] > arr[i]) return false;
        }

        return true;
    }
}