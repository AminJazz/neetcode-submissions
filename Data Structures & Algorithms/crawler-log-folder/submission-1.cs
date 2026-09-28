public class Solution {
    public int MinOperations(string[] logs) {
        int folderCount = 0;
        for (int i = 0; i < logs.Length; i++) {
            if (logs[i] == "../" && folderCount > 0) folderCount--;
            else if (logs[i] != "../" && logs[i] != "./") folderCount++;
        }

        return folderCount < 0 ? 0 : folderCount;
    }
}