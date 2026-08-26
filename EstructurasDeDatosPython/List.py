def transform_array(array_nums, operation):
        result_array = [0] * len(array_nums)
        for i in range(len(array_nums)):
            result_array[i] = operation(array_nums[i], i)
        return result_array

def multiply_array_by_index(array_nums):
        return transform_array(array_nums, lambda value, index: index * value)
