// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
// m = 3, n = 4 
// 0,5 7 -2 -0,2 
// 1 -3,3 8 -9,9 
// 8 7,8 -7,1 9


using System;
public class Answer {   
    public static void PrintArray (int[,] matrix) {
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k) {
        int[,] matrix = new int[n, m];
        int currentValue = k;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                matrix[i, j] = currentValue;
                currentValue++;
            }
        }
        return matrix;
    }  
    
    public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition) {
        return new int[] { matrix[rowPosition, columnPosition] };
    }

    public static void PrintCheckIfError(int[] results, int X, int Y) {
        if (results.Length > 0) {
            Console.WriteLine($"Number in position ({X},{Y}): {results[0]}");
        } else {
            Console.WriteLine($"No number found in position ({X},{Y}).");
        }
    }
  
    static public void Main(string[] args) {        
        int n, m, k, x, y;
        if (args.Length >= 5) {
            n = int.Parse(args[0]);           
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);           
            x = int.Parse(args[3]);
            y = int.Parse(args[4]);        
        } else {
            n = 3;
            m = 4;           
            k = 2;
            x = 2;           
            y = 3;
        }
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);        
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}
