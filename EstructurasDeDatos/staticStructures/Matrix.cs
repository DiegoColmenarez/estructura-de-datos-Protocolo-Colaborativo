namespace EstructurasDeDatos.staticStructures;

public class Matrix
{
    private static int[,] TransformMatrix(int[,] matrix, Func<int, int,int, int> map) {
        var result  = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (var i = 0; i < matrix.GetLength(0); i++) {
            for (var j = 0; j < matrix.GetLength(1); j++) {
                result[i, j] = map(matrix[i, j], i, j);
            }
        }
        return result;
    }
    
    public static int[,] FlipHorizontalMatrix(int[,]matrix) {
        return TransformMatrix(matrix, (value, row,colum) => matrix[matrix.GetLength(0) - 1 - row, colum]);
    }
    
    private static int ReduceMatrix(int[,] matrix, int initValue, Func<int, int, int> reduce)
    {
        var result = initValue;
        for (var i = 0; i < matrix.GetLength(0); i++) {
            for (var j = 0; j < matrix.GetLength(1); j++) {
                result = reduce(result, matrix[i, j]);
            }
        }
        return result;
    }
    public static void PrintMatrix(int[,] matrix)
    {
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    public static int SumAllValues(int[,] matrix)
    {
        return ReduceMatrix(matrix, 0, (accumulator, curretValue) => accumulator += curretValue);
    }
}