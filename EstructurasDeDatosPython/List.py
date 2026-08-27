def transform_array(array_nums, operation):
        result_array = [0] * len(array_nums)
        for i in range(len(array_nums)):
            result_array[i] = operation(array_nums[i], i)
        return result_array

def multiply_array_by_index(array_nums):
        return transform_array(array_nums, lambda value, index: index * value)

def change_odd_nums(array_nums):
        return transform_array(array_nums, lambda value, index: value if value % 2 == 0 else 0)


list = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

list2 = multiply_array_by_index(list)

list3 = change_odd_nums(list)

print(list)
print(list2)
print(list3)