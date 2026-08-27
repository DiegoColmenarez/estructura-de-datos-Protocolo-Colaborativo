def transform_matrix(matrix, map_func):
        """Método privado para transformar la matriz según una función dada"""
        rows = len(matrix)
        cols = len(matrix[0]) if rows > 0 else 0
        result = [[0] * cols for _ in range(rows)]
        
        for i in range(rows):
            for j in range(cols):
                result[i][j] = map_func(matrix[i][j], i, j)
        return result

def flip_vertical_matrix(matrix):
    return transform_matrix(
            matrix, 
            lambda value, row, col: matrix[len(matrix) - 1 - row][col]
        )
