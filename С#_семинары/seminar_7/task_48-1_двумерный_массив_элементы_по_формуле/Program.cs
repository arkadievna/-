// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
// Aₘₙ= m+n. 
// Выведите полученный массив на экран. 
// m = 3, 
// n = 4. 0 1 2 3 1 2 3 4 2 3 4 5

using System; 
public class Answer {    
    public static void PrintArray (int [,] matrix) 
    { 
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          for (int j = 0; j< matrix.GetLength(1); j++)
              Console.Write(matrix[i,j] +" ");
          Console.WriteLine();
        }
    } 
      public static int[,] CreateIncreasingMatrix(int n, int m, int k) 
    {      
        int[,] matrix= new int [n, m];
        for (int i=0; i<n; i++)
          for(int j=0; j<m;j++) 
             matrix [i, j] = i*m+j+k;
        return matrix;
    }   
    static void PrintListAvr (double [] list)    
    { 
        foreach(double value in list)
            Console.Write(value + " ");
        Console.WriteLine();
    } 
    static double [] FindAverageInColumns (int [,] matrix) 
    { 
        double[]averageValues = new double[matrix.GetLength(1)];
        for (int j=0; j< matrix.GetLength(1); j++)
        {
            double columnSum = 0;
            for (int i=0; i<matrix.GetLength(0);i++)
                columnSum += matrix[i,j];
            averageValues[j] = columnSum / matrix.GetLength(0);
        }
        return averageValues;
    } 
    static public void Main(string[] args) {        
        int n, m, k; 
        if (args.Length >= 3) { 
           n = int.Parse(args[0]);           
           m = int.Parse(args[1]); 
           k = int.Parse(args[2]);        
        } else { 
           n = 3; 
           m = 4;           
           k = 2; 
        } 
        int[,] result = CreateIncreasingMatrix(n, m, k);        
        PrintArray(result); 
        PrintListAvr(FindAverageInColumns(result));    
    } 
}