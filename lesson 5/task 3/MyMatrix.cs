using System;

namespace Task3
{
    class MyMatrix
    {
        private int[][] matrix;

        public MyMatrix(int rows, int cols)
        {
            matrix = new int[Math.Abs(rows)][];
            for (int i = 0; i < matrix.Length; i++)
                matrix[i] = new int[Math.Abs(cols)];
            Fill();
        }

        private void Fill()
        {
            Random rand = new Random();
            for (int i = 0; i < matrix.Length; i++)
                for (int j = 0; j < matrix[i].Length; j++)
                    matrix[i][j] = rand.Next(10, 90);
        }

        public void ChangeSize(int newRows, int newCols)
        {
            if (newRows <= 0 || newCols <= 0)
            {
                Console.WriteLine("Matrix dimensions must be greater than zero.");
                return;
            }

            int[][] newMatrix = new int[newRows][];
            for (int i = 0; i < newRows; i++)
                newMatrix[i] = new int[newCols];

            for (int i = 0; i < Math.Min(matrix.Length, newRows); i++)
                for (int j = 0; j < Math.Min(matrix[i].Length, newCols); j++)
                    newMatrix[i][j] = matrix[i][j];

            Random rand = new Random();

            for (int i = matrix.Length; i < newRows; i++)
                for (int j = 0; j < newCols; j++)
                    newMatrix[i][j] = rand.Next(10, 90);

            for (int i = 0; i < Math.Min(matrix.Length, newRows); i++)
                for (int j = matrix[0].Length; j < newCols; j++)
                    newMatrix[i][j] = rand.Next(10, 90);

            matrix = newMatrix;
        }

        public void ShowPartly(int startRow, int startCol, int endRow, int endCol)
        {
            if (startRow < 0 || startCol < 0 || endRow > matrix.Length || endCol > matrix[0].Length)
            {
                Console.WriteLine("Index out of bounds.");
                return;
            }

            if (startRow > endRow || startCol > endCol)
            {
                Console.WriteLine("Invalid range coordinates.");
                return;
            }

            for (int i = startRow; i < endRow; i++)
            {
                for (int j = startCol; j < endCol; j++)
                    Console.Write($"{matrix[i][j]}  ");
                Console.WriteLine();
            }
        }

        public void Show()
        {
            ShowPartly(0, 0, matrix.Length, matrix[0].Length);
        }

        public int this[int row, int col]
        {
            get
            {
                if (row >= 0 && row < matrix.Length && col >= 0 && col < matrix[0].Length)
                    return matrix[row][col];
                Console.WriteLine("Index out of bounds.");
                return 0;
            }
            set
            {
                if (row >= 0 && row < matrix.Length && col >= 0 && col < matrix[0].Length)
                    matrix[row][col] = value;
                else
                    Console.WriteLine("Attempted to assign value outside of bounds.");
            }
        }
    }
}
