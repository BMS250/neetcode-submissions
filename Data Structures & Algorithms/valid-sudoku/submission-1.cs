public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int, HashSet<char>> cols = [];
        for (int row = 0; row < 9; row++)
        {
            HashSet<char> rowSet = [];
            for (int col = 0; col < 9; col++)
            {
                if (row % 3 == 0 && col % 3 == 0)
                {
                    if (!IsValidBox(board, row, col)) return false;
                }

                if (board[row][col] == '.') continue;

                if (rowSet.Contains(board[row][col])) return false;
                else rowSet.Add(board[row][col]);

                if (cols.TryGetValue(col, out var values))
                {
                    if (values.Contains(board[row][col])) return false;
                    else cols[col].Add(board[row][col]);
                }
                else cols[col] = [board[row][col]];
            }
        }
        return true;
    }

    private bool IsValidBox(char[][] board, int rowStart, int colStart)
    {
        HashSet<char> set = [];
        for (int row = rowStart; row < rowStart + 3; row++)
        {
            for (int col = colStart; col < colStart + 3; col++)
            {
                if (board[row][col] != '.' && set.Contains(board[row][col])) return false;
                else set.Add(board[row][col]);
            }
        }
        return true;
    }
}
