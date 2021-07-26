
using System;

namespace Matriz {
    class Program {
        static void Main(string[] args) {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++) {
                string[] vect = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(vect[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (x == mat[i, j]) {
                        Console.Write("Position ");
                        Console.WriteLine(i + "," + j);
                        if (j > 0)
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        if (j < n - 1)
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        if (i > 0)
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        if (i < m - 1)
                            Console.WriteLine("Down: " + mat[i + 1, j - 1]);
                    }
                }
            }
        }
    }
}
