namespace EstructurasDeDatos.staticStructures;

public class Matrix
{
    private static int[,] TransformMatrix(int[,] matrix, Func<int, int, int> map) {
        var result  = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (var i = 0; i < matrix.GetLength(0); i++) {
            for (var j = 0; j < matrix.GetLength(1); j++) {
                result[i, j] = map(i, j);
            }
        }
        return result;
    }
}