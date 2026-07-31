public class Solution {
    public bool IsValidSudoku(char[][] board) {
        int n = board.Length;
        bool isValid = true;

        //check all rows
        HashSet<char> seen = new HashSet<char>();
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                isValid = IsValidOne(board, row, col, seen);
                if (!isValid) break;
            }

            seen.Clear();
            if (!isValid) break;
        }

        if (!isValid) return false;

        //check all columns
        seen.Clear();
        for (int rows = 0; rows < n; rows++)
        {
            for (int col = 0; col < n; col++)
            {
                isValid = IsValidOne(board, col, rows, seen);
                if (!isValid) break;
            }

            seen.Clear();
            if (!isValid) break;
        }

        if (!isValid) return false;

        //check all 3x3 sub-boxes
        seen.Clear();
        for (int row = 0; row < n; row += 3)
        {
            for (int col = 0; col < n; col += 3)
            {
                //check all 9 cells
                isValid = IsValidOne(board, row, col, seen);
                if (!isValid) break;
                isValid = IsValidOne(board, row, col + 1, seen);
                if (!isValid) break;
                isValid = IsValidOne(board, row, col + 2, seen);
                if (!isValid) break;
                isValid = IsValidOne(board, row + 1, col, seen);
                if (!isValid) break;
                isValid = IsValidOne(board, row + 1, col + 1, seen);
                if (!isValid) break;
                isValid = IsValidOne(board, row + 1, col + 2, seen);
                if (!isValid) break;
                isValid = IsValidOne(board, row + 2, col, seen);
                if (!isValid) break;
                isValid = IsValidOne(board, row + 2, col + 1, seen);
                if (!isValid) break;
                isValid = IsValidOne(board, row + 2, col + 2, seen);
                if (!isValid) break;
                seen.Clear();
            }

            if (!isValid) break;
        }

        return isValid;
    }

    public bool IsValidOne(char[][] board, int row, int col, HashSet<char> seen)
    {
        if (seen.Contains(board[row][col]) && board[row][col] != '.')
        {
            return false;
        }
        else if (board[row][col] != '.')
        {
            seen.Add(board[row][col]);
        }

        return true;
    }
}
