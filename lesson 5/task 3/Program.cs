

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix(4, 5);
            Console.WriteLine("Original matrix:");
            matrix.Show();

            Console.WriteLine("\nResizing matrix to 6x3:");
            matrix.ChangeSize(6, 3);
            matrix.Show();

            Console.WriteLine("\nDisplaying part of the matrix (rows 1-3, cols 1-3):");
            matrix.ShowPartly(1, 1, 3, 3);

            Console.WriteLine($"\nAccessing element [2,2]: {matrix[2, 2]}");

            Console.WriteLine("\nModifying element [2,2] to 999...");
            matrix[2, 2] = 999;

            Console.WriteLine("Matrix after modification:");
            matrix.Show();

            Console.ReadLine();
        }
    }
}
