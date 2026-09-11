public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int count = 0;
        for (int i = 0; i < sandwiches.Length; i++) {
            for (int j = 0; j < students.Length; j++) {
                if (sandwiches[i] == students[j]) {
                    students[j] = -1;
                    count++;
                    break;
                }

                if (j == students.Length - 1)
                    return students.Length - count;
            }
        }

        return students.Length - count;
    }
}