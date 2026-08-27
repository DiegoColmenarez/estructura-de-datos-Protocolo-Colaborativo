def transform_matrix(matrix, map_func):
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


def reduce_matrix(matrix, init_value, reduce_func):
        result = init_value
        for i in range(len(matrix)):
            for j in range(len(matrix[i])):
                result = reduce_func(result, matrix[i][j])
        return result

def sum_all_values(matrix):
        return reduce_matrix(
            matrix, 
            0, 
            lambda accumulator, current_value: accumulator + current_value
        )

def print_by_column(matrix):
        if not matrix:
            return
        cols = len(matrix[0])
        rows = len(matrix)
        for j in range(cols):
            print(f"Columna {j}: ", end="")
            for i in range(rows):
                print(f"{matrix[i][j]} ", end="")
            print()
