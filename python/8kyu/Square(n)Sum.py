def square_sum(numbers):
    if len(numbers) == 0:
        return 0
    sum = 0
    for i in range(len(numbers)):
        sum += numbers[i] ** 2
    return sum
